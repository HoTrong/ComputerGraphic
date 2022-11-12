namespace Lab04
{
    partial class SharpGLFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpGLFrom));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtboxLength = new System.Windows.Forms.TextBox();
            this.lboxObjectsList = new System.Windows.Forms.ListBox();
            this.txtboxHeight = new System.Windows.Forms.TextBox();
            this.lblScale = new System.Windows.Forms.Label();
            this.txtboxSX = new System.Windows.Forms.TextBox();
            this.lblSX = new System.Windows.Forms.Label();
            this.lblSY = new System.Windows.Forms.Label();
            this.lblSZ = new System.Windows.Forms.Label();
            this.txtboxSY = new System.Windows.Forms.TextBox();
            this.txtboxSZ = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtboxPX = new System.Windows.Forms.TextBox();
            this.txtboxPY = new System.Windows.Forms.TextBox();
            this.txtboxPZ = new System.Windows.Forms.TextBox();
            this.lblPX = new System.Windows.Forms.Label();
            this.lblPY = new System.Windows.Forms.Label();
            this.lblPZ = new System.Windows.Forms.Label();
            this.lblRotation = new System.Windows.Forms.Label();
            this.lblRX = new System.Windows.Forms.Label();
            this.txtboxRX = new System.Windows.Forms.TextBox();
            this.lblRY = new System.Windows.Forms.Label();
            this.txtboxRY = new System.Windows.Forms.TextBox();
            this.lblRZ = new System.Windows.Forms.Label();
            this.txtboxRZ = new System.Windows.Forms.TextBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lbCamX = new System.Windows.Forms.Label();
            this.lbCamPosX = new System.Windows.Forms.Label();
            this.lbCamPosY = new System.Windows.Forms.Label();
            this.lbCamPosZ = new System.Windows.Forms.Label();
            this.btnRotation = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnSetHeight = new System.Windows.Forms.Button();
            this.btnSetLength = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOpenTextureFile = new System.Windows.Forms.Button();
            this.lblTexture = new System.Windows.Forms.Label();
            this.btnStickTexture = new System.Windows.Forms.Button();
            this.btnRemoveTexture = new System.Windows.Forms.Button();
            this.txtboxTexturePath = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.ptboxShowTexture = new System.Windows.Forms.PictureBox();
            this.btnPyramid = new System.Windows.Forms.Button();
            this.btnPrism = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxShowTexture)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(12, 157);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1049, 438);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // txtboxLength
            // 
            this.txtboxLength.Enabled = false;
            this.txtboxLength.Location = new System.Drawing.Point(54, 62);
            this.txtboxLength.Name = "txtboxLength";
            this.txtboxLength.Size = new System.Drawing.Size(107, 20);
            this.txtboxLength.TabIndex = 4;
            // 
            // lboxObjectsList
            // 
            this.lboxObjectsList.FormattingEnabled = true;
            this.lboxObjectsList.Location = new System.Drawing.Point(603, 43);
            this.lboxObjectsList.Name = "lboxObjectsList";
            this.lboxObjectsList.Size = new System.Drawing.Size(200, 108);
            this.lboxObjectsList.TabIndex = 19;
            this.lboxObjectsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxObjectsList_MouseClick);
            // 
            // txtboxHeight
            // 
            this.txtboxHeight.Enabled = false;
            this.txtboxHeight.Location = new System.Drawing.Point(54, 96);
            this.txtboxHeight.Name = "txtboxHeight";
            this.txtboxHeight.Size = new System.Drawing.Size(107, 20);
            this.txtboxHeight.TabIndex = 20;
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(217, 130);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(34, 13);
            this.lblScale.TabIndex = 22;
            this.lblScale.Text = "Scale";
            // 
            // txtboxSX
            // 
            this.txtboxSX.Enabled = false;
            this.txtboxSX.Location = new System.Drawing.Point(289, 127);
            this.txtboxSX.Name = "txtboxSX";
            this.txtboxSX.Size = new System.Drawing.Size(59, 20);
            this.txtboxSX.TabIndex = 23;
            // 
            // lblSX
            // 
            this.lblSX.AutoSize = true;
            this.lblSX.Location = new System.Drawing.Point(269, 130);
            this.lblSX.Name = "lblSX";
            this.lblSX.Size = new System.Drawing.Size(14, 13);
            this.lblSX.TabIndex = 24;
            this.lblSX.Text = "X";
            // 
            // lblSY
            // 
            this.lblSY.AutoSize = true;
            this.lblSY.Location = new System.Drawing.Point(354, 130);
            this.lblSY.Name = "lblSY";
            this.lblSY.Size = new System.Drawing.Size(14, 13);
            this.lblSY.TabIndex = 27;
            this.lblSY.Text = "Y";
            // 
            // lblSZ
            // 
            this.lblSZ.AutoSize = true;
            this.lblSZ.Location = new System.Drawing.Point(452, 130);
            this.lblSZ.Name = "lblSZ";
            this.lblSZ.Size = new System.Drawing.Size(14, 13);
            this.lblSZ.TabIndex = 28;
            this.lblSZ.Text = "Z";
            // 
            // txtboxSY
            // 
            this.txtboxSY.Enabled = false;
            this.txtboxSY.Location = new System.Drawing.Point(374, 127);
            this.txtboxSY.Name = "txtboxSY";
            this.txtboxSY.Size = new System.Drawing.Size(72, 20);
            this.txtboxSY.TabIndex = 29;
            // 
            // txtboxSZ
            // 
            this.txtboxSZ.Enabled = false;
            this.txtboxSZ.Location = new System.Drawing.Point(472, 127);
            this.txtboxSZ.Name = "txtboxSZ";
            this.txtboxSZ.Size = new System.Drawing.Size(72, 20);
            this.txtboxSZ.TabIndex = 30;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(217, 21);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 31;
            this.lblPosition.Text = "Position";
            // 
            // txtboxPX
            // 
            this.txtboxPX.Enabled = false;
            this.txtboxPX.Location = new System.Drawing.Point(289, 19);
            this.txtboxPX.Name = "txtboxPX";
            this.txtboxPX.Size = new System.Drawing.Size(59, 20);
            this.txtboxPX.TabIndex = 32;
            // 
            // txtboxPY
            // 
            this.txtboxPY.Enabled = false;
            this.txtboxPY.Location = new System.Drawing.Point(374, 19);
            this.txtboxPY.Name = "txtboxPY";
            this.txtboxPY.Size = new System.Drawing.Size(72, 20);
            this.txtboxPY.TabIndex = 33;
            // 
            // txtboxPZ
            // 
            this.txtboxPZ.Enabled = false;
            this.txtboxPZ.Location = new System.Drawing.Point(472, 18);
            this.txtboxPZ.Name = "txtboxPZ";
            this.txtboxPZ.Size = new System.Drawing.Size(72, 20);
            this.txtboxPZ.TabIndex = 34;
            // 
            // lblPX
            // 
            this.lblPX.AutoSize = true;
            this.lblPX.Location = new System.Drawing.Point(269, 22);
            this.lblPX.Name = "lblPX";
            this.lblPX.Size = new System.Drawing.Size(14, 13);
            this.lblPX.TabIndex = 35;
            this.lblPX.Text = "X";
            // 
            // lblPY
            // 
            this.lblPY.AutoSize = true;
            this.lblPY.Location = new System.Drawing.Point(354, 22);
            this.lblPY.Name = "lblPY";
            this.lblPY.Size = new System.Drawing.Size(14, 13);
            this.lblPY.TabIndex = 36;
            this.lblPY.Text = "Y";
            // 
            // lblPZ
            // 
            this.lblPZ.AutoSize = true;
            this.lblPZ.Location = new System.Drawing.Point(452, 21);
            this.lblPZ.Name = "lblPZ";
            this.lblPZ.Size = new System.Drawing.Size(14, 13);
            this.lblPZ.TabIndex = 37;
            this.lblPZ.Text = "Z";
            // 
            // lblRotation
            // 
            this.lblRotation.AutoSize = true;
            this.lblRotation.Location = new System.Drawing.Point(217, 76);
            this.lblRotation.Name = "lblRotation";
            this.lblRotation.Size = new System.Drawing.Size(47, 13);
            this.lblRotation.TabIndex = 38;
            this.lblRotation.Text = "Rotation";
            // 
            // lblRX
            // 
            this.lblRX.AutoSize = true;
            this.lblRX.Location = new System.Drawing.Point(269, 76);
            this.lblRX.Name = "lblRX";
            this.lblRX.Size = new System.Drawing.Size(14, 13);
            this.lblRX.TabIndex = 39;
            this.lblRX.Text = "X";
            // 
            // txtboxRX
            // 
            this.txtboxRX.Enabled = false;
            this.txtboxRX.Location = new System.Drawing.Point(289, 73);
            this.txtboxRX.Name = "txtboxRX";
            this.txtboxRX.Size = new System.Drawing.Size(59, 20);
            this.txtboxRX.TabIndex = 40;
            // 
            // lblRY
            // 
            this.lblRY.AutoSize = true;
            this.lblRY.Location = new System.Drawing.Point(354, 76);
            this.lblRY.Name = "lblRY";
            this.lblRY.Size = new System.Drawing.Size(14, 13);
            this.lblRY.TabIndex = 41;
            this.lblRY.Text = "Y";
            // 
            // txtboxRY
            // 
            this.txtboxRY.Enabled = false;
            this.txtboxRY.Location = new System.Drawing.Point(374, 73);
            this.txtboxRY.Name = "txtboxRY";
            this.txtboxRY.Size = new System.Drawing.Size(72, 20);
            this.txtboxRY.TabIndex = 42;
            // 
            // lblRZ
            // 
            this.lblRZ.AutoSize = true;
            this.lblRZ.Location = new System.Drawing.Point(452, 76);
            this.lblRZ.Name = "lblRZ";
            this.lblRZ.Size = new System.Drawing.Size(14, 13);
            this.lblRZ.TabIndex = 43;
            this.lblRZ.Text = "Z";
            // 
            // txtboxRZ
            // 
            this.txtboxRZ.Enabled = false;
            this.txtboxRZ.Location = new System.Drawing.Point(472, 73);
            this.txtboxRZ.Name = "txtboxRZ";
            this.txtboxRZ.Size = new System.Drawing.Size(72, 20);
            this.txtboxRZ.TabIndex = 44;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(135, 12);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(68, 33);
            this.btnChooseColor.TabIndex = 21;
            this.btnChooseColor.Text = "Colors";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(9, 65);
            this.lblLength.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 52;
            this.lblLength.Text = "Length";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 99);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 53;
            this.lblHeight.Text = "Height";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(985, 170);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(23, 13);
            this.lblX.TabIndex = 61;
            this.lblX.Text = "X :";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.ForeColor = System.Drawing.Color.Lime;
            this.lblY.Location = new System.Drawing.Point(985, 193);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(23, 13);
            this.lblY.TabIndex = 62;
            this.lblY.Text = "Y :";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.ForeColor = System.Drawing.Color.Blue;
            this.lblZ.Location = new System.Drawing.Point(985, 216);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(23, 13);
            this.lblZ.TabIndex = 63;
            this.lblZ.Text = "Z :";
            // 
            // lbCamX
            // 
            this.lbCamX.AutoSize = true;
            this.lbCamX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamX.ForeColor = System.Drawing.Color.Red;
            this.lbCamX.Location = new System.Drawing.Point(494, 112);
            this.lbCamX.Name = "lbCamX";
            this.lbCamX.Size = new System.Drawing.Size(0, 13);
            this.lbCamX.TabIndex = 64;
            // 
            // lbCamPosX
            // 
            this.lbCamPosX.AutoSize = true;
            this.lbCamPosX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosX.ForeColor = System.Drawing.Color.Red;
            this.lbCamPosX.Location = new System.Drawing.Point(1011, 170);
            this.lbCamPosX.Name = "lbCamPosX";
            this.lbCamPosX.Size = new System.Drawing.Size(39, 13);
            this.lbCamPosX.TabIndex = 65;
            this.lbCamPosX.Text = "0.000";
            this.lbCamPosX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamPosY
            // 
            this.lbCamPosY.AutoSize = true;
            this.lbCamPosY.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosY.ForeColor = System.Drawing.Color.Lime;
            this.lbCamPosY.Location = new System.Drawing.Point(1011, 193);
            this.lbCamPosY.Name = "lbCamPosY";
            this.lbCamPosY.Size = new System.Drawing.Size(39, 13);
            this.lbCamPosY.TabIndex = 66;
            this.lbCamPosY.Text = "0.000";
            this.lbCamPosY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamPosZ
            // 
            this.lbCamPosZ.AutoSize = true;
            this.lbCamPosZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosZ.ForeColor = System.Drawing.Color.Blue;
            this.lbCamPosZ.Location = new System.Drawing.Point(1011, 216);
            this.lbCamPosZ.Name = "lbCamPosZ";
            this.lbCamPosZ.Size = new System.Drawing.Size(39, 13);
            this.lbCamPosZ.TabIndex = 67;
            this.lbCamPosZ.Text = "0.000";
            this.lbCamPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRotation
            // 
            this.btnRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotation.Location = new System.Drawing.Point(553, 68);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(35, 29);
            this.btnRotation.TabIndex = 57;
            this.btnRotation.Text = "OK";
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // btnScale
            // 
            this.btnScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScale.Location = new System.Drawing.Point(553, 122);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(35, 29);
            this.btnScale.TabIndex = 56;
            this.btnScale.Text = "OK";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Location = new System.Drawing.Point(553, 13);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(35, 29);
            this.btnPosition.TabIndex = 55;
            this.btnPosition.Text = "OK";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnSetHeight
            // 
            this.btnSetHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetHeight.Location = new System.Drawing.Point(167, 93);
            this.btnSetHeight.Name = "btnSetHeight";
            this.btnSetHeight.Size = new System.Drawing.Size(35, 27);
            this.btnSetHeight.TabIndex = 50;
            this.btnSetHeight.Text = "OK";
            this.btnSetHeight.UseVisualStyleBackColor = true;
            this.btnSetHeight.Click += new System.EventHandler(this.btnSetHeight_Click);
            // 
            // btnSetLength
            // 
            this.btnSetLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetLength.Location = new System.Drawing.Point(167, 58);
            this.btnSetLength.Name = "btnSetLength";
            this.btnSetLength.Size = new System.Drawing.Size(35, 27);
            this.btnSetLength.TabIndex = 46;
            this.btnSetLength.Text = "OK";
            this.btnSetLength.UseVisualStyleBackColor = true;
            this.btnSetLength.Click += new System.EventHandler(this.btnSetLength_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(600, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 78;
            this.lblName.Text = "Name";
            // 
            // btnOpenTextureFile
            // 
            this.btnOpenTextureFile.Location = new System.Drawing.Point(811, 29);
            this.btnOpenTextureFile.Name = "btnOpenTextureFile";
            this.btnOpenTextureFile.Size = new System.Drawing.Size(44, 23);
            this.btnOpenTextureFile.TabIndex = 72;
            this.btnOpenTextureFile.Text = "Open";
            this.btnOpenTextureFile.UseVisualStyleBackColor = true;
            this.btnOpenTextureFile.Click += new System.EventHandler(this.btnOpenTextureFile_Click);
            // 
            // lblTexture
            // 
            this.lblTexture.AutoSize = true;
            this.lblTexture.Location = new System.Drawing.Point(808, 11);
            this.lblTexture.Name = "lblTexture";
            this.lblTexture.Size = new System.Drawing.Size(43, 13);
            this.lblTexture.TabIndex = 75;
            this.lblTexture.Text = "Texture";
            // 
            // btnStickTexture
            // 
            this.btnStickTexture.Location = new System.Drawing.Point(811, 57);
            this.btnStickTexture.Name = "btnStickTexture";
            this.btnStickTexture.Size = new System.Drawing.Size(44, 23);
            this.btnStickTexture.TabIndex = 76;
            this.btnStickTexture.Text = "Stick";
            this.btnStickTexture.UseVisualStyleBackColor = true;
            this.btnStickTexture.Click += new System.EventHandler(this.btnStickTexture_Click);
            // 
            // btnRemoveTexture
            // 
            this.btnRemoveTexture.Location = new System.Drawing.Point(811, 86);
            this.btnRemoveTexture.Name = "btnRemoveTexture";
            this.btnRemoveTexture.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveTexture.TabIndex = 77;
            this.btnRemoveTexture.Text = "Remove";
            this.btnRemoveTexture.UseVisualStyleBackColor = true;
            this.btnRemoveTexture.Click += new System.EventHandler(this.btnRemoveTexture_Click);
            // 
            // txtboxTexturePath
            // 
            this.txtboxTexturePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxTexturePath.Enabled = false;
            this.txtboxTexturePath.Location = new System.Drawing.Point(872, 9);
            this.txtboxTexturePath.Name = "txtboxTexturePath";
            this.txtboxTexturePath.ReadOnly = true;
            this.txtboxTexturePath.Size = new System.Drawing.Size(189, 20);
            this.txtboxTexturePath.TabIndex = 73;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(641, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 23);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(705, 8);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(97, 23);
            this.btnRemoveAll.TabIndex = 80;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // ptboxShowTexture
            // 
            this.ptboxShowTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptboxShowTexture.Location = new System.Drawing.Point(872, 34);
            this.ptboxShowTexture.Name = "ptboxShowTexture";
            this.ptboxShowTexture.Size = new System.Drawing.Size(189, 117);
            this.ptboxShowTexture.TabIndex = 74;
            this.ptboxShowTexture.TabStop = false;
            // 
            // btnPyramid
            // 
            this.btnPyramid.FlatAppearance.BorderSize = 0;
            this.btnPyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyramid.Image = ((System.Drawing.Image)(resources.GetObject("btnPyramid.Image")));
            this.btnPyramid.Location = new System.Drawing.Point(54, 12);
            this.btnPyramid.Name = "btnPyramid";
            this.btnPyramid.Size = new System.Drawing.Size(33, 33);
            this.btnPyramid.TabIndex = 18;
            this.btnPyramid.UseVisualStyleBackColor = true;
            this.btnPyramid.Click += new System.EventHandler(this.btnPyramid_Click);
            // 
            // btnPrism
            // 
            this.btnPrism.FlatAppearance.BorderSize = 0;
            this.btnPrism.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrism.Image = global::BT4.Properties.Resources.prism;
            this.btnPrism.Location = new System.Drawing.Point(99, 13);
            this.btnPrism.Name = "btnPrism";
            this.btnPrism.Size = new System.Drawing.Size(30, 33);
            this.btnPrism.TabIndex = 17;
            this.btnPrism.UseVisualStyleBackColor = true;
            this.btnPrism.Click += new System.EventHandler(this.btnPrism_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCube.FlatAppearance.BorderSize = 0;
            this.btnCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCube.Image = ((System.Drawing.Image)(resources.GetObject("btnCube.Image")));
            this.btnCube.Location = new System.Drawing.Point(12, 12);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(29, 33);
            this.btnCube.TabIndex = 16;
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // SharpGLFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 607);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemoveTexture);
            this.Controls.Add(this.btnStickTexture);
            this.Controls.Add(this.lblTexture);
            this.Controls.Add(this.ptboxShowTexture);
            this.Controls.Add(this.txtboxTexturePath);
            this.Controls.Add(this.btnOpenTextureFile);
            this.Controls.Add(this.lbCamPosZ);
            this.Controls.Add(this.lbCamPosY);
            this.Controls.Add(this.lbCamPosX);
            this.Controls.Add(this.lbCamX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnScale);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.txtboxLength);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnSetHeight);
            this.Controls.Add(this.btnSetLength);
            this.Controls.Add(this.txtboxRZ);
            this.Controls.Add(this.lblRZ);
            this.Controls.Add(this.txtboxRY);
            this.Controls.Add(this.lblRY);
            this.Controls.Add(this.txtboxRX);
            this.Controls.Add(this.lblRX);
            this.Controls.Add(this.lblRotation);
            this.Controls.Add(this.lblPZ);
            this.Controls.Add(this.lblPY);
            this.Controls.Add(this.lblPX);
            this.Controls.Add(this.txtboxPZ);
            this.Controls.Add(this.txtboxPY);
            this.Controls.Add(this.txtboxPX);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.txtboxSZ);
            this.Controls.Add(this.txtboxSY);
            this.Controls.Add(this.lblSZ);
            this.Controls.Add(this.lblSY);
            this.Controls.Add(this.lblSX);
            this.Controls.Add(this.txtboxSX);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.txtboxHeight);
            this.Controls.Add(this.lboxObjectsList);
            this.Controls.Add(this.btnPyramid);
            this.Controls.Add(this.btnPrism);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.openGLControl);
            this.Name = "SharpGLFrom";
            this.Text = "SharpGL";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxShowTexture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtboxLength;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnPrism;
        private System.Windows.Forms.Button btnPyramid;
        private System.Windows.Forms.ListBox lboxObjectsList;
        private System.Windows.Forms.TextBox txtboxHeight;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TextBox txtboxSX;
        private System.Windows.Forms.Label lblSX;
        private System.Windows.Forms.Label lblSY;
        private System.Windows.Forms.Label lblSZ;
        private System.Windows.Forms.TextBox txtboxSY;
        private System.Windows.Forms.TextBox txtboxSZ;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtboxPX;
        private System.Windows.Forms.TextBox txtboxPY;
        private System.Windows.Forms.TextBox txtboxPZ;
        private System.Windows.Forms.Label lblPX;
        private System.Windows.Forms.Label lblPY;
        private System.Windows.Forms.Label lblPZ;
        private System.Windows.Forms.Label lblRotation;
        private System.Windows.Forms.Label lblRX;
        private System.Windows.Forms.TextBox txtboxRX;
        private System.Windows.Forms.Label lblRY;
        private System.Windows.Forms.TextBox txtboxRY;
        private System.Windows.Forms.Label lblRZ;
        private System.Windows.Forms.TextBox txtboxRZ;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnSetLength;
        private System.Windows.Forms.Button btnSetHeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lbCamX;
        private System.Windows.Forms.Label lbCamPosX;
        private System.Windows.Forms.Label lbCamPosY;
        private System.Windows.Forms.Label lbCamPosZ;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOpenTextureFile;
        private System.Windows.Forms.PictureBox ptboxShowTexture;
        private System.Windows.Forms.Label lblTexture;
        private System.Windows.Forms.Button btnStickTexture;
        private System.Windows.Forms.Button btnRemoveTexture;
        private System.Windows.Forms.TextBox txtboxTexturePath;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveAll;
    }
}

