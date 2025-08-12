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
    public partial class MeshDataDisplayer : Form
    {
        aAssembly assembly;
        public MeshDataDisplayer(aAssembly assem)
        {
            InitializeComponent();
            assembly = assem;
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            foreach(aElement el in assembly.Elements)
            {
                string line = el.ID.ToString() + ",  " + el.Type.ToString() + ",  ";
                foreach (aNode nd in el.Nodes)
                    line += nd.ID.ToString() + ",  ";
                lbxElems.Items.Add(line);
            }

            foreach(aNode nd in assembly.Nodes)
            {
                lbxNodes.Items.Add(nd.ID.ToString() + ",  " + nd.Location.X + ",  " + nd.Location.Y + ",  " + nd.Location.Z);
            }

            foreach(string mat in assembly.Materials)
            {
                lbxMaterials.Items.Add(mat);
            }

            lblTotalElems.Text = "Total = " + assembly.Elements.Count;
            lblTotalNodes.Text = "Total = " + assembly.Nodes.Count;
            lblTotalMat.Text = "Total = " + assembly.Materials.Count;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will only add the name of the material for reference. The properties have to be defined manually after the output.\n\n  " +
                "Do you still want to add the material?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            if (txtMaterialName.Text == "")
                return;

            assembly.Materials.Add(txtMaterialName.Text);
            lbxMaterials.Items.Add(txtMaterialName.Text);
            lblTotalMat.Text = "Total = " + assembly.Materials.Count;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
