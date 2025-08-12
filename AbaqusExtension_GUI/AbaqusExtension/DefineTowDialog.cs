using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbaqusExtension.GUI
{
    public partial class DefineTowDialog : Form
    {
        aTow tow;
        bool userMode = false; // variable used to avoid automatic change of angle units when loading data to the dialoge box

        public DefineTowDialog(aTow tow)
        {
            InitializeComponent();
            this.tow = tow;
            cbxCurveType.Items.AddRange(Enum.GetNames(typeof(aCurveTypes)));
            LoadComponents();
        }

        private void LoadComponents()
        {
            userMode = false; // avoid auto-conversion of angle units

            radRadians.Checked = tow.DisplayInRadians;
            radDegree.Checked = !tow.DisplayInRadians;

            if (tow.DisplayInRadians)
                txtBiasAngle.Text = tow.BraidAngle.ToString();
            else
                txtBiasAngle.Text = (tow.BraidAngle * 180 / Math.PI).ToString();

            txtTowWidth.Text = tow.TowWidth.ToString();

            for (int i = 0; i < tow.Path.Count; i++)
            {
                dgvPathCurves.Rows.Add();

                dgvPathCurves[0, i].Value = i + 1;
                dgvPathCurves[1, i].Value = tow.Path[i].CurveType;
                dgvPathCurves[2, i].Value = tow.Path[i].Start;
                dgvPathCurves[3, i].Value = tow.Path[i].End;

                if (tow.Path[i].CurveType == aCurveTypes.Arc)
                {
                    aArc arc = (aArc)tow.Path[i];
                    dgvPathCurves[4, i].Value = arc.Center;
                }
            }

            userMode = true; // allow auto-conversion of angle units
        }

        private bool ValidateCurveData()
        {
            try
            {
                
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void cbxCurveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCurveType.Text == aCurveTypes.Arc.ToString())
            {
                txtStart_X.Enabled = true;
                txtStart_Y.Enabled = true;
                txtStart_Z.Enabled = true;
                txtEnd_X.Enabled = true;
                txtEnd_Y.Enabled = true;
                txtEnd_Z.Enabled = true;
                txt3rdPt_X.Enabled = true;
                txt3rdPt_Y.Enabled = true;
                txt3rdPt_Z.Enabled = true;
                btnAddPathCurve.Enabled = true;
            }
            else if (cbxCurveType.Text == aCurveTypes.Line.ToString())
            {
                txtStart_X.Enabled = true;
                txtStart_Y.Enabled = true;
                txtStart_Z.Enabled = true;
                txtEnd_X.Enabled = true;
                txtEnd_Y.Enabled = true;
                txtEnd_Z.Enabled = true;
                txt3rdPt_X.Enabled = false;
                txt3rdPt_Y.Enabled = false;
                txt3rdPt_Z.Enabled = false;
                btnAddPathCurve.Enabled = true;
            }
            else
            {
                txtStart_X.Enabled = false;
                txtStart_Y.Enabled = false;
                txtStart_Z.Enabled = false;
                txtEnd_X.Enabled = false;
                txtEnd_Y.Enabled = false;
                txtEnd_Z.Enabled = false;
                txt3rdPt_X.Enabled = false;
                txt3rdPt_Y.Enabled = false;
                txt3rdPt_Z.Enabled = false;
                btnAddPathCurve.Enabled = false;
            }
        }

        private void btnAddPathCurve_Click(object sender, EventArgs e)
        {
            aPoint st = new aPoint();
            aPoint end = new aPoint();
            aPoint thdpt = new aPoint();
            aCurveTypes ctyp;

            Enum.TryParse<aCurveTypes>(cbxCurveType.Text, out ctyp);

            try
            {
                double val;


                if (double.TryParse(txtStart_X.Text, out val))
                    st.X = val;
                else
                    throw new Exception("Error in Start x coordinate.");
                if (double.TryParse(txtStart_Y.Text, out val))
                    st.Y = val;
                else
                    throw new Exception("Error in Start y coordinate.");
                if (double.TryParse(txtStart_Z.Text, out val))
                    st.Z = val;
                else
                    throw new Exception("Error in Start z coordinate.");

                if (double.TryParse(txtEnd_X.Text, out val))
                    end.X = val;
                else
                    throw new Exception("Error in End x coordinate.");
                if (double.TryParse(txtEnd_Y.Text, out val))
                    end.Y = val;
                else
                    throw new Exception("Error in End y coordinate.");
                if (double.TryParse(txtEnd_Z.Text, out val))
                    end.Z = val;
                else
                    throw new Exception("Error in End z coordinate.");

                if (ctyp == aCurveTypes.Arc)
                {
                    if (double.TryParse(txt3rdPt_X.Text, out val))
                        thdpt.X = val;
                    else
                        throw new Exception("Error in Third point x coordinate.");
                    if (double.TryParse(txt3rdPt_Y.Text, out val))
                        thdpt.Y = val;
                    else
                        throw new Exception("Error in Third point y coordinate.");
                    if (double.TryParse(txt3rdPt_Z.Text, out val))
                        thdpt.Z = val;
                    else
                        throw new Exception("Error in Third point z coordinate.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }

            dgvPathCurves.Rows.Add();
            int ind = dgvPathCurves.Rows.Count - 1;

            dgvPathCurves[1, ind].Value = ctyp.ToString();
            dgvPathCurves[2, ind].Value = st.X + ", " + st.Y + ", " + st.Z;
            dgvPathCurves[3, ind].Value = end.X + ", " + end.Y + ", " + end.Z;
            if (ctyp == aCurveTypes.Arc)
                dgvPathCurves[4, ind].Value = st.X + ", " + st.Y + ", " + st.Z;
        }

        private void dgvPathCurves_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RefreshPathID();
        }

        private void dgvPathCurves_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RefreshPathID();
        }

        private void RefreshPathID()
        {
            for (int i = 0; i < dgvPathCurves.Rows.Count; i++)
                dgvPathCurves[0, i].Value = i + 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double biasAng = 0.0;
            double towWdth = 0.0;

            try
            {
                if (radRadians.Checked)
                {
                    tow.DisplayInRadians = true;
                    biasAng = double.Parse(txtBiasAngle.Text);
                }
                else
                {
                    tow.DisplayInRadians = false;
                    biasAng = double.Parse(txtBiasAngle.Text) * Math.PI / 180;
                }

                if (Math.PI / -2 >= biasAng || biasAng >= Math.PI / 2)
                    throw new Exception("A bias angle has to be: -90 < value < 90 degrees.");

                towWdth = double.Parse(txtTowWidth.Text);

                if (towWdth <= 0.0)
                    throw new Exception("Tow width cannot be zero or negative.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aPoint pt = new aPoint();
            string[] coords;

            tow.BraidAngle = biasAng;
            tow.TowWidth = towWdth;

            tow.Path.Clear();
            aCurveTypes ctype;

            for (int i = 0; i < dgvPathCurves.Rows.Count; i++)
            {
                Enum.TryParse<aCurveTypes>(dgvPathCurves[1, i].Value.ToString(), out ctype);

                if (ctype == aCurveTypes.Arc)
                    tow.Path.Add(new aArc());
                if (ctype == aCurveTypes.Line)
                    tow.Path.Add(new aLine());

                coords = (dgvPathCurves[2, i].Value.ToString()).Split(',');
                pt.X = double.Parse(coords[0]);
                pt.Y = double.Parse(coords[1]);
                pt.Z = double.Parse(coords[2]);
                tow.Path[i].Start = pt;

                coords = (dgvPathCurves[3, i].Value.ToString()).Split(',');
                pt.X = double.Parse(coords[0]);
                pt.Y = double.Parse(coords[1]);
                pt.Z = double.Parse(coords[2]);
                tow.Path[i].End = pt;

                if (ctype == aCurveTypes.Arc)
                {
                    coords = (dgvPathCurves[4, i].Value.ToString()).Split(',');
                    pt.X = double.Parse(coords[0]);
                    pt.Y = double.Parse(coords[1]);
                    pt.Z = double.Parse(coords[2]);
                    aArc arc = (aArc)tow.Path[i];
                    arc.Center = pt;
                    tow.Path[i] = arc;
                }
            }

            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to clear?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            dgvPathCurves.Rows.Clear();

            txtStart_X.Text = "";
            txtStart_Y.Text = "";
            txtStart_Z.Text = "";
            txtEnd_X.Text = "";
            txtEnd_Y.Text = "";
            txtEnd_Z.Text = "";
            txt3rdPt_X.Text = "";
            txt3rdPt_Y.Text = "";
            txt3rdPt_Z.Text = "";

            txtBiasAngle.Text = "";
            txtTowWidth.Text = "";

            cbxCurveType.Text = "";
        }

        private void radDegree_CheckedChanged(object sender, EventArgs e)
        {
            if (userMode)
            {
                if (radDegree.Checked)
                    txtBiasAngle.Text = (double.Parse(txtBiasAngle.Text) * 180 / Math.PI).ToString();
                else
                    txtBiasAngle.Text = (double.Parse(txtBiasAngle.Text) * Math.PI / 180).ToString();
            }
        }


    }
}
