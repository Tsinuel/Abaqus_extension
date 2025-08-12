namespace AbaqusExtension.GUI
{
    partial class MeshDataDisplayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeshDataDisplayer));
            this.lbxNodes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxElems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxMaterials = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTotalNodes = new System.Windows.Forms.Label();
            this.lblTotalElems = new System.Windows.Forms.Label();
            this.lblTotalMat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxNodes
            // 
            this.lbxNodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxNodes.FormattingEnabled = true;
            this.lbxNodes.HorizontalScrollbar = true;
            this.lbxNodes.Location = new System.Drawing.Point(5, 35);
            this.lbxNodes.Name = "lbxNodes";
            this.lbxNodes.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxNodes.Size = new System.Drawing.Size(231, 550);
            this.lbxNodes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nodes";
            // 
            // lbxElems
            // 
            this.lbxElems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxElems.FormattingEnabled = true;
            this.lbxElems.HorizontalScrollbar = true;
            this.lbxElems.Location = new System.Drawing.Point(241, 35);
            this.lbxElems.Name = "lbxElems";
            this.lbxElems.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxElems.Size = new System.Drawing.Size(241, 550);
            this.lbxElems.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elements";
            // 
            // lbxMaterials
            // 
            this.lbxMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxMaterials.FormattingEnabled = true;
            this.lbxMaterials.HorizontalScrollbar = true;
            this.lbxMaterials.Location = new System.Drawing.Point(488, 35);
            this.lbxMaterials.Name = "lbxMaterials";
            this.lbxMaterials.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxMaterials.Size = new System.Drawing.Size(190, 485);
            this.lbxMaterials.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Materials";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(612, 621);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTotalNodes
            // 
            this.lblTotalNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalNodes.AutoSize = true;
            this.lblTotalNodes.Location = new System.Drawing.Point(1, 598);
            this.lblTotalNodes.Name = "lblTotalNodes";
            this.lblTotalNodes.Size = new System.Drawing.Size(43, 13);
            this.lblTotalNodes.TabIndex = 1;
            this.lblTotalNodes.Text = "Total = ";
            // 
            // lblTotalElems
            // 
            this.lblTotalElems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalElems.AutoSize = true;
            this.lblTotalElems.Location = new System.Drawing.Point(239, 598);
            this.lblTotalElems.Name = "lblTotalElems";
            this.lblTotalElems.Size = new System.Drawing.Size(43, 13);
            this.lblTotalElems.TabIndex = 1;
            this.lblTotalElems.Text = "Total = ";
            // 
            // lblTotalMat
            // 
            this.lblTotalMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMat.AutoSize = true;
            this.lblTotalMat.Location = new System.Drawing.Point(517, 598);
            this.lblTotalMat.Name = "lblTotalMat";
            this.lblTotalMat.Size = new System.Drawing.Size(43, 13);
            this.lblTotalMat.TabIndex = 1;
            this.lblTotalMat.Text = "Total = ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAddMaterial);
            this.groupBox1.Controls.Add(this.txtMaterialName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbxNodes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbxElems);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbxMaterials);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblTotalMat);
            this.groupBox1.Controls.Add(this.lblTotalNodes);
            this.groupBox1.Controls.Add(this.lblTotalElems);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 614);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMaterial.Location = new System.Drawing.Point(491, 532);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(186, 25);
            this.btnAddMaterial.TabIndex = 3;
            this.btnAddMaterial.Text = "Add Material ";
            this.toolTip1.SetToolTip(this.btnAddMaterial, resources.GetString("btnAddMaterial.ToolTip"));
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialName.Location = new System.Drawing.Point(575, 563);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(102, 20);
            this.txtMaterialName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Material Name";
            // 
            // MeshDataDisplayer
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeshDataDisplayer";
            this.ShowInTaskbar = false;
            this.Text = "Mesh Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxElems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxMaterials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTotalNodes;
        private System.Windows.Forms.Label lblTotalElems;
        private System.Windows.Forms.Label lblTotalMat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
    }
}