namespace Password_Generator
{
    partial class PasswordList
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordList));
            this.FormBorders = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblParameters = new System.Windows.Forms.Label();
            this.Separator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblSymb = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblUpp = new System.Windows.Forms.Label();
            this.cbSymbols = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cbNumbers = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cbLowercase = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cbUppercase = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSaveFile = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnGeneratePassword = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtLength = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.Separator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lstPasswords = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // FormBorders
            // 
            this.FormBorders.ElipseRadius = 20;
            this.FormBorders.TargetControl = this;
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.BackColor = System.Drawing.Color.White;
            this.lblParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblParameters.Location = new System.Drawing.Point(33, 20);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(420, 33);
            this.lblParameters.TabIndex = 3;
            this.lblParameters.Text = "Set password list parameters";
            // 
            // Separator1
            // 
            this.Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Separator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Separator1.BackgroundImage")));
            this.Separator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Separator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.Separator1.LineThickness = 3;
            this.Separator1.Location = new System.Drawing.Point(25, 60);
            this.Separator1.Name = "Separator1";
            this.Separator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator1.Size = new System.Drawing.Size(560, 14);
            this.Separator1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Password_Generator.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(574, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSymb
            // 
            this.lblSymb.AutoSize = true;
            this.lblSymb.BackColor = System.Drawing.Color.White;
            this.lblSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSymb.Location = new System.Drawing.Point(30, 288);
            this.lblSymb.Name = "lblSymb";
            this.lblSymb.Size = new System.Drawing.Size(164, 22);
            this.lblSymb.TabIndex = 25;
            this.lblSymb.Text = "Symbols: ( @#$% )";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.White;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblNum.Location = new System.Drawing.Point(30, 252);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(140, 22);
            this.lblNum.TabIndex = 24;
            this.lblNum.Text = "Numbers: ( 0-9 )";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.BackColor = System.Drawing.Color.White;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblLow.Location = new System.Drawing.Point(30, 216);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(153, 22);
            this.lblLow.TabIndex = 23;
            this.lblLow.Text = "Lowercase: ( a-z )";
            // 
            // lblUpp
            // 
            this.lblUpp.AutoSize = true;
            this.lblUpp.BackColor = System.Drawing.Color.White;
            this.lblUpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblUpp.Location = new System.Drawing.Point(30, 180);
            this.lblUpp.Name = "lblUpp";
            this.lblUpp.Size = new System.Drawing.Size(158, 22);
            this.lblUpp.TabIndex = 22;
            this.lblUpp.Text = "Uppercase: ( A-Z )";
            // 
            // cbSymbols
            // 
            this.cbSymbols.AllowBindingControlAnimation = true;
            this.cbSymbols.AllowBindingControlColorChanges = false;
            this.cbSymbols.AllowBindingControlLocation = true;
            this.cbSymbols.AllowCheckBoxAnimation = false;
            this.cbSymbols.AllowCheckmarkAnimation = true;
            this.cbSymbols.AllowOnHoverStates = true;
            this.cbSymbols.AutoCheck = true;
            this.cbSymbols.BackColor = System.Drawing.Color.Transparent;
            this.cbSymbols.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbSymbols.BackgroundImage")));
            this.cbSymbols.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbSymbols.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbSymbols.BorderRadius = 12;
            this.cbSymbols.Checked = true;
            this.cbSymbols.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbSymbols.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSymbols.CustomCheckmarkImage = null;
            this.cbSymbols.Location = new System.Drawing.Point(205, 288);
            this.cbSymbols.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbSymbols.OnCheck.BorderRadius = 12;
            this.cbSymbols.OnCheck.BorderThickness = 2;
            this.cbSymbols.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbSymbols.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbSymbols.OnCheck.CheckmarkThickness = 2;
            this.cbSymbols.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbSymbols.OnDisable.BorderRadius = 12;
            this.cbSymbols.OnDisable.BorderThickness = 2;
            this.cbSymbols.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbSymbols.OnDisable.CheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbSymbols.OnDisable.CheckmarkThickness = 2;
            this.cbSymbols.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbSymbols.OnHoverChecked.BorderRadius = 12;
            this.cbSymbols.OnHoverChecked.BorderThickness = 2;
            this.cbSymbols.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbSymbols.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbSymbols.OnHoverChecked.CheckmarkThickness = 2;
            this.cbSymbols.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbSymbols.OnHoverUnchecked.BorderRadius = 12;
            this.cbSymbols.OnHoverUnchecked.BorderThickness = 1;
            this.cbSymbols.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.White;
            this.cbSymbols.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbSymbols.OnUncheck.BorderRadius = 12;
            this.cbSymbols.OnUncheck.BorderThickness = 1;
            this.cbSymbols.OnUncheck.CheckBoxColor = System.Drawing.Color.White;
            this.cbSymbols.Size = new System.Drawing.Size(23, 23);
            this.cbSymbols.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbSymbols.TabIndex = 21;
            this.cbSymbols.ThreeState = false;
            this.cbSymbols.ToolTipText = null;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AllowBindingControlAnimation = true;
            this.cbNumbers.AllowBindingControlColorChanges = false;
            this.cbNumbers.AllowBindingControlLocation = true;
            this.cbNumbers.AllowCheckBoxAnimation = false;
            this.cbNumbers.AllowCheckmarkAnimation = true;
            this.cbNumbers.AllowOnHoverStates = true;
            this.cbNumbers.AutoCheck = true;
            this.cbNumbers.BackColor = System.Drawing.Color.Transparent;
            this.cbNumbers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbNumbers.BackgroundImage")));
            this.cbNumbers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbNumbers.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbNumbers.BorderRadius = 12;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbNumbers.CustomCheckmarkImage = null;
            this.cbNumbers.Location = new System.Drawing.Point(205, 252);
            this.cbNumbers.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbNumbers.OnCheck.BorderRadius = 12;
            this.cbNumbers.OnCheck.BorderThickness = 2;
            this.cbNumbers.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbNumbers.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbNumbers.OnCheck.CheckmarkThickness = 2;
            this.cbNumbers.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbNumbers.OnDisable.BorderRadius = 12;
            this.cbNumbers.OnDisable.BorderThickness = 2;
            this.cbNumbers.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbNumbers.OnDisable.CheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbNumbers.OnDisable.CheckmarkThickness = 2;
            this.cbNumbers.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbNumbers.OnHoverChecked.BorderRadius = 12;
            this.cbNumbers.OnHoverChecked.BorderThickness = 2;
            this.cbNumbers.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbNumbers.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbNumbers.OnHoverChecked.CheckmarkThickness = 2;
            this.cbNumbers.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbNumbers.OnHoverUnchecked.BorderRadius = 12;
            this.cbNumbers.OnHoverUnchecked.BorderThickness = 1;
            this.cbNumbers.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.White;
            this.cbNumbers.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbNumbers.OnUncheck.BorderRadius = 12;
            this.cbNumbers.OnUncheck.BorderThickness = 1;
            this.cbNumbers.OnUncheck.CheckBoxColor = System.Drawing.Color.White;
            this.cbNumbers.Size = new System.Drawing.Size(23, 23);
            this.cbNumbers.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbNumbers.TabIndex = 20;
            this.cbNumbers.ThreeState = false;
            this.cbNumbers.ToolTipText = null;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AllowBindingControlAnimation = true;
            this.cbLowercase.AllowBindingControlColorChanges = false;
            this.cbLowercase.AllowBindingControlLocation = true;
            this.cbLowercase.AllowCheckBoxAnimation = false;
            this.cbLowercase.AllowCheckmarkAnimation = true;
            this.cbLowercase.AllowOnHoverStates = true;
            this.cbLowercase.AutoCheck = true;
            this.cbLowercase.BackColor = System.Drawing.Color.Transparent;
            this.cbLowercase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbLowercase.BackgroundImage")));
            this.cbLowercase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbLowercase.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbLowercase.BorderRadius = 12;
            this.cbLowercase.Checked = true;
            this.cbLowercase.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbLowercase.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbLowercase.CustomCheckmarkImage = null;
            this.cbLowercase.Location = new System.Drawing.Point(205, 216);
            this.cbLowercase.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbLowercase.OnCheck.BorderRadius = 12;
            this.cbLowercase.OnCheck.BorderThickness = 2;
            this.cbLowercase.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbLowercase.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbLowercase.OnCheck.CheckmarkThickness = 2;
            this.cbLowercase.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbLowercase.OnDisable.BorderRadius = 12;
            this.cbLowercase.OnDisable.BorderThickness = 2;
            this.cbLowercase.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbLowercase.OnDisable.CheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbLowercase.OnDisable.CheckmarkThickness = 2;
            this.cbLowercase.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbLowercase.OnHoverChecked.BorderRadius = 12;
            this.cbLowercase.OnHoverChecked.BorderThickness = 2;
            this.cbLowercase.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbLowercase.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbLowercase.OnHoverChecked.CheckmarkThickness = 2;
            this.cbLowercase.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbLowercase.OnHoverUnchecked.BorderRadius = 12;
            this.cbLowercase.OnHoverUnchecked.BorderThickness = 1;
            this.cbLowercase.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.White;
            this.cbLowercase.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbLowercase.OnUncheck.BorderRadius = 12;
            this.cbLowercase.OnUncheck.BorderThickness = 1;
            this.cbLowercase.OnUncheck.CheckBoxColor = System.Drawing.Color.White;
            this.cbLowercase.Size = new System.Drawing.Size(23, 23);
            this.cbLowercase.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbLowercase.TabIndex = 19;
            this.cbLowercase.ThreeState = false;
            this.cbLowercase.ToolTipText = null;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AllowBindingControlAnimation = true;
            this.cbUppercase.AllowBindingControlColorChanges = false;
            this.cbUppercase.AllowBindingControlLocation = true;
            this.cbUppercase.AllowCheckBoxAnimation = false;
            this.cbUppercase.AllowCheckmarkAnimation = true;
            this.cbUppercase.AllowOnHoverStates = true;
            this.cbUppercase.AutoCheck = true;
            this.cbUppercase.BackColor = System.Drawing.Color.Transparent;
            this.cbUppercase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbUppercase.BackgroundImage")));
            this.cbUppercase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbUppercase.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.cbUppercase.BorderRadius = 12;
            this.cbUppercase.Checked = true;
            this.cbUppercase.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.cbUppercase.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbUppercase.CustomCheckmarkImage = null;
            this.cbUppercase.Location = new System.Drawing.Point(205, 180);
            this.cbUppercase.MinimumSize = new System.Drawing.Size(17, 17);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbUppercase.OnCheck.BorderRadius = 12;
            this.cbUppercase.OnCheck.BorderThickness = 2;
            this.cbUppercase.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.cbUppercase.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.cbUppercase.OnCheck.CheckmarkThickness = 2;
            this.cbUppercase.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbUppercase.OnDisable.BorderRadius = 12;
            this.cbUppercase.OnDisable.BorderThickness = 2;
            this.cbUppercase.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.cbUppercase.OnDisable.CheckmarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.cbUppercase.OnDisable.CheckmarkThickness = 2;
            this.cbUppercase.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbUppercase.OnHoverChecked.BorderRadius = 12;
            this.cbUppercase.OnHoverChecked.BorderThickness = 2;
            this.cbUppercase.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbUppercase.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.cbUppercase.OnHoverChecked.CheckmarkThickness = 2;
            this.cbUppercase.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.cbUppercase.OnHoverUnchecked.BorderRadius = 12;
            this.cbUppercase.OnHoverUnchecked.BorderThickness = 1;
            this.cbUppercase.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.White;
            this.cbUppercase.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.cbUppercase.OnUncheck.BorderRadius = 12;
            this.cbUppercase.OnUncheck.BorderThickness = 1;
            this.cbUppercase.OnUncheck.CheckBoxColor = System.Drawing.Color.White;
            this.cbUppercase.Size = new System.Drawing.Size(23, 23);
            this.cbUppercase.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.cbUppercase.TabIndex = 18;
            this.cbUppercase.ThreeState = false;
            this.cbUppercase.ToolTipText = null;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.White;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblAmount.Location = new System.Drawing.Point(30, 126);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(169, 22);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Amount: ( 1 - 1000 )";
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsReturn = false;
            this.txtAmount.AcceptsTab = false;
            this.txtAmount.AnimationSpeed = 200;
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmount.AutoSizeHeight = true;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtAmount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAmount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtAmount.BorderRadius = 5;
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.White;
            this.txtAmount.HideSelection = true;
            this.txtAmount.IconLeft = null;
            this.txtAmount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.IconPadding = 10;
            this.txtAmount.IconRight = null;
            this.txtAmount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(205, 121);
            this.txtAmount.MaxLength = 4;
            this.txtAmount.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAmount.Modified = false;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAmount.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAmount.OnIdleState = stateProperties8;
            this.txtAmount.Padding = new System.Windows.Forms.Padding(3);
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(70, 35);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 27;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextMarginBottom = 0;
            this.txtAmount.TextMarginLeft = 3;
            this.txtAmount.TextMarginTop = 1;
            this.txtAmount.TextPlaceholder = "";
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.WordWrap = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.AllowAnimations = true;
            this.btnSaveFile.AllowMouseEffects = true;
            this.btnSaveFile.AllowToggling = false;
            this.btnSaveFile.AnimationSpeed = 200;
            this.btnSaveFile.AutoGenerateColors = false;
            this.btnSaveFile.AutoRoundBorders = true;
            this.btnSaveFile.AutoSizeLeftIcon = true;
            this.btnSaveFile.AutoSizeRightIcon = true;
            this.btnSaveFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFile.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnSaveFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.BackgroundImage")));
            this.btnSaveFile.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveFile.ButtonText = "Save as File";
            this.btnSaveFile.ButtonTextMarginLeft = 0;
            this.btnSaveFile.ColorContrastOnClick = 45;
            this.btnSaveFile.ColorContrastOnHover = 45;
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSaveFile.CustomizableEdges = borderEdges1;
            this.btnSaveFile.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveFile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveFile.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSaveFile.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSaveFile.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSaveFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.IconLeft = null;
            this.btnSaveFile.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFile.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveFile.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveFile.IconMarginLeft = 11;
            this.btnSaveFile.IconPadding = 10;
            this.btnSaveFile.IconRight = null;
            this.btnSaveFile.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveFile.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveFile.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveFile.IconSize = 25;
            this.btnSaveFile.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnSaveFile.IdleBorderRadius = 0;
            this.btnSaveFile.IdleBorderThickness = 0;
            this.btnSaveFile.IdleFillColor = System.Drawing.Color.Empty;
            this.btnSaveFile.IdleIconLeftImage = null;
            this.btnSaveFile.IdleIconRightImage = null;
            this.btnSaveFile.IndicateFocus = false;
            this.btnSaveFile.Location = new System.Drawing.Point(135, 340);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveFile.OnDisabledState.BorderRadius = 35;
            this.btnSaveFile.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveFile.OnDisabledState.BorderThickness = 1;
            this.btnSaveFile.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveFile.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveFile.OnDisabledState.IconLeftImage = null;
            this.btnSaveFile.OnDisabledState.IconRightImage = null;
            this.btnSaveFile.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(215)))), ((int)(((byte)(124)))));
            this.btnSaveFile.onHoverState.BorderRadius = 35;
            this.btnSaveFile.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveFile.onHoverState.BorderThickness = 1;
            this.btnSaveFile.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(215)))), ((int)(((byte)(124)))));
            this.btnSaveFile.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.onHoverState.IconLeftImage = null;
            this.btnSaveFile.onHoverState.IconRightImage = null;
            this.btnSaveFile.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnSaveFile.OnIdleState.BorderRadius = 35;
            this.btnSaveFile.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveFile.OnIdleState.BorderThickness = 1;
            this.btnSaveFile.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnSaveFile.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.OnIdleState.IconLeftImage = null;
            this.btnSaveFile.OnIdleState.IconRightImage = null;
            this.btnSaveFile.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnSaveFile.OnPressedState.BorderRadius = 35;
            this.btnSaveFile.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveFile.OnPressedState.BorderThickness = 1;
            this.btnSaveFile.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.btnSaveFile.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.OnPressedState.IconLeftImage = null;
            this.btnSaveFile.OnPressedState.IconRightImage = null;
            this.btnSaveFile.Size = new System.Drawing.Size(130, 35);
            this.btnSaveFile.TabIndex = 29;
            this.btnSaveFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveFile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveFile.TextMarginLeft = 0;
            this.btnSaveFile.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSaveFile.UseDefaultRadiusAndThickness = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.AllowAnimations = true;
            this.btnGeneratePassword.AllowMouseEffects = true;
            this.btnGeneratePassword.AllowToggling = false;
            this.btnGeneratePassword.AnimationSpeed = 200;
            this.btnGeneratePassword.AutoGenerateColors = false;
            this.btnGeneratePassword.AutoRoundBorders = true;
            this.btnGeneratePassword.AutoSizeLeftIcon = true;
            this.btnGeneratePassword.AutoSizeRightIcon = true;
            this.btnGeneratePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneratePassword.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnGeneratePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeneratePassword.BackgroundImage")));
            this.btnGeneratePassword.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.ButtonText = "Generate";
            this.btnGeneratePassword.ButtonTextMarginLeft = 0;
            this.btnGeneratePassword.ColorContrastOnClick = 45;
            this.btnGeneratePassword.ColorContrastOnHover = 45;
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnGeneratePassword.CustomizableEdges = borderEdges2;
            this.btnGeneratePassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGeneratePassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGeneratePassword.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.IconLeft = null;
            this.btnGeneratePassword.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneratePassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGeneratePassword.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGeneratePassword.IconMarginLeft = 11;
            this.btnGeneratePassword.IconPadding = 10;
            this.btnGeneratePassword.IconRight = null;
            this.btnGeneratePassword.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGeneratePassword.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGeneratePassword.IconSize = 25;
            this.btnGeneratePassword.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.IdleBorderRadius = 0;
            this.btnGeneratePassword.IdleBorderThickness = 0;
            this.btnGeneratePassword.IdleFillColor = System.Drawing.Color.Empty;
            this.btnGeneratePassword.IdleIconLeftImage = null;
            this.btnGeneratePassword.IdleIconRightImage = null;
            this.btnGeneratePassword.IndicateFocus = false;
            this.btnGeneratePassword.Location = new System.Drawing.Point(25, 340);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGeneratePassword.OnDisabledState.BorderRadius = 35;
            this.btnGeneratePassword.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.OnDisabledState.BorderThickness = 1;
            this.btnGeneratePassword.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGeneratePassword.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGeneratePassword.OnDisabledState.IconLeftImage = null;
            this.btnGeneratePassword.OnDisabledState.IconRightImage = null;
            this.btnGeneratePassword.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.btnGeneratePassword.onHoverState.BorderRadius = 35;
            this.btnGeneratePassword.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.onHoverState.BorderThickness = 1;
            this.btnGeneratePassword.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.btnGeneratePassword.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.onHoverState.IconLeftImage = null;
            this.btnGeneratePassword.onHoverState.IconRightImage = null;
            this.btnGeneratePassword.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGeneratePassword.OnIdleState.BorderRadius = 35;
            this.btnGeneratePassword.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.OnIdleState.BorderThickness = 1;
            this.btnGeneratePassword.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGeneratePassword.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.OnIdleState.IconLeftImage = null;
            this.btnGeneratePassword.OnIdleState.IconRightImage = null;
            this.btnGeneratePassword.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGeneratePassword.OnPressedState.BorderRadius = 35;
            this.btnGeneratePassword.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnGeneratePassword.OnPressedState.BorderThickness = 1;
            this.btnGeneratePassword.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnGeneratePassword.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.OnPressedState.IconLeftImage = null;
            this.btnGeneratePassword.OnPressedState.IconRightImage = null;
            this.btnGeneratePassword.Size = new System.Drawing.Size(100, 35);
            this.btnGeneratePassword.TabIndex = 28;
            this.btnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGeneratePassword.TextMarginLeft = 0;
            this.btnGeneratePassword.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGeneratePassword.UseDefaultRadiusAndThickness = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // txtLength
            // 
            this.txtLength.AcceptsReturn = false;
            this.txtLength.AcceptsTab = false;
            this.txtLength.AnimationSpeed = 200;
            this.txtLength.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLength.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLength.AutoSizeHeight = true;
            this.txtLength.BackColor = System.Drawing.Color.Transparent;
            this.txtLength.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLength.BackgroundImage")));
            this.txtLength.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtLength.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLength.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtLength.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtLength.BorderRadius = 5;
            this.txtLength.BorderThickness = 2;
            this.txtLength.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLength.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.DefaultText = "";
            this.txtLength.FillColor = System.Drawing.Color.White;
            this.txtLength.HideSelection = true;
            this.txtLength.IconLeft = null;
            this.txtLength.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLength.IconPadding = 10;
            this.txtLength.IconRight = null;
            this.txtLength.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLength.Lines = new string[0];
            this.txtLength.Location = new System.Drawing.Point(205, 80);
            this.txtLength.MaxLength = 4;
            this.txtLength.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLength.Modified = false;
            this.txtLength.Multiline = false;
            this.txtLength.Name = "txtLength";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLength.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLength.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLength.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtLength.OnIdleState = stateProperties4;
            this.txtLength.Padding = new System.Windows.Forms.Padding(3);
            this.txtLength.PasswordChar = '\0';
            this.txtLength.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLength.PlaceholderText = "";
            this.txtLength.ReadOnly = false;
            this.txtLength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLength.SelectedText = "";
            this.txtLength.SelectionLength = 0;
            this.txtLength.SelectionStart = 0;
            this.txtLength.ShortcutsEnabled = true;
            this.txtLength.Size = new System.Drawing.Size(70, 35);
            this.txtLength.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtLength.TabIndex = 32;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLength.TextMarginBottom = 0;
            this.txtLength.TextMarginLeft = 3;
            this.txtLength.TextMarginTop = 1;
            this.txtLength.TextPlaceholder = "";
            this.txtLength.UseSystemPasswordChar = false;
            this.txtLength.WordWrap = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.White;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblLength.Location = new System.Drawing.Point(30, 85);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(143, 22);
            this.lblLength.TabIndex = 31;
            this.lblLength.Text = "Length: ( 1-100 )";
            // 
            // Separator2
            // 
            this.Separator2.BackColor = System.Drawing.Color.Transparent;
            this.Separator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Separator2.BackgroundImage")));
            this.Separator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Separator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.Separator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.Separator2.LineThickness = 3;
            this.Separator2.Location = new System.Drawing.Point(25, 160);
            this.Separator2.Name = "Separator2";
            this.Separator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator2.Size = new System.Drawing.Size(260, 14);
            this.Separator2.TabIndex = 33;
            // 
            // lstPasswords
            // 
            this.lstPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPasswords.FormattingEnabled = true;
            this.lstPasswords.ItemHeight = 24;
            this.lstPasswords.Location = new System.Drawing.Point(300, 82);
            this.lstPasswords.Name = "lstPasswords";
            this.lstPasswords.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPasswords.Size = new System.Drawing.Size(280, 292);
            this.lstPasswords.TabIndex = 34;
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 395);
            this.Controls.Add(this.lstPasswords);
            this.Controls.Add(this.Separator2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblSymb);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblUpp);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.cbNumbers);
            this.Controls.Add(this.cbLowercase);
            this.Controls.Add(this.cbUppercase);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Separator1);
            this.Controls.Add(this.lblParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password List";
            this.Load += new System.EventHandler(this.PasswordList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormBorders;
        private System.Windows.Forms.Label lblParameters;
        private Bunifu.UI.WinForms.BunifuSeparator Separator1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSymb;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblUpp;
        private Bunifu.UI.WinForms.BunifuCheckBox cbSymbols;
        private Bunifu.UI.WinForms.BunifuCheckBox cbNumbers;
        private Bunifu.UI.WinForms.BunifuCheckBox cbLowercase;
        private Bunifu.UI.WinForms.BunifuCheckBox cbUppercase;
        private Bunifu.UI.WinForms.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveFile;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGeneratePassword;
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private Bunifu.UI.WinForms.BunifuTextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private Bunifu.UI.WinForms.BunifuSeparator Separator2;
        private System.Windows.Forms.ListBox lstPasswords;
    }
}