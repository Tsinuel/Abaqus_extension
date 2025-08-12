namespace AbaqusExtension.GUI
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Uniaxial");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Shear XY");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Free", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Uniaxial");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Shear XY");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Antisymmetric", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Uniaxial");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Shear XY");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Uniaxial for GENOA");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Symmetric", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtWorkingFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseMeshFile = new System.Windows.Forms.Button();
            this.ofdMeshFile = new System.Windows.Forms.OpenFileDialog();
            this.gbxInputOutput = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
            this.txtMeshFile = new System.Windows.Forms.TextBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.txtElemGroupingLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxTowDefinition = new System.Windows.Forms.GroupBox();
            this.chkGenerateGENOA = new System.Windows.Forms.CheckBox();
            this.gbxGENOAinput = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudNumbOfAxialTows = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTowMat_Ply = new System.Windows.Forms.RadioButton();
            this.radTowMat_FibrMatx = new System.Windows.Forms.RadioButton();
            this.txtBiasTowTemp = new System.Windows.Forms.TextBox();
            this.txtBiasTowV_fract = new System.Windows.Forms.TextBox();
            this.txtBiasTowF_fract = new System.Windows.Forms.TextBox();
            this.txtBiasTowAng = new System.Windows.Forms.TextBox();
            this.txtBiasTowThick = new System.Windows.Forms.TextBox();
            this.txtAxlTowTemp = new System.Windows.Forms.TextBox();
            this.txtMatxTemp = new System.Windows.Forms.TextBox();
            this.txtAxlTowV_fract = new System.Windows.Forms.TextBox();
            this.txtMatxV_fract = new System.Windows.Forms.TextBox();
            this.txtAxlTowF_fract = new System.Windows.Forms.TextBox();
            this.txtMatxF_fract = new System.Windows.Forms.TextBox();
            this.txtAxlTowAng = new System.Windows.Forms.TextBox();
            this.txtMatxAng = new System.Windows.Forms.TextBox();
            this.txtAxlTowThick = new System.Windows.Forms.TextBox();
            this.txtMatxThick = new System.Windows.Forms.TextBox();
            this.nudBiasTowFailCrit = new System.Windows.Forms.NumericUpDown();
            this.nudBiasTowMatxID = new System.Windows.Forms.NumericUpDown();
            this.nudBiasTowFibrID = new System.Windows.Forms.NumericUpDown();
            this.nudAxlTowFailCrit = new System.Windows.Forms.NumericUpDown();
            this.nudAxlTowMatxID = new System.Windows.Forms.NumericUpDown();
            this.nudMatxFailCrit = new System.Windows.Forms.NumericUpDown();
            this.nudMatxMatxID = new System.Windows.Forms.NumericUpDown();
            this.nudAxlTowFibrID = new System.Windows.Forms.NumericUpDown();
            this.nudMatxFibID = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTowDefinition = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvClmMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmTowProperties = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRun = new System.Windows.Forms.Button();
            this.fbwOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnShowData = new System.Windows.Forms.Button();
            this.pgbrMainPrgrsBr = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.bgwFileReader = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxProgress = new System.Windows.Forms.GroupBox();
            this.bgwExecuter = new System.ComponentModel.BackgroundWorker();
            this.lblNodes = new System.Windows.Forms.Label();
            this.lblElements = new System.Windows.Forms.Label();
            this.lblMaterials = new System.Windows.Forms.Label();
            this.btnSaveInput = new System.Windows.Forms.Button();
            this.btnImportInput = new System.Windows.Forms.Button();
            this.ofdInput = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbxUnitCellDefinition = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartCoordinate_X = new System.Windows.Forms.TextBox();
            this.txtVector_X = new System.Windows.Forms.TextBox();
            this.txtStartCoordinate_Y = new System.Windows.Forms.TextBox();
            this.txtTolerance_X = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartCoordinate_Z = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVector_Y = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTolerance_Y = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVector_Z = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTolerance_Z = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxPBC_options = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chkWriteLogFiles = new System.Windows.Forms.CheckBox();
            this.chkWriteRefinedMesh = new System.Windows.Forms.CheckBox();
            this.rbtManualPBC = new System.Windows.Forms.RadioButton();
            this.rbtAutomaticPBC = new System.Windows.Forms.RadioButton();
            this.gbxAutomaticPBC = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.chkAutoPBC_symmUA = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.chkAutoPBC_asymUA = new System.Windows.Forms.CheckBox();
            this.chkAutoPBC_symmForGENOA = new System.Windows.Forms.CheckBox();
            this.chkAutoPBC_symmShXY = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.chkAutoPBC_asymShXY = new System.Windows.Forms.CheckBox();
            this.chkAutoPBC_freeUA = new System.Windows.Forms.CheckBox();
            this.chkAutoPBC_freeShXY = new System.Windows.Forms.CheckBox();
            this.gbxManualPBC = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxAll = new System.Windows.Forms.CheckBox();
            this.chkManualMasterNode = new System.Windows.Forms.CheckBox();
            this.gbxManualMasterNodes = new System.Windows.Forms.GroupBox();
            this.nudMasterNodeX_src = new System.Windows.Forms.NumericUpDown();
            this.nudMasterNodeY_src = new System.Windows.Forms.NumericUpDown();
            this.nudMasterNodeZ_trgt = new System.Windows.Forms.NumericUpDown();
            this.nudMasterNodeX_trgt = new System.Windows.Forms.NumericUpDown();
            this.nudMasterNodeZ_src = new System.Windows.Forms.NumericUpDown();
            this.nudMasterNodeY_trgt = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxZZ = new System.Windows.Forms.CheckBox();
            this.cbxYZ = new System.Windows.Forms.CheckBox();
            this.gbxXX = new System.Windows.Forms.GroupBox();
            this.rbtXX_2 = new System.Windows.Forms.RadioButton();
            this.rbtXX_1 = new System.Windows.Forms.RadioButton();
            this.cbxXZ = new System.Windows.Forms.CheckBox();
            this.gbxXY = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rbtXY_1 = new System.Windows.Forms.RadioButton();
            this.label30 = new System.Windows.Forms.Label();
            this.cbxZY = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.gbxYX = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbtYX_1 = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.cbxYY = new System.Windows.Forms.CheckBox();
            this.gbxXZ = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.rbtXZ_1 = new System.Windows.Forms.RadioButton();
            this.cbxXY = new System.Windows.Forms.CheckBox();
            this.gbxZX = new System.Windows.Forms.GroupBox();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.rbtZX_1 = new System.Windows.Forms.RadioButton();
            this.cbxZX = new System.Windows.Forms.CheckBox();
            this.gbxYY = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbtYY_1 = new System.Windows.Forms.RadioButton();
            this.gbxZZ = new System.Windows.Forms.GroupBox();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.rbtZZ_1 = new System.Windows.Forms.RadioButton();
            this.cbxXX = new System.Windows.Forms.CheckBox();
            this.cbxYX = new System.Windows.Forms.CheckBox();
            this.gbxZY = new System.Windows.Forms.GroupBox();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.rbtZY_1 = new System.Windows.Forms.RadioButton();
            this.gbxYZ = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.rbtYZ_1 = new System.Windows.Forms.RadioButton();
            this.btnRefineNodes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxInputOutput.SuspendLayout();
            this.gbxTowDefinition.SuspendLayout();
            this.gbxGENOAinput.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbOfAxialTows)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiasTowFailCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiasTowMatxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiasTowFibrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAxlTowFailCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAxlTowMatxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatxFailCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatxMatxID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAxlTowFibrID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatxFibID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTowDefinition)).BeginInit();
            this.gbxProgress.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbxUnitCellDefinition.SuspendLayout();
            this.gbxPBC_options.SuspendLayout();
            this.gbxAutomaticPBC.SuspendLayout();
            this.gbxManualPBC.SuspendLayout();
            this.gbxManualMasterNodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeX_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeY_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeZ_trgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeX_trgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeZ_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeY_trgt)).BeginInit();
            this.gbxXX.SuspendLayout();
            this.gbxXY.SuspendLayout();
            this.gbxYX.SuspendLayout();
            this.gbxXZ.SuspendLayout();
            this.gbxZX.SuspendLayout();
            this.gbxYY.SuspendLayout();
            this.gbxZZ.SuspendLayout();
            this.gbxZY.SuspendLayout();
            this.gbxYZ.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadFile.Location = new System.Drawing.Point(420, 20);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(81, 25);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtWorkingFolder
            // 
            this.txtWorkingFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingFolder.Location = new System.Drawing.Point(93, 51);
            this.txtWorkingFolder.Name = "txtWorkingFolder";
            this.txtWorkingFolder.Size = new System.Drawing.Size(291, 20);
            this.txtWorkingFolder.TabIndex = 1;
            this.txtWorkingFolder.Text = "C:\\Temp";
            this.txtWorkingFolder.TextChanged += new System.EventHandler(this.txtWorkingFolder_TextChanged);
            // 
            // btnBrowseMeshFile
            // 
            this.btnBrowseMeshFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMeshFile.Location = new System.Drawing.Point(388, 20);
            this.btnBrowseMeshFile.Name = "btnBrowseMeshFile";
            this.btnBrowseMeshFile.Size = new System.Drawing.Size(27, 25);
            this.btnBrowseMeshFile.TabIndex = 2;
            this.btnBrowseMeshFile.Text = "...";
            this.btnBrowseMeshFile.UseVisualStyleBackColor = true;
            this.btnBrowseMeshFile.Click += new System.EventHandler(this.btnBrowseMeshFile_Click);
            // 
            // ofdMeshFile
            // 
            this.ofdMeshFile.DefaultExt = "inp";
            this.ofdMeshFile.Filter = "Abaqus mesh input files|*.inp|All files|*.*\"";
            // 
            // gbxInputOutput
            // 
            this.gbxInputOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInputOutput.Controls.Add(this.label3);
            this.gbxInputOutput.Controls.Add(this.label2);
            this.gbxInputOutput.Controls.Add(this.label1);
            this.gbxInputOutput.Controls.Add(this.btnBrowseOutputFolder);
            this.gbxInputOutput.Controls.Add(this.btnBrowseMeshFile);
            this.gbxInputOutput.Controls.Add(this.btnReadFile);
            this.gbxInputOutput.Controls.Add(this.txtMeshFile);
            this.gbxInputOutput.Controls.Add(this.txtModelName);
            this.gbxInputOutput.Controls.Add(this.txtWorkingFolder);
            this.gbxInputOutput.Location = new System.Drawing.Point(10, 13);
            this.gbxInputOutput.Name = "gbxInputOutput";
            this.gbxInputOutput.Size = new System.Drawing.Size(505, 115);
            this.gbxInputOutput.TabIndex = 9;
            this.gbxInputOutput.TabStop = false;
            this.gbxInputOutput.Text = "Input and output files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Working Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesh File (.inp)";
            // 
            // btnBrowseOutputFolder
            // 
            this.btnBrowseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutputFolder.Location = new System.Drawing.Point(388, 49);
            this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            this.btnBrowseOutputFolder.Size = new System.Drawing.Size(27, 25);
            this.btnBrowseOutputFolder.TabIndex = 2;
            this.btnBrowseOutputFolder.Text = "...";
            this.btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
            // 
            // txtMeshFile
            // 
            this.txtMeshFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeshFile.Location = new System.Drawing.Point(93, 22);
            this.txtMeshFile.Name = "txtMeshFile";
            this.txtMeshFile.Size = new System.Drawing.Size(291, 20);
            this.txtMeshFile.TabIndex = 1;
            // 
            // txtModelName
            // 
            this.txtModelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelName.Location = new System.Drawing.Point(93, 80);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(291, 20);
            this.txtModelName.TabIndex = 1;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtModelName_TextChanged);
            // 
            // txtElemGroupingLength
            // 
            this.txtElemGroupingLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElemGroupingLength.Location = new System.Drawing.Point(525, 22);
            this.txtElemGroupingLength.Name = "txtElemGroupingLength";
            this.txtElemGroupingLength.Size = new System.Drawing.Size(103, 20);
            this.txtElemGroupingLength.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Orientation Density";
            // 
            // gbxTowDefinition
            // 
            this.gbxTowDefinition.Controls.Add(this.chkGenerateGENOA);
            this.gbxTowDefinition.Controls.Add(this.gbxGENOAinput);
            this.gbxTowDefinition.Controls.Add(this.dgvTowDefinition);
            this.gbxTowDefinition.Enabled = false;
            this.gbxTowDefinition.Location = new System.Drawing.Point(3, 6);
            this.gbxTowDefinition.Name = "gbxTowDefinition";
            this.gbxTowDefinition.Size = new System.Drawing.Size(514, 531);
            this.gbxTowDefinition.TabIndex = 11;
            this.gbxTowDefinition.TabStop = false;
            this.gbxTowDefinition.Text = "Tow definition";
            // 
            // chkGenerateGENOA
            // 
            this.chkGenerateGENOA.AutoSize = true;
            this.chkGenerateGENOA.Location = new System.Drawing.Point(6, 251);
            this.chkGenerateGENOA.Name = "chkGenerateGENOA";
            this.chkGenerateGENOA.Size = new System.Drawing.Size(249, 17);
            this.chkGenerateGENOA.TabIndex = 2;
            this.chkGenerateGENOA.Text = "Generate GENOA laminate definition file as well";
            this.chkGenerateGENOA.UseVisualStyleBackColor = true;
            this.chkGenerateGENOA.CheckedChanged += new System.EventHandler(this.chkGenerateGENOA_CheckedChanged);
            // 
            // gbxGENOAinput
            // 
            this.gbxGENOAinput.Controls.Add(this.groupBox3);
            this.gbxGENOAinput.Controls.Add(this.groupBox2);
            this.gbxGENOAinput.Controls.Add(this.txtBiasTowTemp);
            this.gbxGENOAinput.Controls.Add(this.txtBiasTowV_fract);
            this.gbxGENOAinput.Controls.Add(this.txtBiasTowF_fract);
            this.gbxGENOAinput.Controls.Add(this.txtBiasTowAng);
            this.gbxGENOAinput.Controls.Add(this.txtBiasTowThick);
            this.gbxGENOAinput.Controls.Add(this.txtAxlTowTemp);
            this.gbxGENOAinput.Controls.Add(this.txtMatxTemp);
            this.gbxGENOAinput.Controls.Add(this.txtAxlTowV_fract);
            this.gbxGENOAinput.Controls.Add(this.txtMatxV_fract);
            this.gbxGENOAinput.Controls.Add(this.txtAxlTowF_fract);
            this.gbxGENOAinput.Controls.Add(this.txtMatxF_fract);
            this.gbxGENOAinput.Controls.Add(this.txtAxlTowAng);
            this.gbxGENOAinput.Controls.Add(this.txtMatxAng);
            this.gbxGENOAinput.Controls.Add(this.txtAxlTowThick);
            this.gbxGENOAinput.Controls.Add(this.txtMatxThick);
            this.gbxGENOAinput.Controls.Add(this.nudBiasTowFailCrit);
            this.gbxGENOAinput.Controls.Add(this.nudBiasTowMatxID);
            this.gbxGENOAinput.Controls.Add(this.nudBiasTowFibrID);
            this.gbxGENOAinput.Controls.Add(this.nudAxlTowFailCrit);
            this.gbxGENOAinput.Controls.Add(this.nudAxlTowMatxID);
            this.gbxGENOAinput.Controls.Add(this.nudMatxFailCrit);
            this.gbxGENOAinput.Controls.Add(this.nudMatxMatxID);
            this.gbxGENOAinput.Controls.Add(this.nudAxlTowFibrID);
            this.gbxGENOAinput.Controls.Add(this.nudMatxFibID);
            this.gbxGENOAinput.Controls.Add(this.label18);
            this.gbxGENOAinput.Controls.Add(this.label17);
            this.gbxGENOAinput.Controls.Add(this.label16);
            this.gbxGENOAinput.Controls.Add(this.label25);
            this.gbxGENOAinput.Controls.Add(this.label24);
            this.gbxGENOAinput.Controls.Add(this.label23);
            this.gbxGENOAinput.Controls.Add(this.label22);
            this.gbxGENOAinput.Controls.Add(this.label21);
            this.gbxGENOAinput.Controls.Add(this.label20);
            this.gbxGENOAinput.Controls.Add(this.label19);
            this.gbxGENOAinput.Controls.Add(this.label15);
            this.gbxGENOAinput.Enabled = false;
            this.gbxGENOAinput.Location = new System.Drawing.Point(6, 274);
            this.gbxGENOAinput.Name = "gbxGENOAinput";
            this.gbxGENOAinput.Size = new System.Drawing.Size(495, 251);
            this.gbxGENOAinput.TabIndex = 1;
            this.gbxGENOAinput.TabStop = false;
            this.gbxGENOAinput.Text = "GENOA laminate definition";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudNumbOfAxialTows);
            this.groupBox3.Location = new System.Drawing.Point(329, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number of Axial Tows";
            // 
            // nudNumbOfAxialTows
            // 
            this.nudNumbOfAxialTows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumbOfAxialTows.Location = new System.Drawing.Point(6, 19);
            this.nudNumbOfAxialTows.Name = "nudNumbOfAxialTows";
            this.nudNumbOfAxialTows.Size = new System.Drawing.Size(119, 20);
            this.nudNumbOfAxialTows.TabIndex = 2;
            this.nudNumbOfAxialTows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTowMat_Ply);
            this.groupBox2.Controls.Add(this.radTowMat_FibrMatx);
            this.groupBox2.Location = new System.Drawing.Point(329, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tow Material Type";
            // 
            // radTowMat_Ply
            // 
            this.radTowMat_Ply.AutoSize = true;
            this.radTowMat_Ply.Location = new System.Drawing.Point(6, 42);
            this.radTowMat_Ply.Name = "radTowMat_Ply";
            this.radTowMat_Ply.Size = new System.Drawing.Size(39, 17);
            this.radTowMat_Ply.TabIndex = 0;
            this.radTowMat_Ply.Text = "Ply";
            this.toolTip1.SetToolTip(this.radTowMat_Ply, "By default, the material assumed are five in the ff order\r\n1 = Fiber (constituent" +
        ")\r\n2 = Matrix (constituent)\r\n3 = AxialTow (as ply)\r\n4 = BiasTow (as ply)\r\n5 = Ma" +
        "trix (as ply)\r\n");
            this.radTowMat_Ply.UseVisualStyleBackColor = true;
            this.radTowMat_Ply.CheckedChanged += new System.EventHandler(this.radTowMat_Ply_CheckedChanged);
            // 
            // radTowMat_FibrMatx
            // 
            this.radTowMat_FibrMatx.AutoSize = true;
            this.radTowMat_FibrMatx.Checked = true;
            this.radTowMat_FibrMatx.Location = new System.Drawing.Point(6, 19);
            this.radTowMat_FibrMatx.Name = "radTowMat_FibrMatx";
            this.radTowMat_FibrMatx.Size = new System.Drawing.Size(81, 17);
            this.radTowMat_FibrMatx.TabIndex = 0;
            this.radTowMat_FibrMatx.TabStop = true;
            this.radTowMat_FibrMatx.Text = "Fiber/Matrix";
            this.toolTip1.SetToolTip(this.radTowMat_FibrMatx, "By default, the material assumed are five in the ff order\r\n1 = Fiber (constituent" +
        ")\r\n2 = Matrix (constituent)\r\n3 = AxialTow (as ply)\r\n4 = BiasTow (as ply)\r\n5 = Ma" +
        "trix (as ply)\r\n");
            this.radTowMat_FibrMatx.UseVisualStyleBackColor = true;
            this.radTowMat_FibrMatx.CheckedChanged += new System.EventHandler(this.radTowMat_FibrMatx_CheckedChanged);
            // 
            // txtBiasTowTemp
            // 
            this.txtBiasTowTemp.Location = new System.Drawing.Point(247, 222);
            this.txtBiasTowTemp.Name = "txtBiasTowTemp";
            this.txtBiasTowTemp.Size = new System.Drawing.Size(76, 20);
            this.txtBiasTowTemp.TabIndex = 2;
            this.txtBiasTowTemp.Text = "2.1E+01";
            // 
            // txtBiasTowV_fract
            // 
            this.txtBiasTowV_fract.Location = new System.Drawing.Point(247, 170);
            this.txtBiasTowV_fract.Name = "txtBiasTowV_fract";
            this.txtBiasTowV_fract.Size = new System.Drawing.Size(76, 20);
            this.txtBiasTowV_fract.TabIndex = 2;
            this.txtBiasTowV_fract.Text = "0";
            // 
            // txtBiasTowF_fract
            // 
            this.txtBiasTowF_fract.Location = new System.Drawing.Point(247, 144);
            this.txtBiasTowF_fract.Name = "txtBiasTowF_fract";
            this.txtBiasTowF_fract.Size = new System.Drawing.Size(76, 20);
            this.txtBiasTowF_fract.TabIndex = 2;
            this.txtBiasTowF_fract.Text = "7.8E-01";
            // 
            // txtBiasTowAng
            // 
            this.txtBiasTowAng.Location = new System.Drawing.Point(247, 118);
            this.txtBiasTowAng.Name = "txtBiasTowAng";
            this.txtBiasTowAng.Size = new System.Drawing.Size(76, 20);
            this.txtBiasTowAng.TabIndex = 2;
            this.txtBiasTowAng.Text = "0";
            // 
            // txtBiasTowThick
            // 
            this.txtBiasTowThick.Location = new System.Drawing.Point(247, 92);
            this.txtBiasTowThick.Name = "txtBiasTowThick";
            this.txtBiasTowThick.Size = new System.Drawing.Size(76, 20);
            this.txtBiasTowThick.TabIndex = 2;
            this.txtBiasTowThick.Text = "1.0E-01";
            // 
            // txtAxlTowTemp
            // 
            this.txtAxlTowTemp.Location = new System.Drawing.Point(165, 222);
            this.txtAxlTowTemp.Name = "txtAxlTowTemp";
            this.txtAxlTowTemp.Size = new System.Drawing.Size(76, 20);
            this.txtAxlTowTemp.TabIndex = 2;
            this.txtAxlTowTemp.Text = "2.1E+01";
            // 
            // txtMatxTemp
            // 
            this.txtMatxTemp.Location = new System.Drawing.Point(83, 222);
            this.txtMatxTemp.Name = "txtMatxTemp";
            this.txtMatxTemp.Size = new System.Drawing.Size(76, 20);
            this.txtMatxTemp.TabIndex = 2;
            this.txtMatxTemp.Text = "2.1E+01";
            // 
            // txtAxlTowV_fract
            // 
            this.txtAxlTowV_fract.Location = new System.Drawing.Point(165, 170);
            this.txtAxlTowV_fract.Name = "txtAxlTowV_fract";
            this.txtAxlTowV_fract.Size = new System.Drawing.Size(76, 20);
            this.txtAxlTowV_fract.TabIndex = 2;
            this.txtAxlTowV_fract.Text = "0";
            // 
            // txtMatxV_fract
            // 
            this.txtMatxV_fract.Location = new System.Drawing.Point(83, 170);
            this.txtMatxV_fract.Name = "txtMatxV_fract";
            this.txtMatxV_fract.Size = new System.Drawing.Size(76, 20);
            this.txtMatxV_fract.TabIndex = 2;
            this.txtMatxV_fract.Text = "0";
            // 
            // txtAxlTowF_fract
            // 
            this.txtAxlTowF_fract.Location = new System.Drawing.Point(165, 144);
            this.txtAxlTowF_fract.Name = "txtAxlTowF_fract";
            this.txtAxlTowF_fract.Size = new System.Drawing.Size(76, 20);
            this.txtAxlTowF_fract.TabIndex = 2;
            this.txtAxlTowF_fract.Text = "7.8E-01";
            // 
            // txtMatxF_fract
            // 
            this.txtMatxF_fract.Enabled = false;
            this.txtMatxF_fract.Location = new System.Drawing.Point(83, 144);
            this.txtMatxF_fract.Name = "txtMatxF_fract";
            this.txtMatxF_fract.Size = new System.Drawing.Size(76, 20);
            this.txtMatxF_fract.TabIndex = 2;
            this.txtMatxF_fract.Text = "0";
            // 
            // txtAxlTowAng
            // 
            this.txtAxlTowAng.Location = new System.Drawing.Point(165, 118);
            this.txtAxlTowAng.Name = "txtAxlTowAng";
            this.txtAxlTowAng.Size = new System.Drawing.Size(76, 20);
            this.txtAxlTowAng.TabIndex = 2;
            this.txtAxlTowAng.Text = "0";
            // 
            // txtMatxAng
            // 
            this.txtMatxAng.Enabled = false;
            this.txtMatxAng.Location = new System.Drawing.Point(83, 118);
            this.txtMatxAng.Name = "txtMatxAng";
            this.txtMatxAng.Size = new System.Drawing.Size(76, 20);
            this.txtMatxAng.TabIndex = 2;
            this.txtMatxAng.Text = "0";
            // 
            // txtAxlTowThick
            // 
            this.txtAxlTowThick.Location = new System.Drawing.Point(165, 92);
            this.txtAxlTowThick.Name = "txtAxlTowThick";
            this.txtAxlTowThick.Size = new System.Drawing.Size(76, 20);
            this.txtAxlTowThick.TabIndex = 2;
            this.txtAxlTowThick.Text = "1.0E-01";
            // 
            // txtMatxThick
            // 
            this.txtMatxThick.Location = new System.Drawing.Point(83, 92);
            this.txtMatxThick.Name = "txtMatxThick";
            this.txtMatxThick.Size = new System.Drawing.Size(76, 20);
            this.txtMatxThick.TabIndex = 2;
            this.txtMatxThick.Text = "1.0E-01";
            // 
            // nudBiasTowFailCrit
            // 
            this.nudBiasTowFailCrit.Location = new System.Drawing.Point(247, 196);
            this.nudBiasTowFailCrit.Name = "nudBiasTowFailCrit";
            this.nudBiasTowFailCrit.Size = new System.Drawing.Size(76, 20);
            this.nudBiasTowFailCrit.TabIndex = 1;
            this.nudBiasTowFailCrit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBiasTowMatxID
            // 
            this.nudBiasTowMatxID.Location = new System.Drawing.Point(247, 66);
            this.nudBiasTowMatxID.Name = "nudBiasTowMatxID";
            this.nudBiasTowMatxID.Size = new System.Drawing.Size(76, 20);
            this.nudBiasTowMatxID.TabIndex = 1;
            this.nudBiasTowMatxID.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudBiasTowFibrID
            // 
            this.nudBiasTowFibrID.Location = new System.Drawing.Point(247, 40);
            this.nudBiasTowFibrID.Name = "nudBiasTowFibrID";
            this.nudBiasTowFibrID.Size = new System.Drawing.Size(76, 20);
            this.nudBiasTowFibrID.TabIndex = 1;
            this.nudBiasTowFibrID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAxlTowFailCrit
            // 
            this.nudAxlTowFailCrit.Location = new System.Drawing.Point(165, 196);
            this.nudAxlTowFailCrit.Name = "nudAxlTowFailCrit";
            this.nudAxlTowFailCrit.Size = new System.Drawing.Size(76, 20);
            this.nudAxlTowFailCrit.TabIndex = 1;
            this.nudAxlTowFailCrit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAxlTowMatxID
            // 
            this.nudAxlTowMatxID.Location = new System.Drawing.Point(165, 66);
            this.nudAxlTowMatxID.Name = "nudAxlTowMatxID";
            this.nudAxlTowMatxID.Size = new System.Drawing.Size(76, 20);
            this.nudAxlTowMatxID.TabIndex = 1;
            this.nudAxlTowMatxID.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudMatxFailCrit
            // 
            this.nudMatxFailCrit.Location = new System.Drawing.Point(83, 196);
            this.nudMatxFailCrit.Name = "nudMatxFailCrit";
            this.nudMatxFailCrit.Size = new System.Drawing.Size(76, 20);
            this.nudMatxFailCrit.TabIndex = 1;
            this.nudMatxFailCrit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMatxMatxID
            // 
            this.nudMatxMatxID.Location = new System.Drawing.Point(83, 66);
            this.nudMatxMatxID.Name = "nudMatxMatxID";
            this.nudMatxMatxID.Size = new System.Drawing.Size(76, 20);
            this.nudMatxMatxID.TabIndex = 1;
            this.nudMatxMatxID.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudAxlTowFibrID
            // 
            this.nudAxlTowFibrID.Location = new System.Drawing.Point(165, 40);
            this.nudAxlTowFibrID.Name = "nudAxlTowFibrID";
            this.nudAxlTowFibrID.Size = new System.Drawing.Size(76, 20);
            this.nudAxlTowFibrID.TabIndex = 1;
            this.nudAxlTowFibrID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMatxFibID
            // 
            this.nudMatxFibID.Enabled = false;
            this.nudMatxFibID.Location = new System.Drawing.Point(83, 40);
            this.nudMatxFibID.Name = "nudMatxFibID";
            this.nudMatxFibID.Size = new System.Drawing.Size(76, 20);
            this.nudMatxFibID.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Bias Tow";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(175, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Axial Tow";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Matrix";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 225);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Temp";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 198);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Failure Criteria";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(52, 173);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "VV";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(53, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "VF";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Angle";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Thickness";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "MID:SID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "FID:SID";
            // 
            // dgvTowDefinition
            // 
            this.dgvTowDefinition.AllowUserToResizeRows = false;
            this.dgvTowDefinition.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTowDefinition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTowDefinition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.dtvClmMaterial,
            this.clmTowProperties});
            this.dgvTowDefinition.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTowDefinition.Location = new System.Drawing.Point(3, 16);
            this.dgvTowDefinition.Name = "dgvTowDefinition";
            this.dgvTowDefinition.RowTemplate.Height = 23;
            this.dgvTowDefinition.Size = new System.Drawing.Size(498, 216);
            this.dgvTowDefinition.TabIndex = 0;
            this.dgvTowDefinition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvTows_CellContentClick);
            this.dgvTowDefinition.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTowDefinition_CellLeave);
            this.dgvTowDefinition.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTowDefinition_CellValueChanged);
            this.dgvTowDefinition.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtvTows_RowsAdded);
            this.dgvTowDefinition.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtvTows_RowsRemoved);
            this.dgvTowDefinition.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvTowDefinition_UserAddedRow);
            this.dgvTowDefinition.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTowDefinition_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Elem_No_start";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Elem_No_end";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtvClmMaterial
            // 
            this.dtvClmMaterial.HeaderText = "Material";
            this.dtvClmMaterial.Name = "dtvClmMaterial";
            this.dtvClmMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmTowProperties
            // 
            this.clmTowProperties.HeaderText = "Properties";
            this.clmTowProperties.Name = "clmTowProperties";
            this.clmTowProperties.Text = "...";
            this.clmTowProperties.UseColumnTextForButtonValue = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(524, 479);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 52);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // fbwOutputFolder
            // 
            this.fbwOutputFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnShowData
            // 
            this.btnShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowData.Enabled = false;
            this.btnShowData.Location = new System.Drawing.Point(6, 84);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(118, 25);
            this.btnShowData.TabIndex = 0;
            this.btnShowData.Text = "Show data...";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // pgbrMainPrgrsBr
            // 
            this.pgbrMainPrgrsBr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbrMainPrgrsBr.Location = new System.Drawing.Point(104, 27);
            this.pgbrMainPrgrsBr.MarqueeAnimationSpeed = 10;
            this.pgbrMainPrgrsBr.Name = "pgbrMainPrgrsBr";
            this.pgbrMainPrgrsBr.Size = new System.Drawing.Size(449, 13);
            this.pgbrMainPrgrsBr.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgbrMainPrgrsBr.TabIndex = 12;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(21, 27);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(78, 13);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "Reading File ...";
            // 
            // bgwFileReader
            // 
            this.bgwFileReader.WorkerSupportsCancellation = true;
            this.bgwFileReader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFileRead_DoWork);
            this.bgwFileReader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFileRead_RunWorkerCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(557, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel...";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxProgress
            // 
            this.gbxProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProgress.Controls.Add(this.btnCancel);
            this.gbxProgress.Controls.Add(this.lblProgress);
            this.gbxProgress.Controls.Add(this.pgbrMainPrgrsBr);
            this.gbxProgress.Location = new System.Drawing.Point(13, 709);
            this.gbxProgress.Name = "gbxProgress";
            this.gbxProgress.Size = new System.Drawing.Size(636, 59);
            this.gbxProgress.TabIndex = 15;
            this.gbxProgress.TabStop = false;
            this.gbxProgress.Visible = false;
            // 
            // bgwExecuter
            // 
            this.bgwExecuter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExecuter_DoWork);
            this.bgwExecuter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExecuter_RunWorkerCompleted);
            // 
            // lblNodes
            // 
            this.lblNodes.AutoSize = true;
            this.lblNodes.Location = new System.Drawing.Point(7, 20);
            this.lblNodes.Name = "lblNodes";
            this.lblNodes.Size = new System.Drawing.Size(47, 13);
            this.lblNodes.TabIndex = 13;
            this.lblNodes.Text = "Nodes =";
            // 
            // lblElements
            // 
            this.lblElements.AutoSize = true;
            this.lblElements.Location = new System.Drawing.Point(6, 42);
            this.lblElements.Name = "lblElements";
            this.lblElements.Size = new System.Drawing.Size(59, 13);
            this.lblElements.TabIndex = 13;
            this.lblElements.Text = "Elements =";
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Location = new System.Drawing.Point(7, 64);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(58, 13);
            this.lblMaterials.TabIndex = 13;
            this.lblMaterials.Text = "Materials =";
            // 
            // btnSaveInput
            // 
            this.btnSaveInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveInput.Enabled = false;
            this.btnSaveInput.Location = new System.Drawing.Point(524, 447);
            this.btnSaveInput.Name = "btnSaveInput";
            this.btnSaveInput.Size = new System.Drawing.Size(103, 25);
            this.btnSaveInput.TabIndex = 0;
            this.btnSaveInput.Text = "Save Input";
            this.btnSaveInput.UseVisualStyleBackColor = true;
            this.btnSaveInput.Click += new System.EventHandler(this.btnSaveInput_Click);
            // 
            // btnImportInput
            // 
            this.btnImportInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportInput.Enabled = false;
            this.btnImportInput.Location = new System.Drawing.Point(524, 415);
            this.btnImportInput.Name = "btnImportInput";
            this.btnImportInput.Size = new System.Drawing.Size(103, 25);
            this.btnImportInput.TabIndex = 0;
            this.btnImportInput.Text = "Import Input...";
            this.btnImportInput.UseVisualStyleBackColor = true;
            this.btnImportInput.Click += new System.EventHandler(this.btnImportInput_Click);
            // 
            // ofdInput
            // 
            this.ofdInput.DefaultExt = "txt";
            this.ofdInput.Filter = "\"Input text file|*.txt|All files|*.*\"";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 134);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 569);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtElemGroupingLength);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.gbxTowDefinition);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Controls.Add(this.btnImportInput);
            this.tabPage1.Controls.Add(this.btnSaveInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orientation";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.gbxUnitCellDefinition);
            this.tabPage3.Controls.Add(this.gbxPBC_options);
            this.tabPage3.Controls.Add(this.btnRefineNodes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(633, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PBC";
            // 
            // gbxUnitCellDefinition
            // 
            this.gbxUnitCellDefinition.Controls.Add(this.label5);
            this.gbxUnitCellDefinition.Controls.Add(this.txtStartCoordinate_X);
            this.gbxUnitCellDefinition.Controls.Add(this.txtVector_X);
            this.gbxUnitCellDefinition.Controls.Add(this.txtStartCoordinate_Y);
            this.gbxUnitCellDefinition.Controls.Add(this.txtTolerance_X);
            this.gbxUnitCellDefinition.Controls.Add(this.label8);
            this.gbxUnitCellDefinition.Controls.Add(this.txtStartCoordinate_Z);
            this.gbxUnitCellDefinition.Controls.Add(this.label7);
            this.gbxUnitCellDefinition.Controls.Add(this.txtVector_Y);
            this.gbxUnitCellDefinition.Controls.Add(this.label14);
            this.gbxUnitCellDefinition.Controls.Add(this.txtTolerance_Y);
            this.gbxUnitCellDefinition.Controls.Add(this.label13);
            this.gbxUnitCellDefinition.Controls.Add(this.txtVector_Z);
            this.gbxUnitCellDefinition.Controls.Add(this.label12);
            this.gbxUnitCellDefinition.Controls.Add(this.txtTolerance_Z);
            this.gbxUnitCellDefinition.Controls.Add(this.label6);
            this.gbxUnitCellDefinition.Location = new System.Drawing.Point(6, 6);
            this.gbxUnitCellDefinition.Name = "gbxUnitCellDefinition";
            this.gbxUnitCellDefinition.Size = new System.Drawing.Size(615, 114);
            this.gbxUnitCellDefinition.TabIndex = 14;
            this.gbxUnitCellDefinition.TabStop = false;
            this.gbxUnitCellDefinition.Text = "RUC definition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Direction";
            // 
            // txtStartCoordinate_X
            // 
            this.txtStartCoordinate_X.Location = new System.Drawing.Point(152, 36);
            this.txtStartCoordinate_X.Name = "txtStartCoordinate_X";
            this.txtStartCoordinate_X.Size = new System.Drawing.Size(141, 20);
            this.txtStartCoordinate_X.TabIndex = 1;
            // 
            // txtVector_X
            // 
            this.txtVector_X.Location = new System.Drawing.Point(152, 62);
            this.txtVector_X.Name = "txtVector_X";
            this.txtVector_X.Size = new System.Drawing.Size(141, 20);
            this.txtVector_X.TabIndex = 1;
            // 
            // txtStartCoordinate_Y
            // 
            this.txtStartCoordinate_Y.Location = new System.Drawing.Point(301, 36);
            this.txtStartCoordinate_Y.Name = "txtStartCoordinate_Y";
            this.txtStartCoordinate_Y.Size = new System.Drawing.Size(141, 20);
            this.txtStartCoordinate_Y.TabIndex = 1;
            // 
            // txtTolerance_X
            // 
            this.txtTolerance_X.Location = new System.Drawing.Point(152, 88);
            this.txtTolerance_X.Name = "txtTolerance_X";
            this.txtTolerance_X.Size = new System.Drawing.Size(141, 20);
            this.txtTolerance_X.TabIndex = 1;
            this.txtTolerance_X.Text = "0.001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tolerance";
            // 
            // txtStartCoordinate_Z
            // 
            this.txtStartCoordinate_Z.Location = new System.Drawing.Point(453, 36);
            this.txtStartCoordinate_Z.Name = "txtStartCoordinate_Z";
            this.txtStartCoordinate_Z.Size = new System.Drawing.Size(141, 20);
            this.txtStartCoordinate_Z.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Vector";
            // 
            // txtVector_Y
            // 
            this.txtVector_Y.Location = new System.Drawing.Point(301, 62);
            this.txtVector_Y.Name = "txtVector_Y";
            this.txtVector_Y.Size = new System.Drawing.Size(141, 20);
            this.txtVector_Y.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(497, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Z - direction";
            // 
            // txtTolerance_Y
            // 
            this.txtTolerance_Y.Location = new System.Drawing.Point(301, 88);
            this.txtTolerance_Y.Name = "txtTolerance_Y";
            this.txtTolerance_Y.Size = new System.Drawing.Size(141, 20);
            this.txtTolerance_Y.TabIndex = 1;
            this.txtTolerance_Y.Text = "0.001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Y - direction";
            // 
            // txtVector_Z
            // 
            this.txtVector_Z.Location = new System.Drawing.Point(453, 62);
            this.txtVector_Z.Name = "txtVector_Z";
            this.txtVector_Z.Size = new System.Drawing.Size(141, 20);
            this.txtVector_Z.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "X - direction";
            // 
            // txtTolerance_Z
            // 
            this.txtTolerance_Z.Location = new System.Drawing.Point(453, 88);
            this.txtTolerance_Z.Name = "txtTolerance_Z";
            this.txtTolerance_Z.Size = new System.Drawing.Size(141, 20);
            this.txtTolerance_Z.TabIndex = 1;
            this.txtTolerance_Z.Text = "0.001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Minimum Coordinate";
            // 
            // gbxPBC_options
            // 
            this.gbxPBC_options.Controls.Add(this.treeView1);
            this.gbxPBC_options.Controls.Add(this.chkWriteLogFiles);
            this.gbxPBC_options.Controls.Add(this.chkWriteRefinedMesh);
            this.gbxPBC_options.Controls.Add(this.rbtManualPBC);
            this.gbxPBC_options.Controls.Add(this.rbtAutomaticPBC);
            this.gbxPBC_options.Controls.Add(this.gbxAutomaticPBC);
            this.gbxPBC_options.Controls.Add(this.gbxManualPBC);
            this.gbxPBC_options.Location = new System.Drawing.Point(6, 126);
            this.gbxPBC_options.MinimumSize = new System.Drawing.Size(611, 356);
            this.gbxPBC_options.Name = "gbxPBC_options";
            this.gbxPBC_options.Size = new System.Drawing.Size(615, 356);
            this.gbxPBC_options.TabIndex = 13;
            this.gbxPBC_options.TabStop = false;
            this.gbxPBC_options.Text = "PBCs to write";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(616, 49);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "Node1";
            treeNode11.Text = "Uniaxial";
            treeNode12.Name = "Node2";
            treeNode12.Text = "Shear XY";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Free";
            treeNode14.Checked = true;
            treeNode14.Name = "Node6";
            treeNode14.Text = "Uniaxial";
            treeNode15.Name = "Node10";
            treeNode15.Text = "Shear XY";
            treeNode16.Name = "Node5";
            treeNode16.Text = "Antisymmetric";
            treeNode17.Name = "Node18";
            treeNode17.Text = "Uniaxial";
            treeNode18.Name = "Node17";
            treeNode18.Text = "Shear XY";
            treeNode19.Name = "Node15";
            treeNode19.Text = "Uniaxial for GENOA";
            treeNode20.Name = "Node11";
            treeNode20.Text = "Symmetric";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(121, 198);
            this.treeView1.TabIndex = 13;
            // 
            // chkWriteLogFiles
            // 
            this.chkWriteLogFiles.AutoSize = true;
            this.chkWriteLogFiles.Location = new System.Drawing.Point(6, 310);
            this.chkWriteLogFiles.Name = "chkWriteLogFiles";
            this.chkWriteLogFiles.Size = new System.Drawing.Size(89, 17);
            this.chkWriteLogFiles.TabIndex = 0;
            this.chkWriteLogFiles.Text = "Write log files";
            this.chkWriteLogFiles.UseVisualStyleBackColor = true;
            this.chkWriteLogFiles.Visible = false;
            // 
            // chkWriteRefinedMesh
            // 
            this.chkWriteRefinedMesh.AutoSize = true;
            this.chkWriteRefinedMesh.Location = new System.Drawing.Point(6, 333);
            this.chkWriteRefinedMesh.Name = "chkWriteRefinedMesh";
            this.chkWriteRefinedMesh.Size = new System.Drawing.Size(130, 17);
            this.chkWriteRefinedMesh.TabIndex = 0;
            this.chkWriteRefinedMesh.Text = "Write refined mesh file";
            this.chkWriteRefinedMesh.UseVisualStyleBackColor = true;
            // 
            // rbtManualPBC
            // 
            this.rbtManualPBC.AutoSize = true;
            this.rbtManualPBC.Location = new System.Drawing.Point(20, 43);
            this.rbtManualPBC.Name = "rbtManualPBC";
            this.rbtManualPBC.Size = new System.Drawing.Size(84, 17);
            this.rbtManualPBC.TabIndex = 9;
            this.rbtManualPBC.Text = "Manual PBC";
            this.rbtManualPBC.UseVisualStyleBackColor = true;
            // 
            // rbtAutomaticPBC
            // 
            this.rbtAutomaticPBC.AutoSize = true;
            this.rbtAutomaticPBC.Checked = true;
            this.rbtAutomaticPBC.Location = new System.Drawing.Point(20, 19);
            this.rbtAutomaticPBC.Name = "rbtAutomaticPBC";
            this.rbtAutomaticPBC.Size = new System.Drawing.Size(96, 17);
            this.rbtAutomaticPBC.TabIndex = 9;
            this.rbtAutomaticPBC.TabStop = true;
            this.rbtAutomaticPBC.Text = "Automatic PBC";
            this.rbtAutomaticPBC.UseVisualStyleBackColor = true;
            this.rbtAutomaticPBC.CheckedChanged += new System.EventHandler(this.rbtAutomaticPBC_CheckedChanged);
            // 
            // gbxAutomaticPBC
            // 
            this.gbxAutomaticPBC.Controls.Add(this.label33);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_symmUA);
            this.gbxAutomaticPBC.Controls.Add(this.label32);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_asymUA);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_symmForGENOA);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_symmShXY);
            this.gbxAutomaticPBC.Controls.Add(this.label31);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_asymShXY);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_freeUA);
            this.gbxAutomaticPBC.Controls.Add(this.chkAutoPBC_freeShXY);
            this.gbxAutomaticPBC.Location = new System.Drawing.Point(6, 66);
            this.gbxAutomaticPBC.Name = "gbxAutomaticPBC";
            this.gbxAutomaticPBC.Size = new System.Drawing.Size(141, 233);
            this.gbxAutomaticPBC.TabIndex = 8;
            this.gbxAutomaticPBC.TabStop = false;
            this.gbxAutomaticPBC.Text = "Automatic PBCs";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 134);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Symmetric";
            // 
            // chkAutoPBC_symmUA
            // 
            this.chkAutoPBC_symmUA.AutoSize = true;
            this.chkAutoPBC_symmUA.Location = new System.Drawing.Point(26, 150);
            this.chkAutoPBC_symmUA.Name = "chkAutoPBC_symmUA";
            this.chkAutoPBC_symmUA.Size = new System.Drawing.Size(63, 17);
            this.chkAutoPBC_symmUA.TabIndex = 0;
            this.chkAutoPBC_symmUA.Text = "Uniaxial";
            this.chkAutoPBC_symmUA.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 75);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 13);
            this.label32.TabIndex = 2;
            this.label32.Text = "Antisymmetric";
            // 
            // chkAutoPBC_asymUA
            // 
            this.chkAutoPBC_asymUA.AutoSize = true;
            this.chkAutoPBC_asymUA.Checked = true;
            this.chkAutoPBC_asymUA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoPBC_asymUA.Location = new System.Drawing.Point(26, 91);
            this.chkAutoPBC_asymUA.Name = "chkAutoPBC_asymUA";
            this.chkAutoPBC_asymUA.Size = new System.Drawing.Size(63, 17);
            this.chkAutoPBC_asymUA.TabIndex = 0;
            this.chkAutoPBC_asymUA.Text = "Uniaxial";
            this.chkAutoPBC_asymUA.UseVisualStyleBackColor = true;
            // 
            // chkAutoPBC_symmForGENOA
            // 
            this.chkAutoPBC_symmForGENOA.AutoSize = true;
            this.chkAutoPBC_symmForGENOA.Location = new System.Drawing.Point(6, 196);
            this.chkAutoPBC_symmForGENOA.Name = "chkAutoPBC_symmForGENOA";
            this.chkAutoPBC_symmForGENOA.Size = new System.Drawing.Size(130, 17);
            this.chkAutoPBC_symmForGENOA.TabIndex = 0;
            this.chkAutoPBC_symmForGENOA.Text = "Symmetric for GENOA";
            this.chkAutoPBC_symmForGENOA.UseVisualStyleBackColor = true;
            // 
            // chkAutoPBC_symmShXY
            // 
            this.chkAutoPBC_symmShXY.AutoSize = true;
            this.chkAutoPBC_symmShXY.Location = new System.Drawing.Point(26, 173);
            this.chkAutoPBC_symmShXY.Name = "chkAutoPBC_symmShXY";
            this.chkAutoPBC_symmShXY.Size = new System.Drawing.Size(71, 17);
            this.chkAutoPBC_symmShXY.TabIndex = 0;
            this.chkAutoPBC_symmShXY.Text = "Shear XY";
            this.chkAutoPBC_symmShXY.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(28, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "Free";
            // 
            // chkAutoPBC_asymShXY
            // 
            this.chkAutoPBC_asymShXY.AutoSize = true;
            this.chkAutoPBC_asymShXY.Location = new System.Drawing.Point(26, 114);
            this.chkAutoPBC_asymShXY.Name = "chkAutoPBC_asymShXY";
            this.chkAutoPBC_asymShXY.Size = new System.Drawing.Size(71, 17);
            this.chkAutoPBC_asymShXY.TabIndex = 0;
            this.chkAutoPBC_asymShXY.Text = "Shear XY";
            this.chkAutoPBC_asymShXY.UseVisualStyleBackColor = true;
            // 
            // chkAutoPBC_freeUA
            // 
            this.chkAutoPBC_freeUA.AutoSize = true;
            this.chkAutoPBC_freeUA.Location = new System.Drawing.Point(26, 32);
            this.chkAutoPBC_freeUA.Name = "chkAutoPBC_freeUA";
            this.chkAutoPBC_freeUA.Size = new System.Drawing.Size(63, 17);
            this.chkAutoPBC_freeUA.TabIndex = 0;
            this.chkAutoPBC_freeUA.Text = "Uniaxial";
            this.chkAutoPBC_freeUA.UseVisualStyleBackColor = true;
            // 
            // chkAutoPBC_freeShXY
            // 
            this.chkAutoPBC_freeShXY.AutoSize = true;
            this.chkAutoPBC_freeShXY.Location = new System.Drawing.Point(26, 55);
            this.chkAutoPBC_freeShXY.Name = "chkAutoPBC_freeShXY";
            this.chkAutoPBC_freeShXY.Size = new System.Drawing.Size(71, 17);
            this.chkAutoPBC_freeShXY.TabIndex = 0;
            this.chkAutoPBC_freeShXY.Text = "Shear XY";
            this.chkAutoPBC_freeShXY.UseVisualStyleBackColor = true;
            // 
            // gbxManualPBC
            // 
            this.gbxManualPBC.Controls.Add(this.label11);
            this.gbxManualPBC.Controls.Add(this.cbxAll);
            this.gbxManualPBC.Controls.Add(this.chkManualMasterNode);
            this.gbxManualPBC.Controls.Add(this.gbxManualMasterNodes);
            this.gbxManualPBC.Controls.Add(this.label10);
            this.gbxManualPBC.Controls.Add(this.label9);
            this.gbxManualPBC.Controls.Add(this.cbxZZ);
            this.gbxManualPBC.Controls.Add(this.cbxYZ);
            this.gbxManualPBC.Controls.Add(this.gbxXX);
            this.gbxManualPBC.Controls.Add(this.cbxXZ);
            this.gbxManualPBC.Controls.Add(this.gbxXY);
            this.gbxManualPBC.Controls.Add(this.label30);
            this.gbxManualPBC.Controls.Add(this.cbxZY);
            this.gbxManualPBC.Controls.Add(this.label29);
            this.gbxManualPBC.Controls.Add(this.gbxYX);
            this.gbxManualPBC.Controls.Add(this.label28);
            this.gbxManualPBC.Controls.Add(this.cbxYY);
            this.gbxManualPBC.Controls.Add(this.gbxXZ);
            this.gbxManualPBC.Controls.Add(this.cbxXY);
            this.gbxManualPBC.Controls.Add(this.gbxZX);
            this.gbxManualPBC.Controls.Add(this.cbxZX);
            this.gbxManualPBC.Controls.Add(this.gbxYY);
            this.gbxManualPBC.Controls.Add(this.gbxZZ);
            this.gbxManualPBC.Controls.Add(this.cbxXX);
            this.gbxManualPBC.Controls.Add(this.cbxYX);
            this.gbxManualPBC.Controls.Add(this.gbxZY);
            this.gbxManualPBC.Controls.Add(this.gbxYZ);
            this.gbxManualPBC.Enabled = false;
            this.gbxManualPBC.Location = new System.Drawing.Point(153, 19);
            this.gbxManualPBC.Name = "gbxManualPBC";
            this.gbxManualPBC.Size = new System.Drawing.Size(443, 331);
            this.gbxManualPBC.TabIndex = 12;
            this.gbxManualPBC.TabStop = false;
            this.gbxManualPBC.Text = "Manual choice of equations";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "DoF 3";
            // 
            // cbxAll
            // 
            this.cbxAll.AutoSize = true;
            this.cbxAll.Checked = true;
            this.cbxAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAll.Location = new System.Drawing.Point(6, 19);
            this.cbxAll.Name = "cbxAll";
            this.cbxAll.Size = new System.Drawing.Size(37, 17);
            this.cbxAll.TabIndex = 7;
            this.cbxAll.Text = "All";
            this.cbxAll.UseVisualStyleBackColor = true;
            this.cbxAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkManualMasterNode
            // 
            this.chkManualMasterNode.AutoSize = true;
            this.chkManualMasterNode.Location = new System.Drawing.Point(6, 211);
            this.chkManualMasterNode.Name = "chkManualMasterNode";
            this.chkManualMasterNode.Size = new System.Drawing.Size(167, 17);
            this.chkManualMasterNode.TabIndex = 10;
            this.chkManualMasterNode.Text = "Define master nodes manually";
            this.toolTip1.SetToolTip(this.chkManualMasterNode, "Use this to define the master nodes of the PBC manually. In case an invalid node " +
        "number of 0 is\r\nentered, the default master node will be used.");
            this.chkManualMasterNode.UseVisualStyleBackColor = true;
            this.chkManualMasterNode.CheckedChanged += new System.EventHandler(this.chkManualMasterNode_CheckedChanged);
            // 
            // gbxManualMasterNodes
            // 
            this.gbxManualMasterNodes.Controls.Add(this.nudMasterNodeX_src);
            this.gbxManualMasterNodes.Controls.Add(this.nudMasterNodeY_src);
            this.gbxManualMasterNodes.Controls.Add(this.nudMasterNodeZ_trgt);
            this.gbxManualMasterNodes.Controls.Add(this.nudMasterNodeX_trgt);
            this.gbxManualMasterNodes.Controls.Add(this.nudMasterNodeZ_src);
            this.gbxManualMasterNodes.Controls.Add(this.nudMasterNodeY_trgt);
            this.gbxManualMasterNodes.Controls.Add(this.label27);
            this.gbxManualMasterNodes.Controls.Add(this.label26);
            this.gbxManualMasterNodes.Enabled = false;
            this.gbxManualMasterNodes.Location = new System.Drawing.Point(6, 234);
            this.gbxManualMasterNodes.Name = "gbxManualMasterNodes";
            this.gbxManualMasterNodes.Size = new System.Drawing.Size(428, 79);
            this.gbxManualMasterNodes.TabIndex = 11;
            this.gbxManualMasterNodes.TabStop = false;
            this.gbxManualMasterNodes.Text = "Manual definition of master nodes";
            // 
            // nudMasterNodeX_src
            // 
            this.nudMasterNodeX_src.Location = new System.Drawing.Point(75, 19);
            this.nudMasterNodeX_src.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMasterNodeX_src.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMasterNodeX_src.Name = "nudMasterNodeX_src";
            this.nudMasterNodeX_src.Size = new System.Drawing.Size(90, 20);
            this.nudMasterNodeX_src.TabIndex = 9;
            this.nudMasterNodeX_src.ThousandsSeparator = true;
            // 
            // nudMasterNodeY_src
            // 
            this.nudMasterNodeY_src.Location = new System.Drawing.Point(202, 19);
            this.nudMasterNodeY_src.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMasterNodeY_src.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMasterNodeY_src.Name = "nudMasterNodeY_src";
            this.nudMasterNodeY_src.Size = new System.Drawing.Size(92, 20);
            this.nudMasterNodeY_src.TabIndex = 9;
            this.nudMasterNodeY_src.ThousandsSeparator = true;
            // 
            // nudMasterNodeZ_trgt
            // 
            this.nudMasterNodeZ_trgt.Location = new System.Drawing.Point(329, 45);
            this.nudMasterNodeZ_trgt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMasterNodeZ_trgt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMasterNodeZ_trgt.Name = "nudMasterNodeZ_trgt";
            this.nudMasterNodeZ_trgt.Size = new System.Drawing.Size(93, 20);
            this.nudMasterNodeZ_trgt.TabIndex = 9;
            this.nudMasterNodeZ_trgt.ThousandsSeparator = true;
            // 
            // nudMasterNodeX_trgt
            // 
            this.nudMasterNodeX_trgt.Location = new System.Drawing.Point(75, 45);
            this.nudMasterNodeX_trgt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMasterNodeX_trgt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMasterNodeX_trgt.Name = "nudMasterNodeX_trgt";
            this.nudMasterNodeX_trgt.Size = new System.Drawing.Size(90, 20);
            this.nudMasterNodeX_trgt.TabIndex = 9;
            this.nudMasterNodeX_trgt.ThousandsSeparator = true;
            // 
            // nudMasterNodeZ_src
            // 
            this.nudMasterNodeZ_src.Location = new System.Drawing.Point(329, 19);
            this.nudMasterNodeZ_src.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMasterNodeZ_src.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMasterNodeZ_src.Name = "nudMasterNodeZ_src";
            this.nudMasterNodeZ_src.Size = new System.Drawing.Size(93, 20);
            this.nudMasterNodeZ_src.TabIndex = 9;
            this.nudMasterNodeZ_src.ThousandsSeparator = true;
            // 
            // nudMasterNodeY_trgt
            // 
            this.nudMasterNodeY_trgt.Location = new System.Drawing.Point(202, 45);
            this.nudMasterNodeY_trgt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMasterNodeY_trgt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMasterNodeY_trgt.Name = "nudMasterNodeY_trgt";
            this.nudMasterNodeY_trgt.Size = new System.Drawing.Size(92, 20);
            this.nudMasterNodeY_trgt.TabIndex = 9;
            this.nudMasterNodeY_trgt.ThousandsSeparator = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 45);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Target";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Source";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "DoF 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "DoF 1";
            // 
            // cbxZZ
            // 
            this.cbxZZ.AutoSize = true;
            this.cbxZZ.Checked = true;
            this.cbxZZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxZZ.Location = new System.Drawing.Point(315, 174);
            this.cbxZZ.Name = "cbxZZ";
            this.cbxZZ.Size = new System.Drawing.Size(15, 14);
            this.cbxZZ.TabIndex = 7;
            this.cbxZZ.UseVisualStyleBackColor = true;
            this.cbxZZ.CheckedChanged += new System.EventHandler(this.cbxZZ_CheckedChanged);
            // 
            // cbxYZ
            // 
            this.cbxYZ.AutoSize = true;
            this.cbxYZ.Checked = true;
            this.cbxYZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxYZ.Location = new System.Drawing.Point(181, 175);
            this.cbxYZ.Name = "cbxYZ";
            this.cbxYZ.Size = new System.Drawing.Size(15, 14);
            this.cbxYZ.TabIndex = 7;
            this.cbxYZ.UseVisualStyleBackColor = true;
            this.cbxYZ.CheckedChanged += new System.EventHandler(this.cbxYZ_CheckedChanged);
            // 
            // gbxXX
            // 
            this.gbxXX.Controls.Add(this.rbtXX_2);
            this.gbxXX.Controls.Add(this.rbtXX_1);
            this.gbxXX.Location = new System.Drawing.Point(73, 40);
            this.gbxXX.Name = "gbxXX";
            this.gbxXX.Size = new System.Drawing.Size(98, 51);
            this.gbxXX.TabIndex = 8;
            this.gbxXX.TabStop = false;
            // 
            // rbtXX_2
            // 
            this.rbtXX_2.AutoSize = true;
            this.rbtXX_2.Location = new System.Drawing.Point(57, 18);
            this.rbtXX_2.Name = "rbtXX_2";
            this.rbtXX_2.Size = new System.Drawing.Size(31, 17);
            this.rbtXX_2.TabIndex = 6;
            this.rbtXX_2.Text = "2";
            this.toolTip1.SetToolTip(this.rbtXX_2, resources.GetString("rbtXX_2.ToolTip"));
            this.rbtXX_2.UseVisualStyleBackColor = true;
            // 
            // rbtXX_1
            // 
            this.rbtXX_1.AutoSize = true;
            this.rbtXX_1.Checked = true;
            this.rbtXX_1.Location = new System.Drawing.Point(8, 19);
            this.rbtXX_1.Name = "rbtXX_1";
            this.rbtXX_1.Size = new System.Drawing.Size(31, 17);
            this.rbtXX_1.TabIndex = 6;
            this.rbtXX_1.TabStop = true;
            this.rbtXX_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtXX_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.");
            this.rbtXX_1.UseVisualStyleBackColor = true;
            // 
            // cbxXZ
            // 
            this.cbxXZ.AutoSize = true;
            this.cbxXZ.Checked = true;
            this.cbxXZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxXZ.Location = new System.Drawing.Point(52, 175);
            this.cbxXZ.Name = "cbxXZ";
            this.cbxXZ.Size = new System.Drawing.Size(15, 14);
            this.cbxXZ.TabIndex = 7;
            this.cbxXZ.UseVisualStyleBackColor = true;
            this.cbxXZ.CheckedChanged += new System.EventHandler(this.cbxXZ_CheckedChanged);
            // 
            // gbxXY
            // 
            this.gbxXY.Controls.Add(this.radioButton7);
            this.gbxXY.Controls.Add(this.rbtXY_1);
            this.gbxXY.Location = new System.Drawing.Point(73, 97);
            this.gbxXY.Name = "gbxXY";
            this.gbxXY.Size = new System.Drawing.Size(98, 51);
            this.gbxXY.TabIndex = 8;
            this.gbxXY.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Location = new System.Drawing.Point(57, 18);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(31, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton7, resources.GetString("radioButton7.ToolTip"));
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rbtXY_1
            // 
            this.rbtXY_1.AutoSize = true;
            this.rbtXY_1.Location = new System.Drawing.Point(8, 18);
            this.rbtXY_1.Name = "rbtXY_1";
            this.rbtXY_1.Size = new System.Drawing.Size(31, 17);
            this.rbtXY_1.TabIndex = 6;
            this.rbtXY_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtXY_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtXY_1.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(333, 24);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Z - direction faces";
            // 
            // cbxZY
            // 
            this.cbxZY.AutoSize = true;
            this.cbxZY.Checked = true;
            this.cbxZY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxZY.Location = new System.Drawing.Point(315, 118);
            this.cbxZY.Name = "cbxZY";
            this.cbxZY.Size = new System.Drawing.Size(15, 14);
            this.cbxZY.TabIndex = 7;
            this.cbxZY.UseVisualStyleBackColor = true;
            this.cbxZY.CheckedChanged += new System.EventHandler(this.cbxZY_CheckedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(199, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Y - direction faces";
            // 
            // gbxYX
            // 
            this.gbxYX.Controls.Add(this.radioButton3);
            this.gbxYX.Controls.Add(this.rbtYX_1);
            this.gbxYX.Location = new System.Drawing.Point(202, 40);
            this.gbxYX.Name = "gbxYX";
            this.gbxYX.Size = new System.Drawing.Size(98, 51);
            this.gbxYX.TabIndex = 8;
            this.gbxYX.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(57, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton3, resources.GetString("radioButton3.ToolTip"));
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbtYX_1
            // 
            this.rbtYX_1.AutoSize = true;
            this.rbtYX_1.Location = new System.Drawing.Point(8, 19);
            this.rbtYX_1.Name = "rbtYX_1";
            this.rbtYX_1.Size = new System.Drawing.Size(31, 17);
            this.rbtYX_1.TabIndex = 6;
            this.rbtYX_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtYX_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtYX_1.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(73, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "X - direction faces";
            // 
            // cbxYY
            // 
            this.cbxYY.AutoSize = true;
            this.cbxYY.Checked = true;
            this.cbxYY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxYY.Location = new System.Drawing.Point(181, 119);
            this.cbxYY.Name = "cbxYY";
            this.cbxYY.Size = new System.Drawing.Size(15, 14);
            this.cbxYY.TabIndex = 7;
            this.cbxYY.UseVisualStyleBackColor = true;
            this.cbxYY.CheckedChanged += new System.EventHandler(this.cbxYY_CheckedChanged);
            // 
            // gbxXZ
            // 
            this.gbxXZ.Controls.Add(this.radioButton13);
            this.gbxXZ.Controls.Add(this.rbtXZ_1);
            this.gbxXZ.Location = new System.Drawing.Point(73, 154);
            this.gbxXZ.Name = "gbxXZ";
            this.gbxXZ.Size = new System.Drawing.Size(98, 51);
            this.gbxXZ.TabIndex = 8;
            this.gbxXZ.TabStop = false;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Checked = true;
            this.radioButton13.Location = new System.Drawing.Point(57, 18);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(31, 17);
            this.radioButton13.TabIndex = 6;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton13, resources.GetString("radioButton13.ToolTip"));
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // rbtXZ_1
            // 
            this.rbtXZ_1.AutoSize = true;
            this.rbtXZ_1.Location = new System.Drawing.Point(8, 19);
            this.rbtXZ_1.Name = "rbtXZ_1";
            this.rbtXZ_1.Size = new System.Drawing.Size(31, 17);
            this.rbtXZ_1.TabIndex = 6;
            this.rbtXZ_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtXZ_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtXZ_1.UseVisualStyleBackColor = true;
            // 
            // cbxXY
            // 
            this.cbxXY.AutoSize = true;
            this.cbxXY.Checked = true;
            this.cbxXY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxXY.Location = new System.Drawing.Point(52, 119);
            this.cbxXY.Name = "cbxXY";
            this.cbxXY.Size = new System.Drawing.Size(15, 14);
            this.cbxXY.TabIndex = 7;
            this.cbxXY.UseVisualStyleBackColor = true;
            this.cbxXY.CheckedChanged += new System.EventHandler(this.cbxXY_CheckedChanged);
            // 
            // gbxZX
            // 
            this.gbxZX.Controls.Add(this.radioButton11);
            this.gbxZX.Controls.Add(this.rbtZX_1);
            this.gbxZX.Location = new System.Drawing.Point(336, 39);
            this.gbxZX.Name = "gbxZX";
            this.gbxZX.Size = new System.Drawing.Size(98, 51);
            this.gbxZX.TabIndex = 8;
            this.gbxZX.TabStop = false;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Checked = true;
            this.radioButton11.Location = new System.Drawing.Point(57, 18);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(31, 17);
            this.radioButton11.TabIndex = 6;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton11, resources.GetString("radioButton11.ToolTip"));
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // rbtZX_1
            // 
            this.rbtZX_1.AutoSize = true;
            this.rbtZX_1.Location = new System.Drawing.Point(8, 19);
            this.rbtZX_1.Name = "rbtZX_1";
            this.rbtZX_1.Size = new System.Drawing.Size(31, 17);
            this.rbtZX_1.TabIndex = 6;
            this.rbtZX_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtZX_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtZX_1.UseVisualStyleBackColor = true;
            // 
            // cbxZX
            // 
            this.cbxZX.AutoSize = true;
            this.cbxZX.Checked = true;
            this.cbxZX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxZX.Location = new System.Drawing.Point(315, 60);
            this.cbxZX.Name = "cbxZX";
            this.cbxZX.Size = new System.Drawing.Size(15, 14);
            this.cbxZX.TabIndex = 7;
            this.cbxZX.UseVisualStyleBackColor = true;
            this.cbxZX.CheckedChanged += new System.EventHandler(this.cbxZX_CheckedChanged);
            // 
            // gbxYY
            // 
            this.gbxYY.Controls.Add(this.radioButton5);
            this.gbxYY.Controls.Add(this.rbtYY_1);
            this.gbxYY.Location = new System.Drawing.Point(202, 97);
            this.gbxYY.Name = "gbxYY";
            this.gbxYY.Size = new System.Drawing.Size(98, 51);
            this.gbxYY.TabIndex = 8;
            this.gbxYY.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(57, 18);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton5, resources.GetString("radioButton5.ToolTip"));
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rbtYY_1
            // 
            this.rbtYY_1.AutoSize = true;
            this.rbtYY_1.Checked = true;
            this.rbtYY_1.Location = new System.Drawing.Point(8, 18);
            this.rbtYY_1.Name = "rbtYY_1";
            this.rbtYY_1.Size = new System.Drawing.Size(31, 17);
            this.rbtYY_1.TabIndex = 6;
            this.rbtYY_1.TabStop = true;
            this.rbtYY_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtYY_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtYY_1.UseVisualStyleBackColor = true;
            // 
            // gbxZZ
            // 
            this.gbxZZ.Controls.Add(this.radioButton17);
            this.gbxZZ.Controls.Add(this.rbtZZ_1);
            this.gbxZZ.Location = new System.Drawing.Point(336, 153);
            this.gbxZZ.Name = "gbxZZ";
            this.gbxZZ.Size = new System.Drawing.Size(98, 51);
            this.gbxZZ.TabIndex = 8;
            this.gbxZZ.TabStop = false;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(59, 18);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(31, 17);
            this.radioButton17.TabIndex = 6;
            this.radioButton17.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton17, resources.GetString("radioButton17.ToolTip"));
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // rbtZZ_1
            // 
            this.rbtZZ_1.AutoSize = true;
            this.rbtZZ_1.Checked = true;
            this.rbtZZ_1.Location = new System.Drawing.Point(9, 19);
            this.rbtZZ_1.Name = "rbtZZ_1";
            this.rbtZZ_1.Size = new System.Drawing.Size(31, 17);
            this.rbtZZ_1.TabIndex = 6;
            this.rbtZZ_1.TabStop = true;
            this.rbtZZ_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtZZ_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtZZ_1.UseVisualStyleBackColor = true;
            // 
            // cbxXX
            // 
            this.cbxXX.AutoSize = true;
            this.cbxXX.Checked = true;
            this.cbxXX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxXX.Location = new System.Drawing.Point(52, 61);
            this.cbxXX.Name = "cbxXX";
            this.cbxXX.Size = new System.Drawing.Size(15, 14);
            this.cbxXX.TabIndex = 7;
            this.cbxXX.UseVisualStyleBackColor = true;
            this.cbxXX.CheckedChanged += new System.EventHandler(this.cbxXX_CheckedChanged);
            // 
            // cbxYX
            // 
            this.cbxYX.AutoSize = true;
            this.cbxYX.Checked = true;
            this.cbxYX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxYX.Location = new System.Drawing.Point(181, 61);
            this.cbxYX.Name = "cbxYX";
            this.cbxYX.Size = new System.Drawing.Size(15, 14);
            this.cbxYX.TabIndex = 7;
            this.cbxYX.UseVisualStyleBackColor = true;
            this.cbxYX.CheckedChanged += new System.EventHandler(this.cbxYX_CheckedChanged);
            // 
            // gbxZY
            // 
            this.gbxZY.Controls.Add(this.radioButton15);
            this.gbxZY.Controls.Add(this.rbtZY_1);
            this.gbxZY.Location = new System.Drawing.Point(336, 96);
            this.gbxZY.Name = "gbxZY";
            this.gbxZY.Size = new System.Drawing.Size(98, 51);
            this.gbxZY.TabIndex = 8;
            this.gbxZY.TabStop = false;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Checked = true;
            this.radioButton15.Location = new System.Drawing.Point(57, 18);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(31, 17);
            this.radioButton15.TabIndex = 6;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton15, resources.GetString("radioButton15.ToolTip"));
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // rbtZY_1
            // 
            this.rbtZY_1.AutoSize = true;
            this.rbtZY_1.Location = new System.Drawing.Point(8, 18);
            this.rbtZY_1.Name = "rbtZY_1";
            this.rbtZY_1.Size = new System.Drawing.Size(31, 17);
            this.rbtZY_1.TabIndex = 6;
            this.rbtZY_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtZY_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtZY_1.UseVisualStyleBackColor = true;
            // 
            // gbxYZ
            // 
            this.gbxYZ.Controls.Add(this.radioButton9);
            this.gbxYZ.Controls.Add(this.rbtYZ_1);
            this.gbxYZ.Location = new System.Drawing.Point(202, 154);
            this.gbxYZ.Name = "gbxYZ";
            this.gbxYZ.Size = new System.Drawing.Size(98, 51);
            this.gbxYZ.TabIndex = 8;
            this.gbxYZ.TabStop = false;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Location = new System.Drawing.Point(57, 18);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(31, 17);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "2";
            this.toolTip1.SetToolTip(this.radioButton9, resources.GetString("radioButton9.ToolTip"));
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // rbtYZ_1
            // 
            this.rbtYZ_1.AutoSize = true;
            this.rbtYZ_1.Location = new System.Drawing.Point(8, 18);
            this.rbtYZ_1.Name = "rbtYZ_1";
            this.rbtYZ_1.Size = new System.Drawing.Size(31, 17);
            this.rbtYZ_1.TabIndex = 6;
            this.rbtYZ_1.Text = "1";
            this.toolTip1.SetToolTip(this.rbtYZ_1, "Type 1 equations: ( u_p - u_q = u_M1 - u_M2)\r\n    Enables to apply displacement t" +
        "o the master nodes and transmit\r\nthe displacement to all of the nodes in those f" +
        "aces.\r\n");
            this.rbtYZ_1.UseVisualStyleBackColor = true;
            // 
            // btnRefineNodes
            // 
            this.btnRefineNodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefineNodes.Enabled = false;
            this.btnRefineNodes.Location = new System.Drawing.Point(6, 506);
            this.btnRefineNodes.Name = "btnRefineNodes";
            this.btnRefineNodes.Size = new System.Drawing.Size(604, 31);
            this.btnRefineNodes.TabIndex = 4;
            this.btnRefineNodes.Text = "Refine Nodes and generate equation constraints";
            this.btnRefineNodes.UseVisualStyleBackColor = true;
            this.btnRefineNodes.Click += new System.EventHandler(this.btnRunNodeRefinement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblElements);
            this.groupBox1.Controls.Add(this.lblNodes);
            this.groupBox1.Controls.Add(this.lblMaterials);
            this.groupBox1.Controls.Add(this.btnShowData);
            this.groupBox1.Location = new System.Drawing.Point(521, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 115);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Info";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(661, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbxInputOutput);
            this.Controls.Add(this.gbxProgress);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Abaqus Extension";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxInputOutput.ResumeLayout(false);
            this.gbxInputOutput.PerformLayout();
            this.gbxTowDefinition.ResumeLayout(false);
            this.gbxTowDefinition.PerformLayout();
            this.gbxGENOAinput.ResumeLayout(false);
            this.gbxGENOAinput.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbOfAxialTows)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiasTowFailCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiasTowMatxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBiasTowFibrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAxlTowFailCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAxlTowMatxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatxFailCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatxMatxID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAxlTowFibrID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMatxFibID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTowDefinition)).EndInit();
            this.gbxProgress.ResumeLayout(false);
            this.gbxProgress.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbxUnitCellDefinition.ResumeLayout(false);
            this.gbxUnitCellDefinition.PerformLayout();
            this.gbxPBC_options.ResumeLayout(false);
            this.gbxPBC_options.PerformLayout();
            this.gbxAutomaticPBC.ResumeLayout(false);
            this.gbxAutomaticPBC.PerformLayout();
            this.gbxManualPBC.ResumeLayout(false);
            this.gbxManualPBC.PerformLayout();
            this.gbxManualMasterNodes.ResumeLayout(false);
            this.gbxManualMasterNodes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeX_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeY_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeZ_trgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeX_trgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeZ_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterNodeY_trgt)).EndInit();
            this.gbxXX.ResumeLayout(false);
            this.gbxXX.PerformLayout();
            this.gbxXY.ResumeLayout(false);
            this.gbxXY.PerformLayout();
            this.gbxYX.ResumeLayout(false);
            this.gbxYX.PerformLayout();
            this.gbxXZ.ResumeLayout(false);
            this.gbxXZ.PerformLayout();
            this.gbxZX.ResumeLayout(false);
            this.gbxZX.PerformLayout();
            this.gbxYY.ResumeLayout(false);
            this.gbxYY.PerformLayout();
            this.gbxZZ.ResumeLayout(false);
            this.gbxZZ.PerformLayout();
            this.gbxZY.ResumeLayout(false);
            this.gbxZY.PerformLayout();
            this.gbxYZ.ResumeLayout(false);
            this.gbxYZ.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtWorkingFolder;
        private System.Windows.Forms.Button btnBrowseMeshFile;
        private System.Windows.Forms.OpenFileDialog ofdMeshFile;
        private System.Windows.Forms.GroupBox gbxInputOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseOutputFolder;
        private System.Windows.Forms.TextBox txtMeshFile;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.TextBox txtElemGroupingLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxTowDefinition;
        private System.Windows.Forms.DataGridView dgvTowDefinition;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FolderBrowserDialog fbwOutputFolder;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ProgressBar pgbrMainPrgrsBr;
        private System.Windows.Forms.Label lblProgress;
        private System.ComponentModel.BackgroundWorker bgwFileReader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxProgress;
        private System.ComponentModel.BackgroundWorker bgwExecuter;
        private System.Windows.Forms.DataGridViewButtonColumn clmTowProperties;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtvClmMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblNodes;
        private System.Windows.Forms.Label lblElements;
        private System.Windows.Forms.Label lblMaterials;
        private System.Windows.Forms.Button btnSaveInput;
        private System.Windows.Forms.Button btnImportInput;
        private System.Windows.Forms.OpenFileDialog ofdInput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtStartCoordinate_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTolerance_X;
        private System.Windows.Forms.TextBox txtVector_X;
        private System.Windows.Forms.Button btnRefineNodes;
        private System.Windows.Forms.TextBox txtTolerance_Z;
        private System.Windows.Forms.TextBox txtVector_Z;
        private System.Windows.Forms.TextBox txtTolerance_Y;
        private System.Windows.Forms.TextBox txtVector_Y;
        private System.Windows.Forms.TextBox txtStartCoordinate_Z;
        private System.Windows.Forms.TextBox txtStartCoordinate_Y;
        private System.Windows.Forms.CheckBox cbxZZ;
        private System.Windows.Forms.CheckBox cbxYZ;
        private System.Windows.Forms.CheckBox cbxXZ;
        private System.Windows.Forms.CheckBox cbxZY;
        private System.Windows.Forms.CheckBox cbxYY;
        private System.Windows.Forms.CheckBox cbxXY;
        private System.Windows.Forms.CheckBox cbxZX;
        private System.Windows.Forms.GroupBox gbxZZ;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton rbtZZ_1;
        private System.Windows.Forms.CheckBox cbxYX;
        private System.Windows.Forms.GroupBox gbxYZ;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton rbtYZ_1;
        private System.Windows.Forms.GroupBox gbxZY;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton rbtZY_1;
        private System.Windows.Forms.CheckBox cbxAll;
        private System.Windows.Forms.CheckBox cbxXX;
        private System.Windows.Forms.GroupBox gbxYY;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rbtYY_1;
        private System.Windows.Forms.GroupBox gbxZX;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton rbtZX_1;
        private System.Windows.Forms.GroupBox gbxXZ;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton rbtXZ_1;
        private System.Windows.Forms.GroupBox gbxYX;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbtYX_1;
        private System.Windows.Forms.GroupBox gbxXY;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton rbtXY_1;
        private System.Windows.Forms.GroupBox gbxXX;
        private System.Windows.Forms.RadioButton rbtXX_2;
        private System.Windows.Forms.RadioButton rbtXX_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbxGENOAinput;
        private System.Windows.Forms.TextBox txtBiasTowTemp;
        private System.Windows.Forms.TextBox txtBiasTowV_fract;
        private System.Windows.Forms.TextBox txtBiasTowF_fract;
        private System.Windows.Forms.TextBox txtBiasTowAng;
        private System.Windows.Forms.TextBox txtBiasTowThick;
        private System.Windows.Forms.TextBox txtAxlTowTemp;
        private System.Windows.Forms.TextBox txtMatxTemp;
        private System.Windows.Forms.TextBox txtAxlTowV_fract;
        private System.Windows.Forms.TextBox txtMatxV_fract;
        private System.Windows.Forms.TextBox txtAxlTowF_fract;
        private System.Windows.Forms.TextBox txtMatxF_fract;
        private System.Windows.Forms.TextBox txtAxlTowAng;
        private System.Windows.Forms.TextBox txtMatxAng;
        private System.Windows.Forms.TextBox txtAxlTowThick;
        private System.Windows.Forms.TextBox txtMatxThick;
        private System.Windows.Forms.NumericUpDown nudBiasTowFailCrit;
        private System.Windows.Forms.NumericUpDown nudBiasTowMatxID;
        private System.Windows.Forms.NumericUpDown nudBiasTowFibrID;
        private System.Windows.Forms.NumericUpDown nudAxlTowFailCrit;
        private System.Windows.Forms.NumericUpDown nudAxlTowMatxID;
        private System.Windows.Forms.NumericUpDown nudMatxFailCrit;
        private System.Windows.Forms.NumericUpDown nudMatxMatxID;
        private System.Windows.Forms.NumericUpDown nudAxlTowFibrID;
        private System.Windows.Forms.NumericUpDown nudMatxFibID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radTowMat_Ply;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radTowMat_FibrMatx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudNumbOfAxialTows;
        private System.Windows.Forms.CheckBox chkGenerateGENOA;
        private System.Windows.Forms.CheckBox chkManualMasterNode;
        private System.Windows.Forms.NumericUpDown nudMasterNodeZ_src;
        private System.Windows.Forms.NumericUpDown nudMasterNodeY_src;
        private System.Windows.Forms.NumericUpDown nudMasterNodeX_src;
        private System.Windows.Forms.GroupBox gbxManualMasterNodes;
        private System.Windows.Forms.NumericUpDown nudMasterNodeZ_trgt;
        private System.Windows.Forms.NumericUpDown nudMasterNodeX_trgt;
        private System.Windows.Forms.NumericUpDown nudMasterNodeY_trgt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox gbxManualPBC;
        private System.Windows.Forms.CheckBox chkWriteRefinedMesh;
        private System.Windows.Forms.GroupBox gbxPBC_options;
        private System.Windows.Forms.RadioButton rbtManualPBC;
        private System.Windows.Forms.RadioButton rbtAutomaticPBC;
        private System.Windows.Forms.GroupBox gbxAutomaticPBC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox gbxUnitCellDefinition;
        private System.Windows.Forms.CheckBox chkWriteLogFiles;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox chkAutoPBC_freeShXY;
        private System.Windows.Forms.CheckBox chkAutoPBC_freeUA;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox chkAutoPBC_symmUA;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox chkAutoPBC_asymUA;
        private System.Windows.Forms.CheckBox chkAutoPBC_symmForGENOA;
        private System.Windows.Forms.CheckBox chkAutoPBC_symmShXY;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox chkAutoPBC_asymShXY;
    }
}

