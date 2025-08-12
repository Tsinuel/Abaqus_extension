namespace AbaqusExtension.GUI
{
    partial class DefineTowDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineTowDialog));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDegree = new System.Windows.Forms.RadioButton();
            this.radRadians = new System.Windows.Forms.RadioButton();
            this.txtBiasAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTowWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPathCurves = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPathCurve = new System.Windows.Forms.Button();
            this.cbxCurveType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt3rdPt_Z = new System.Windows.Forms.TextBox();
            this.txtEnd_Z = new System.Windows.Forms.TextBox();
            this.txtStart_Z = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt3rdPt_Y = new System.Windows.Forms.TextBox();
            this.txtEnd_Y = new System.Windows.Forms.TextBox();
            this.txtStart_Y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt3rdPt_X = new System.Windows.Forms.TextBox();
            this.txtEnd_X = new System.Windows.Forms.TextBox();
            this.txtStart_X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPathCurves)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radDegree);
            this.groupBox1.Controls.Add(this.radRadians);
            this.groupBox1.Controls.Add(this.txtBiasAngle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTowWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Parameters";
            // 
            // radDegree
            // 
            this.radDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radDegree.AutoSize = true;
            this.radDegree.Checked = true;
            this.radDegree.Location = new System.Drawing.Point(387, 61);
            this.radDegree.Name = "radDegree";
            this.radDegree.Size = new System.Drawing.Size(43, 17);
            this.radDegree.TabIndex = 3;
            this.radDegree.TabStop = true;
            this.radDegree.Text = "deg";
            this.radDegree.UseVisualStyleBackColor = true;
            this.radDegree.CheckedChanged += new System.EventHandler(this.radDegree_CheckedChanged);
            // 
            // radRadians
            // 
            this.radRadians.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radRadians.AutoSize = true;
            this.radRadians.Location = new System.Drawing.Point(346, 61);
            this.radRadians.Name = "radRadians";
            this.radRadians.Size = new System.Drawing.Size(40, 17);
            this.radRadians.TabIndex = 3;
            this.radRadians.Text = "rad";
            this.radRadians.UseVisualStyleBackColor = true;
            // 
            // txtBiasAngle
            // 
            this.txtBiasAngle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiasAngle.Location = new System.Drawing.Point(120, 60);
            this.txtBiasAngle.Name = "txtBiasAngle";
            this.txtBiasAngle.Size = new System.Drawing.Size(218, 20);
            this.txtBiasAngle.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtBiasAngle, "The acute angle between the bias tow and axial tow measured CCW positive.\r\nIts ab" +
        "solute value cannot exceed 90 degrees. Assign a value of 0 for axial tows.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Braiding angle, θ :";
            // 
            // txtTowWidth
            // 
            this.txtTowWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTowWidth.Location = new System.Drawing.Point(120, 31);
            this.txtTowWidth.Name = "txtTowWidth";
            this.txtTowWidth.Size = new System.Drawing.Size(218, 20);
            this.txtTowWidth.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtTowWidth, "The width of the bias tow as measured perpendicular to its center line.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tow width, w :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvPathCurves);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(10, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 390);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path definition";
            // 
            // dgvPathCurves
            // 
            this.dgvPathCurves.AllowUserToAddRows = false;
            this.dgvPathCurves.AllowUserToResizeRows = false;
            this.dgvPathCurves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPathCurves.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPathCurves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPathCurves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPathCurves.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPathCurves.Location = new System.Drawing.Point(5, 159);
            this.dgvPathCurves.Name = "dgvPathCurves";
            this.dgvPathCurves.RowTemplate.Height = 23;
            this.dgvPathCurves.Size = new System.Drawing.Size(496, 224);
            this.dgvPathCurves.TabIndex = 15;
            this.dgvPathCurves.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPathCurves_RowsAdded);
            this.dgvPathCurves.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvPathCurves_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Center";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnAddPathCurve);
            this.groupBox3.Controls.Add(this.cbxCurveType);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt3rdPt_Z);
            this.groupBox3.Controls.Add(this.txtEnd_Z);
            this.groupBox3.Controls.Add(this.txtStart_Z);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt3rdPt_Y);
            this.groupBox3.Controls.Add(this.txtEnd_Y);
            this.groupBox3.Controls.Add(this.txtStart_Y);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt3rdPt_X);
            this.groupBox3.Controls.Add(this.txtEnd_X);
            this.groupBox3.Controls.Add(this.txtStart_X);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(5, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 131);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Curve selection";
            // 
            // btnAddPathCurve
            // 
            this.btnAddPathCurve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPathCurve.Location = new System.Drawing.Point(39, 87);
            this.btnAddPathCurve.Name = "btnAddPathCurve";
            this.btnAddPathCurve.Size = new System.Drawing.Size(174, 28);
            this.btnAddPathCurve.TabIndex = 14;
            this.btnAddPathCurve.Text = "Add";
            this.btnAddPathCurve.UseVisualStyleBackColor = true;
            this.btnAddPathCurve.Click += new System.EventHandler(this.btnAddPathCurve_Click);
            // 
            // cbxCurveType
            // 
            this.cbxCurveType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCurveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurveType.FormattingEnabled = true;
            this.cbxCurveType.Location = new System.Drawing.Point(39, 31);
            this.cbxCurveType.Name = "cbxCurveType";
            this.cbxCurveType.Size = new System.Drawing.Size(175, 21);
            this.cbxCurveType.TabIndex = 4;
            this.cbxCurveType.SelectedIndexChanged += new System.EventHandler(this.cbxCurveType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type";
            // 
            // txt3rdPt_Z
            // 
            this.txt3rdPt_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt3rdPt_Z.Enabled = false;
            this.txt3rdPt_Z.Location = new System.Drawing.Point(421, 92);
            this.txt3rdPt_Z.Name = "txt3rdPt_Z";
            this.txt3rdPt_Z.Size = new System.Drawing.Size(65, 20);
            this.txt3rdPt_Z.TabIndex = 13;
            this.txt3rdPt_Z.Text = "0";
            // 
            // txtEnd_Z
            // 
            this.txtEnd_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd_Z.Enabled = false;
            this.txtEnd_Z.Location = new System.Drawing.Point(421, 62);
            this.txtEnd_Z.Name = "txtEnd_Z";
            this.txtEnd_Z.Size = new System.Drawing.Size(65, 20);
            this.txtEnd_Z.TabIndex = 10;
            this.txtEnd_Z.Text = "0";
            // 
            // txtStart_Z
            // 
            this.txtStart_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart_Z.Enabled = false;
            this.txtStart_Z.Location = new System.Drawing.Point(421, 31);
            this.txtStart_Z.Name = "txtStart_Z";
            this.txtStart_Z.Size = new System.Drawing.Size(65, 20);
            this.txtStart_Z.TabIndex = 7;
            this.txtStart_Z.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Z";
            // 
            // txt3rdPt_Y
            // 
            this.txt3rdPt_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt3rdPt_Y.Enabled = false;
            this.txt3rdPt_Y.Location = new System.Drawing.Point(352, 92);
            this.txt3rdPt_Y.Name = "txt3rdPt_Y";
            this.txt3rdPt_Y.Size = new System.Drawing.Size(65, 20);
            this.txt3rdPt_Y.TabIndex = 12;
            this.txt3rdPt_Y.Text = "0";
            // 
            // txtEnd_Y
            // 
            this.txtEnd_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd_Y.Enabled = false;
            this.txtEnd_Y.Location = new System.Drawing.Point(352, 62);
            this.txtEnd_Y.Name = "txtEnd_Y";
            this.txtEnd_Y.Size = new System.Drawing.Size(65, 20);
            this.txtEnd_Y.TabIndex = 9;
            this.txtEnd_Y.Text = "0";
            // 
            // txtStart_Y
            // 
            this.txtStart_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart_Y.Enabled = false;
            this.txtStart_Y.Location = new System.Drawing.Point(352, 31);
            this.txtStart_Y.Name = "txtStart_Y";
            this.txtStart_Y.Size = new System.Drawing.Size(65, 20);
            this.txtStart_Y.TabIndex = 6;
            this.txtStart_Y.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Y";
            // 
            // txt3rdPt_X
            // 
            this.txt3rdPt_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt3rdPt_X.Enabled = false;
            this.txt3rdPt_X.Location = new System.Drawing.Point(282, 92);
            this.txt3rdPt_X.Name = "txt3rdPt_X";
            this.txt3rdPt_X.Size = new System.Drawing.Size(65, 20);
            this.txt3rdPt_X.TabIndex = 11;
            this.txt3rdPt_X.Text = "0";
            // 
            // txtEnd_X
            // 
            this.txtEnd_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd_X.Enabled = false;
            this.txtEnd_X.Location = new System.Drawing.Point(282, 62);
            this.txtEnd_X.Name = "txtEnd_X";
            this.txtEnd_X.Size = new System.Drawing.Size(65, 20);
            this.txtEnd_X.TabIndex = 8;
            this.txtEnd_X.Text = "0";
            // 
            // txtStart_X
            // 
            this.txtStart_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart_X.Enabled = false;
            this.txtStart_X.Location = new System.Drawing.Point(282, 31);
            this.txtStart_X.Name = "txtStart_X";
            this.txtStart_X.Size = new System.Drawing.Size(65, 20);
            this.txtStart_X.TabIndex = 5;
            this.txtStart_X.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Center, C";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "End, B";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start, A";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(702, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(538, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 25);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(619, 519);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 25);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(525, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 484);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General overview";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 260);
            this.label11.TabIndex = 0;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "This dialoge box is used to define the tow path \r\nsegments and other tow paramete" +
    "rs that define \r\na single continuous tow.";
            // 
            // DefineTowDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 556);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefineTowDialog";
            this.ShowInTaskbar = false;
            this.Text = "Tow properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPathCurves)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDegree;
        private System.Windows.Forms.RadioButton radRadians;
        private System.Windows.Forms.TextBox txtBiasAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTowWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPathCurves;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddPathCurve;
        private System.Windows.Forms.ComboBox cbxCurveType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt3rdPt_Z;
        private System.Windows.Forms.TextBox txtEnd_Z;
        private System.Windows.Forms.TextBox txtStart_Z;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt3rdPt_Y;
        private System.Windows.Forms.TextBox txtEnd_Y;
        private System.Windows.Forms.TextBox txtStart_Y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt3rdPt_X;
        private System.Windows.Forms.TextBox txtEnd_X;
        private System.Windows.Forms.TextBox txtStart_X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
    }
}