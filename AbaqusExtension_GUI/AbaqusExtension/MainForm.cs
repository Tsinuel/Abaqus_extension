using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AbaqusExtension.GUI
{
    public partial class MainForm : Form
    {
        aAssembly assembly;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseMeshFile_Click(object sender, EventArgs e)
        {
            if( ofdMeshFile.ShowDialog() == DialogResult.OK)
            {
                txtMeshFile.Text = ofdMeshFile.FileName;
            }

            if (File.Exists(txtMeshFile.Text))
            {
                int ind = txtMeshFile.Text.LastIndexOf("\\");
                txtWorkingFolder.Text = txtMeshFile.Text.Remove(ind);
            }
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            if (txtWorkingFolder.Text != "")
                fbwOutputFolder.SelectedPath = txtWorkingFolder.Text;
            if(fbwOutputFolder.ShowDialog() == DialogResult.OK)
            {
                txtWorkingFolder.Text = fbwOutputFolder.SelectedPath;
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtMeshFile.Text))
            {
                MessageBox.Show("The mesh file doesn't exist!");
                return;
            }

            if (assembly != null)
                if (MessageBox.Show("Over-write exsiting data?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

            string[] name = txtMeshFile.Text.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            string temp = name[name.Length - 1];

            if (txtModelName.Text != null || txtModelName.Text == "")
            {
                txtModelName.Text = temp.Remove(temp.Length - 4);
            }

            assembly = new aAssembly(txtMeshFile.Text, txtWorkingFolder.Text, temp.Remove(temp.Length - 4));

            bgwFileReader.RunWorkerAsync();

            gbxProgress.Visible = true;
            gbxInputOutput.Enabled = false;
        }

        private void RefreshMaterials()
        {
            dtvClmMaterial.Items.Clear();
            dtvClmMaterial.Items.AddRange(assembly.Materials.ToArray());

            lblMaterials.Text = "Matl. = " + assembly.Materials.Count;

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            MeshDataDisplayer mdd = new MeshDataDisplayer(assembly);
            mdd.ShowDialog();
            RefreshMaterials();
        }

        private void bgwFileRead_DoWork(object sender, DoWorkEventArgs e)
        {
            assembly.IOmanager.ReadFile();
        }

        private void bgwFileRead_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gbxProgress.Visible = false;
            gbxInputOutput.Enabled = true;
            RefreshMaterials();

            lblElements.Text =  "Elem = " + assembly.Elements.Count;
            lblNodes.Text =     "Nod. = " + assembly.Nodes.Count;
            lblMaterials.Text = "Matl. = " + assembly.Materials.Count;

            MessageBox.Show("Input file successfully read.\n\n" + "  Nodes =  \t" + assembly.Nodes.Count + "\n  Elements =\t" + assembly.Elements.Count,
                 "Work compeleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbxTowDefinition.Enabled = true;
            btnImportInput.Enabled = true;
            btnSaveInput.Enabled = true;
            btnShowData.Enabled = true;
            btnRun.Enabled = true;
            btnRefineNodes.Enabled = true;
            this.Text = "Abaqus extension (" + txtMeshFile.Text + ")";
            dgvTowDefinition.Rows.Clear();

            //
            // Fill in the unit cell sizes in the PBC tab
            //
            txtStartCoordinate_X.Text = assembly.Minimum_X.ToString();
            txtStartCoordinate_Y.Text = assembly.Minimum_Y.ToString();
            txtStartCoordinate_Z.Text = assembly.Minimum_Z.ToString();

            txtVector_X.Text = (assembly.Maximum_X - assembly.Minimum_X).ToString();
            txtVector_Y.Text = (assembly.Maximum_Y - assembly.Minimum_Y).ToString();
            txtVector_Z.Text = (assembly.Maximum_Z - assembly.Minimum_Z).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            bgwFileReader.CancelAsync();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //TempInput();
            //bgwExecuter.RunWorkerAsync();
            //return;

            double elemGrpg;
            int[,] elemNos;
            string[] mats;

            if (CheckData(out elemGrpg, out elemNos, out mats))
            {
                A:
                if (assembly.Tows.Count > dgvTowDefinition.Rows.Count - 1)
                {
                    assembly.Tows.RemoveAt(assembly.Tows.Count - 1);
                    goto A;
                }

                assembly.ElemGroupingLength = elemGrpg;

                for (int i = 0; i < dgvTowDefinition.Rows.Count - 1; i++)
                {
                    assembly.Tows[i].StartElemNo = elemNos[i, 0];
                    assembly.Tows[i].EndElemNo = elemNos[i, 1];
                    assembly.Tows[i].Material = mats[i];
                }
                ReadGENOA_data();
                assembly.GenGENOAdata = chkGenerateGENOA.Checked;
                assembly.NumbOfAxialTows = (int)nudNumbOfAxialTows.Value;

                bgwExecuter.RunWorkerAsync();

                gbxInputOutput.Enabled = false;
                gbxTowDefinition.Enabled = false;
                btnImportInput.Enabled = false;
                btnSaveInput.Enabled = false;
                btnShowData.Enabled = false;
                btnRun.Enabled = false;

                gbxProgress.Visible = true;
                lblProgress.Text = "Generating ori...";

            }
        }

        private bool CheckData(out double elemGrpg, out int[,] elemNos, out string[] mats)
        {
            int noOftows = dgvTowDefinition.Rows.Count - 1;
            elemNos = new int[noOftows, 2];
            mats = new string[noOftows];

            try
            {
                if (noOftows == 0)
                    throw new Exception("Tow information has to be entered.");

                elemGrpg = double.Parse(txtElemGroupingLength.Text);
                if (elemGrpg <= 0)
                    throw new Exception("Element grouping length cannot be zero or negative.");

                for (int i = 0; i < noOftows; i++)
                {
                    elemNos[i, 0] = int.Parse(dgvTowDefinition[1, i].Value.ToString());
                    elemNos[i, 1] = int.Parse(dgvTowDefinition[2, i].Value.ToString());

                    if (elemNos[i, 0] <= 0 || elemNos[i, 1] <= 0)
                        throw new Exception("Element number has to be non-zero positive integer.");

                    mats[i] = dgvTowDefinition[3, i].Value.ToString();
                }

                if (!Directory.Exists(txtWorkingFolder.Text))
                    Directory.CreateDirectory(txtWorkingFolder.Text);

            }
            catch (Exception exc)
            {
                elemGrpg = 1.0;
                MessageBox.Show(exc.Message + "\n\n  Check the following:\n\t1. Element numbers\n\t2. Material names\n\t3. Orientation density", "Error!");
                return false;
            }

            return true;
        }

        private void TempInput()
        {
            assembly.ElemGroupingLength = 0.1; // 1.36;

            aTow tow = new aTow(assembly);
            aArc arc;
            aLine line;
            //
            // Axial tow
            //
            tow.BraidAngle = 0.0;
            tow.StartElemNo = 866;
            tow.EndElemNo = 2276;
            tow.Material = "AxialTow";
            tow.TowWidth = 2.6;
            line = new aLine();
            line.Start = new aPoint(-3.46410162, 0.0, 0.0);
            line.End = new aPoint(3.46410162, 0.0, 0.0);
            tow.Path.Add(line);
            assembly.Tows.Add(tow);

            //
            // -ve tow
            //
            tow = new aTow(assembly);
            tow.BraidAngle = -0.5235987756;  //-30 deg
            tow.StartElemNo = 2277;
            tow.EndElemNo = 3257;
            tow.Material = "BiasTow";
            tow.TowWidth = 2.1655020;

            arc = new aArc();
            arc.Start = new aPoint(-10.39230485, 6, 0);
            arc.End = new aPoint(-3.4641, 2, 0);
            //arc.ThirdPt = new aPoint(-6.9292, 4, 0.7397);
            arc.Center = new aPoint(-6.92820323, 4.00000000, -10.44109280);
            tow.Path.Add(arc);

            arc = new aArc();
            arc.Start = new aPoint(-3.4641, 2, 0);
            arc.End = new aPoint(3.4641, -2, 0);
            //arc.ThirdPt = new aPoint(0, 0, -0.7403);
            arc.Center = new aPoint(0.00000000, 0.00000000, 10.44052882);
            tow.Path.Add(arc);

            arc = new aArc();
            arc.Start = new aPoint(3.4641, -2, 0);
            arc.End = new aPoint(10.3923, -6, 0);
            //arc.ThirdPt = new aPoint(6.9292, -4, 0.7397);
            arc.Center = new aPoint(6.92820323, -4.00000000, -10.44109280);
            tow.Path.Add(arc);

            assembly.Tows.Add(tow);
            //
            //
            //

        }

        private void bgwExecuter_DoWork(object sender, DoWorkEventArgs e)
        {
            assembly.AssignOrientation();
            assembly.Write(txtWorkingFolder.Text + "\\" + txtModelName.Text + "_Ori.inp");
        }

        private void bgwExecuter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Done!");

            gbxInputOutput.Enabled = true;
            gbxTowDefinition.Enabled = true;
            btnImportInput.Enabled = true;
            btnSaveInput.Enabled = true;
            btnShowData.Enabled = true;
            btnRun.Enabled = true;

            gbxProgress.Visible = false;
                    }

        private void dtvTows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 || e.RowIndex == dgvTowDefinition.Rows.Count - 1)
                return;

            int id = int.Parse(dgvTowDefinition[0, e.RowIndex].Value.ToString());
            DefineTowDialog dtd = new DefineTowDialog(assembly.Tows[id - 1]);
            dtd.ShowDialog();

        }

        private void dtvTows_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void RefreshTowID()
        {
            for (int i = 0; i < dgvTowDefinition.Rows.Count - 1; i++)
                dgvTowDefinition[0, i].Value = i + 1;
        }

        private void dtvTows_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //RefreshTowID();
        }

        private void dgvTowDefinition_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            int id = int.Parse(e.Row.Cells[0].Value.ToString());
            assembly.RemoveTow(id);

        }

        private void dgvTowDefinition_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTowDefinition_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex <= 0 || e.RowIndex <= 0)
            //    return;
            //if (e.ColumnIndex != 1 && e.ColumnIndex != 2 && e.ColumnIndex != 3)
            //    return;

            //int idx = e.RowIndex;

            //if (e.ColumnIndex == 3)
            //{
            //    assembly.Tows[idx].Material = dgvTowDefinition[e.ColumnIndex, e.RowIndex].Value.ToString();
            //    return;
            //}

            //int val;
            //try
            //{
            //    val = int.Parse(dgvTowDefinition[e.ColumnIndex, e.RowIndex].Value.ToString());

            //    if (val <= 0)
            //        throw new Exception("Element number should be a positive non-zero integer.");

            //    if (e.ColumnIndex == 1)
            //        assembly.Tows[idx].ElemNo_Start = val;
            //    else if (e.ColumnIndex == 2)
            //        assembly.Tows[idx].ElemNo_End = val;
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dgvTowDefinition[e.ColumnIndex, e.RowIndex].Value = null;
            //    return;
            //}
        }

        private void btnSaveInput_Click(object sender, EventArgs e)
        {
            double elemGrpg;
            int[,] elemNos;
            string[] mats;

            if (CheckData(out elemGrpg, out elemNos, out mats))
            {

                assembly.ElemGroupingLength = elemGrpg;

                for (int i = 0; i < dgvTowDefinition.Rows.Count - 1; i++)
                {
                    assembly.Tows[i].StartElemNo = elemNos[i, 0];
                    assembly.Tows[i].EndElemNo = elemNos[i, 1];
                    assembly.Tows[i].Material = mats[i];
                }

                StreamWriter sw = new StreamWriter(txtWorkingFolder.Text + "\\" + txtModelName.Text + "_inpt.txt");

                sw.WriteLine(assembly.ElemGroupingLength);

                foreach (aTow tow in assembly.Tows)
                {
                    sw.WriteLine("Tow");
                    sw.WriteLine(tow.StartElemNo + ", " + tow.EndElemNo + ", " + tow.Material + ", " + tow.TowWidth + ", " + (tow.BraidAngle * 180 / Math.PI));

                    foreach (aI2DcurveInSpace curve in tow.Path)
                    {
                        switch (curve.CurveType)
                        {
                            case aCurveTypes.Arc:
                                {
                                    sw.WriteLine("Arc");
                                    sw.WriteLine(curve.Start.ToString());
                                    sw.WriteLine(curve.End.ToString());
                                    sw.WriteLine(((aArc)curve).Center.ToString());
                                    break;
                                }
                            case aCurveTypes.Line:
                                {
                                    sw.WriteLine("Line");
                                    sw.WriteLine(curve.Start.ToString());
                                    sw.WriteLine(curve.End.ToString());
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                    }
                }

                sw.Close();
            }
        }

        private void btnImportInput_Click(object sender, EventArgs e)
        {
            if (assembly.Tows.Count > 0 && MessageBox.Show("Are you sure to over-write the existing input information?", "Warning!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (ofdInput.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofdInput.FileName);

                assembly.ElemGroupingLength = double.Parse(sr.ReadLine());
                txtElemGroupingLength.Text = assembly.ElemGroupingLength.ToString();

                assembly.Tows.Clear();

                aTow tow = new aTow(assembly);
                aArc arc = new aArc();
                aLine line = new aLine();
                string txtLine;
                string[] towProps;

                while (!sr.EndOfStream)
                {
                    txtLine = sr.ReadLine();

                    if (txtLine == "Tow")
                    {
                        if (tow.Path.Count > 0)
                        {
                            assembly.Tows.Add(tow);
                        }
                        tow = new aTow(assembly);
                        towProps = (sr.ReadLine()).Split(',');
                        tow.StartElemNo = int.Parse(towProps[0]);
                        tow.EndElemNo = int.Parse(towProps[1]);
                        tow.Material = (towProps[2]).Trim();
                        tow.TowWidth = double.Parse(towProps[3]);
                        tow.BraidAngle = (double.Parse(towProps[4])) * Math.PI / 180;
                        tow.SetID(assembly.Tows.Count + 1);
                    }

                    if (txtLine == "Arc")
                    {
                        arc.Start = new aPoint(sr.ReadLine());
                        arc.End = new aPoint(sr.ReadLine());
                        arc.Center = new aPoint(sr.ReadLine());
                        tow.Path.Add(arc);
                    }

                    if (txtLine == "Line")
                    {
                        line.Start = new aPoint(sr.ReadLine());
                        line.End = new aPoint(sr.ReadLine());
                        tow.Path.Add(line);
                    }

                }
                assembly.Tows.Add(tow);

                dgvTowDefinition.Rows.Clear();
                dgvTowDefinition.Rows.Add(assembly.Tows.Count);

                for (int i = 0; i < assembly.Tows.Count; i++)
                {
                    dgvTowDefinition[0, i].Value = assembly.Tows[i].ID;
                    dgvTowDefinition[1, i].Value = assembly.Tows[i].StartElemNo;
                    dgvTowDefinition[2, i].Value = assembly.Tows[i].EndElemNo;
                    dgvTowDefinition[3, i].Value = GetdtvMat(assembly.Tows[i].Material);

                }


            }
        }

        private object GetdtvMat(string material)
        {
            foreach(var m in dtvClmMaterial.Items)
            {
                if (m.ToString() == material)
                    return m;
            }

            return null;
        }

        private void dgvTowDefinition_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dgvTowDefinition.RowCount <= 1)
                return;
            RefreshTowID();
            assembly.Tows.Add(new aTow(assembly));
            assembly.RefreshTowID();
        }

        private void btnRunNodeRefinement_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtWorkingFolder.Text))
                assembly.IOmanager.Directory = txtWorkingFolder.Text;

            /*
            * limits
            * [ X_min, X_max
            *   Y_min, Y_max
            *   Z_min, Z_max ]
            */

            //double minX, minY, minZ;
            double vectorX, vectorY, vectorZ;
            double tolX, tolY, tolZ;
            double[,] limits = new double[3, 2];

            vectorX = double.Parse(txtVector_X.Text);
            tolX = double.Parse(txtTolerance_X.Text);
            limits[0, 0] = double.Parse(txtStartCoordinate_X.Text);
            limits[0, 1] = limits[0, 0] + vectorX;

            vectorY = double.Parse(txtVector_Y.Text);
            tolY = double.Parse(txtTolerance_Y.Text);
            limits[1, 0] = double.Parse(txtStartCoordinate_Y.Text);
            limits[1, 1] = limits[1, 0] + vectorY;

            vectorZ = double.Parse(txtVector_Z.Text);
            tolZ = double.Parse(txtTolerance_Z.Text);
            limits[2, 0] = double.Parse(txtStartCoordinate_Z.Text);
            limits[2, 1] = limits[2, 0] + vectorZ;

            assembly.CoordLimits = limits;
            assembly.Vectors = new double[] { vectorX, vectorY, vectorZ };
            assembly.Tolerances = new double[] { tolX, tolY, tolZ };

            //equation Set matrix definition
            // X - direction DOF 1
            // X - direction DOF 2
            // X - direction DOF 3
            // Y - direction DOF 1
            // Y - direction DOF 2
            // Y - direction DOF 3
            // Z - direction DOF 1
            // Z - direction DOF 2
            // Z - direction DOF 3

            if (rbtAutomaticPBC.Checked)
            {
                assembly.ManualMasterNodes = false;

                if (chkAutoPBC_asymUA.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type1, aEquationType.Type2, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type1, aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.Type1};

                    WritePBCfile(eqnSets, "PBC_asymUA", aPBCtype.Asymm);
                }

                if(chkAutoPBC_asymShXY.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type2, aEquationType.Type1, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.Type2};

                    WritePBCfile(eqnSets, "PBC_asymShearXY", aPBCtype.Asymm);
                }

                if(chkAutoPBC_freeUA.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type1, aEquationType.Type2, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type1, aEquationType.Type2, aEquationType.None, aEquationType.None, aEquationType.None};

                    WritePBCfile(eqnSets, "PBC_freeUA", aPBCtype.Free);
                }

                if(chkAutoPBC_freeShXY.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type2, aEquationType.Type1, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.None, aEquationType.None, aEquationType.None};

                    WritePBCfile(eqnSets, "PBC_freeShearXY", aPBCtype.Free);
                }

                if (chkAutoPBC_symmUA.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type1, aEquationType.Type2, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type1, aEquationType.Type2, aEquationType.None, aEquationType.None, aEquationType.None};

                    WritePBCfile(eqnSets, "PBC_symmUA", aPBCtype.Symm);
                }

                if(chkAutoPBC_symmShXY.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type2, aEquationType.Type1, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.None, aEquationType.None, aEquationType.None};

                    WritePBCfile(eqnSets, "PBC_symmShearXY", aPBCtype.Symm);
                }

                if(chkAutoPBC_symmForGENOA.Checked)
                {
                    aEquationType[] eqnSets = new aEquationType[] { aEquationType.Type2, aEquationType.Type1, aEquationType.Type2,
                     aEquationType.Type2, aEquationType.Type2, aEquationType.Type2, aEquationType.None, aEquationType.None, aEquationType.None};

                    WritePBCfile(eqnSets, "PBC_symmUA_forGENOA", aPBCtype.SymmForGENOA);
                }

                MessageBox.Show("The selected PBC files have been written to the working folder!", "Job complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                aEquationType[] eqnSets = GetManualEquationSets();

                if (chkManualMasterNode.Checked)
                {
                    assembly.ManualMasterNodes = chkManualMasterNode.Checked;
                    assembly.ManualMasterNode_X = new int[] { (int)nudMasterNodeX_src.Value, (int)nudMasterNodeX_trgt.Value };
                    assembly.ManualMasterNode_Y = new int[] { (int)nudMasterNodeY_src.Value, (int)nudMasterNodeY_trgt.Value };
                    assembly.ManualMasterNode_Z = new int[] { (int)nudMasterNodeZ_src.Value, (int)nudMasterNodeZ_trgt.Value };
                }

                WritePBCfile(eqnSets, "PBCs", aPBCtype.UserDefined);

                MessageBox.Show("The chosen equation constraints have been written to the working folder!", "Job complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            if (chkWriteRefinedMesh.Checked)
                assembly.WriteRefinedMeshFile();

        }

        private void WritePBCfile(aEquationType[] eqnSets, string fileName, aPBCtype PBCtype)
        {
            try
            {
                if (File.Exists(assembly.IOmanager.Directory + "\\" + assembly.ModelName + "_" + fileName + ".inp"))
                {
                    if (MessageBox.Show("PBC file \"" + assembly.IOmanager.Directory + "\\" + assembly.ModelName + "_" + fileName + ".inp\"." +
                        "\n\n   Do you want to replace the PBC file?", "Replace PBC file?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                    {
                        File.Delete(assembly.IOmanager.Directory + "\\" + assembly.ModelName + "_" + fileName + ".inp");
                    }
                }
            }
            catch { }

            if (PBCtype != aPBCtype.SymmForGENOA)
            {
                assembly.ApplyPBCs(fileName, aCoordinate.X, eqnSets, PBCtype);
                assembly.ApplyPBCs(fileName, aCoordinate.Y, eqnSets, PBCtype);
            }
            assembly.ApplyPBCs(fileName, aCoordinate.Z, eqnSets, PBCtype);
        }

        private aEquationType[] GetManualEquationSets()
        {
            aEquationType[] eqnSets = new aEquationType[9];

            //
            // X
            //
            if (cbxXX.Checked)
            {
                if (rbtXX_1.Checked)
                    eqnSets[0] = aEquationType.Type1;
                else
                    eqnSets[0] = aEquationType.Type2;
            }
            else
                eqnSets[0] = aEquationType.None;


            if (cbxXY.Checked)
            {
                if (rbtXY_1.Checked)
                    eqnSets[1] = aEquationType.Type1;
                else
                    eqnSets[1] = aEquationType.Type2;
            }
            else
                eqnSets[1] = aEquationType.None;


            if (cbxXZ.Checked)
            {
                if (rbtXZ_1.Checked)
                    eqnSets[2] = aEquationType.Type1;
                else
                    eqnSets[2] = aEquationType.Type2;
            }
            else
                eqnSets[2] = aEquationType.None;
            //
            // Y
            //
            if (cbxYX.Checked)
            {
                if (rbtYX_1.Checked)
                    eqnSets[3] = aEquationType.Type1;
                else
                    eqnSets[3] = aEquationType.Type2;
            }
            else
                eqnSets[3] = aEquationType.None;


            if (cbxYY.Checked)
            {
                if (rbtYY_1.Checked)
                    eqnSets[4] = aEquationType.Type1;
                else
                    eqnSets[4] = aEquationType.Type2;
            }
            else
                eqnSets[4] = aEquationType.None;


            if (cbxYZ.Checked)
            {
                if (rbtYZ_1.Checked)
                    eqnSets[5] = aEquationType.Type1;
                else
                    eqnSets[5] = aEquationType.Type2;
            }
            else
                eqnSets[5] = aEquationType.None;

            //
            // Z
            //
            if (cbxZX.Checked)
            {
                if (rbtZX_1.Checked)
                    eqnSets[6] = aEquationType.Type1;
                else
                    eqnSets[6] = aEquationType.Type2;
            }
            else
                eqnSets[6] = aEquationType.None;


            if (cbxZY.Checked)
            {
                if (rbtZY_1.Checked)
                    eqnSets[7] = aEquationType.Type1;
                else
                    eqnSets[7] = aEquationType.Type2;
            }
            else
                eqnSets[7] = aEquationType.None;


            if (cbxZZ.Checked)
            {
                if (rbtZZ_1.Checked)
                    eqnSets[8] = aEquationType.Type1;
                else
                    eqnSets[8] = aEquationType.Type2;
            }
            else
                eqnSets[8] = aEquationType.None;

            return eqnSets;
        }

        private void chkXdirection_CheckedChanged(object sender, EventArgs e)
        {
            //txtStartCoordinate_X.Enabled = chkXdirection.Checked;
            //txtTolerance_X.Enabled = chkXdirection.Checked;
            //txtVector_X.Enabled = chkXdirection.Checked;
            //cbxXX.Enabled = cbxXY.Enabled = cbxXZ.Enabled = chkXdirection.Checked;
        }

        private void chkYdirection_CheckedChanged(object sender, EventArgs e)
        {
            //txtStartCoordinate_Y.Enabled = chkYdirection.Checked;
            //txtTolerance_Y.Enabled = chkYdirection.Checked;
            //txtVector_Y.Enabled = chkYdirection.Checked;
            //cbxYX.Enabled = cbxYY.Enabled = cbxYZ.Enabled = chkYdirection.Checked;
        }

        private void chkZdirection_CheckedChanged(object sender, EventArgs e)
        {
            //txtStartCoordinate_Z.Enabled = chkZdirection.Checked;
            //txtTolerance_Z.Enabled = chkZdirection.Checked;
            //txtVector_Z.Enabled = chkZdirection.Checked;
            //cbxZX.Enabled = cbxZY.Enabled = cbxZZ.Enabled = chkZdirection.Checked;
        }

        private void cbxXX_CheckedChanged(object sender, EventArgs e)
        {
            gbxXX.Enabled = cbxXX.Checked && cbxXX.Enabled;
        }

        private void cbxXY_CheckedChanged(object sender, EventArgs e)
        {
            gbxXY.Enabled = cbxXY.Checked;
        }

        private void cbxXZ_CheckedChanged(object sender, EventArgs e)
        {
            gbxXZ.Enabled = cbxXZ.Checked;
        }

        private void cbxYX_CheckedChanged(object sender, EventArgs e)
        {
            gbxYX.Enabled = cbxYX.Checked;
        }

        private void cbxYY_CheckedChanged(object sender, EventArgs e)
        {
            gbxYY.Enabled = cbxYY.Checked;
        }

        private void cbxYZ_CheckedChanged(object sender, EventArgs e)
        {
            gbxYZ.Enabled = cbxYZ.Checked;
        }

        private void cbxZX_CheckedChanged(object sender, EventArgs e)
        {
            gbxZX.Enabled = cbxZX.Checked;
        }

        private void cbxZY_CheckedChanged(object sender, EventArgs e)
        {
            gbxZY.Enabled = cbxZY.Checked;
        }

        private void cbxZZ_CheckedChanged(object sender, EventArgs e)
        {
            gbxZZ.Enabled = cbxZZ.Checked;
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            cbxXX.Checked = cbxXY.Checked = cbxXZ.Checked = cbxYX.Checked = cbxYY.Checked = cbxYZ.Checked = cbxZX.Checked = cbxZY.Checked = cbxZZ.Checked = cbxAll.Checked;
        }

        private void ReadGENOA_data()
        {
            double[,] data_GENOA = new double[8, 3];

            data_GENOA[0, 0] = (double)nudMatxFibID.Value; 
            data_GENOA[0, 1] = (double)nudAxlTowFibrID.Value;
            data_GENOA[0, 2] = (double)nudBiasTowFibrID.Value;

            data_GENOA[1, 0] = (double)nudMatxMatxID.Value;
            data_GENOA[1, 1] = (double)nudAxlTowMatxID.Value;
            data_GENOA[1, 2] = (double)nudBiasTowMatxID.Value;
 
            data_GENOA[2, 0] = double.Parse(txtMatxThick.Text);
            data_GENOA[2, 1] = double.Parse(txtAxlTowThick.Text);
            data_GENOA[2, 2] = double.Parse(txtBiasTowThick.Text);

            data_GENOA[3, 0] = double.Parse(txtMatxAng.Text);
            data_GENOA[3, 1] = double.Parse(txtAxlTowAng.Text);
            data_GENOA[3, 2] = double.Parse(txtBiasTowAng.Text);

            data_GENOA[4, 0] = double.Parse(txtMatxF_fract.Text);
            data_GENOA[4, 1] = double.Parse(txtAxlTowF_fract.Text);
            data_GENOA[4, 2] = double.Parse(txtBiasTowF_fract.Text);

            data_GENOA[5, 0] = double.Parse(txtMatxV_fract.Text);
            data_GENOA[5, 1] = double.Parse(txtAxlTowV_fract.Text);
            data_GENOA[5, 2] = double.Parse(txtBiasTowV_fract.Text);

            data_GENOA[6, 0] = (double)nudMatxFailCrit.Value;
            data_GENOA[6, 1] = (double)nudAxlTowFailCrit.Value;
            data_GENOA[6, 2] = (double)nudBiasTowFailCrit.Value;

            data_GENOA[7, 0] = double.Parse(txtMatxTemp.Text);
            data_GENOA[7, 1] = double.Parse(txtAxlTowTemp.Text);
            data_GENOA[7, 2] = double.Parse(txtBiasTowTemp.Text);

            assembly.GENOA_data = data_GENOA;
       }

        private void radTowMat_FibrMatx_CheckedChanged(object sender, EventArgs e)
        {
            //if (radTowMat_FibrMatx.Checked)
            //{
            //    nudMatxFibID.Value = 0;
            //    nudMatxMatxID.Value = 2;

            //    nudAxlTowFibrID.Value = 1;
            //    nudAxlTowMatxID.Value = 2;

            //    nudBiasTowFibrID.Value = 1;
            //    nudBiasTowMatxID.Value = 2; 
                
            //    nudMatxMatxID.Enabled = true;
            //    nudAxlTowMatxID.Enabled = true;
            //    nudBiasTowMatxID.Enabled = true;
            //    nudMatxFibID.Enabled = false;
            //}
            //else
            //{
            //    nudMatxFibID.Value = 5;
            //    nudMatxMatxID.Value = 0;

            //    nudAxlTowFibrID.Value = 3;
            //    nudAxlTowMatxID.Value = 0;

            //    nudBiasTowFibrID.Value = 4;
            //    nudBiasTowMatxID.Value = 0;

            //    nudMatxMatxID.Enabled = false;
            //    nudAxlTowMatxID.Enabled = false;
            //    nudBiasTowMatxID.Enabled = false;
            //    nudMatxFibID.Enabled = true;
            //}
        }

        private void radTowMat_Ply_CheckedChanged(object sender, EventArgs e)
        {
            if (radTowMat_FibrMatx.Checked)
            {
                nudMatxFibID.Value = 0;
                nudMatxMatxID.Value = 2;

                nudAxlTowFibrID.Value = 1;
                nudAxlTowMatxID.Value = 2;

                nudBiasTowFibrID.Value = 1;
                nudBiasTowMatxID.Value = 2;

                nudMatxMatxID.Enabled = true;
                nudAxlTowMatxID.Enabled = true;
                nudBiasTowMatxID.Enabled = true;
                nudMatxFibID.Enabled = false;
            }
            else
            {
                nudMatxFibID.Value = 5;
                nudMatxMatxID.Value = 0;

                nudAxlTowFibrID.Value = 3;
                nudAxlTowMatxID.Value = 0;

                nudBiasTowFibrID.Value = 4;
                nudBiasTowMatxID.Value = 0;

                nudMatxMatxID.Enabled = false;
                nudAxlTowMatxID.Enabled = false;
                nudBiasTowMatxID.Enabled = false;
                nudMatxFibID.Enabled = true;
            }
        }

        private void chkGenerateGENOA_CheckedChanged(object sender, EventArgs e)
        {
            gbxGENOAinput.Enabled = chkGenerateGENOA.Checked;
        }

        private void chkManualMasterNode_CheckedChanged(object sender, EventArgs e)
        {
            gbxManualMasterNodes.Enabled = chkManualMasterNode.Checked;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        
        }

        private void rbtAutomaticPBC_CheckedChanged(object sender, EventArgs e)
        {
            gbxAutomaticPBC.Enabled = rbtAutomaticPBC.Checked;
            gbxManualPBC.Enabled = rbtManualPBC.Checked;
        }

        private void txtModelName_TextChanged(object sender, EventArgs e)
        {
            if (assembly != null)
                assembly.ModelName = txtModelName.Text;
        }

        private void txtWorkingFolder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                assembly.IOmanager.Directory = txtWorkingFolder.Text;
            }
            catch { }
        }
    }
}
