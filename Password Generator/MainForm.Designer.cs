
namespace Password_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.FormBorders = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TopPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pbPasswordComplexity = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.ContentPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTheme = new System.Windows.Forms.Label();
            this.btnTheme = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.btnList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Separator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblSymb = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblUpp = new System.Windows.Forms.Label();
            this.cbSymbols = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cbNumbers = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cbLowercase = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.cbUppercase = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.btnCopyPassword = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnGeneratePassword = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sliderPasswordLength = new Bunifu.UI.WinForms.BunifuHSlider();
            this.txtPasswordLength = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.Separator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblParameters = new System.Windows.Forms.Label();
            this.TopPanelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ContentPanelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorders
            // 
            this.FormBorders.ElipseRadius = 20;
            this.FormBorders.TargetControl = this;
            // 
            // TopPanel
            // 
            this.TopPanel.BackgroundColor = System.Drawing.Color.White;
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopPanel.BorderColor = System.Drawing.Color.White;
            this.TopPanel.BorderRadius = 3;
            this.TopPanel.BorderThickness = 1;
            this.TopPanel.Controls.Add(this.txtPassword);
            this.TopPanel.Controls.Add(this.btnClose);
            this.TopPanel.Controls.Add(this.pbPasswordComplexity);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShowBorders = false;
            this.TopPanel.Size = new System.Drawing.Size(755, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(20, 24);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(660, 42);
            this.txtPassword.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Password_Generator.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(719, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pbPasswordComplexity
            // 
            this.pbPasswordComplexity.AllowAnimations = false;
            this.pbPasswordComplexity.Animation = 0;
            this.pbPasswordComplexity.AnimationSpeed = 220;
            this.pbPasswordComplexity.AnimationStep = 10;
            this.pbPasswordComplexity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pbPasswordComplexity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPasswordComplexity.BackgroundImage")));
            this.pbPasswordComplexity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pbPasswordComplexity.BorderRadius = 9;
            this.pbPasswordComplexity.BorderThickness = 1;
            this.pbPasswordComplexity.Location = new System.Drawing.Point(0, 84);
            this.pbPasswordComplexity.Maximum = 100;
            this.pbPasswordComplexity.MaximumValue = 100;
            this.pbPasswordComplexity.Minimum = 0;
            this.pbPasswordComplexity.MinimumValue = 0;
            this.pbPasswordComplexity.Name = "pbPasswordComplexity";
            this.pbPasswordComplexity.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pbPasswordComplexity.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pbPasswordComplexity.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.pbPasswordComplexity.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.pbPasswordComplexity.Size = new System.Drawing.Size(755, 15);
            this.pbPasswordComplexity.TabIndex = 0;
            this.pbPasswordComplexity.Value = 50;
            this.pbPasswordComplexity.ValueByTransition = 50;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundColor = System.Drawing.Color.White;
            this.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContentPanel.BackgroundImage")));
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.BorderColor = System.Drawing.Color.White;
            this.ContentPanel.BorderRadius = 3;
            this.ContentPanel.BorderThickness = 1;
            this.ContentPanel.Controls.Add(this.lblTheme);
            this.ContentPanel.Controls.Add(this.btnTheme);
            this.ContentPanel.Controls.Add(this.btnList);
            this.ContentPanel.Controls.Add(this.Separator2);
            this.ContentPanel.Controls.Add(this.lblSymb);
            this.ContentPanel.Controls.Add(this.lblNum);
            this.ContentPanel.Controls.Add(this.lblLow);
            this.ContentPanel.Controls.Add(this.lblUpp);
            this.ContentPanel.Controls.Add(this.cbSymbols);
            this.ContentPanel.Controls.Add(this.cbNumbers);
            this.ContentPanel.Controls.Add(this.cbLowercase);
            this.ContentPanel.Controls.Add(this.cbUppercase);
            this.ContentPanel.Controls.Add(this.btnCopyPassword);
            this.ContentPanel.Controls.Add(this.btnGeneratePassword);
            this.ContentPanel.Controls.Add(this.sliderPasswordLength);
            this.ContentPanel.Controls.Add(this.txtPasswordLength);
            this.ContentPanel.Controls.Add(this.lblLength);
            this.ContentPanel.Controls.Add(this.Separator1);
            this.ContentPanel.Controls.Add(this.lblParameters);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentPanel.Location = new System.Drawing.Point(0, 100);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.ShowBorders = false;
            this.ContentPanel.Size = new System.Drawing.Size(755, 240);
            this.ContentPanel.TabIndex = 1;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.White;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.Location = new System.Drawing.Point(685, 42);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(39, 18);
            this.lblTheme.TabIndex = 23;
            this.lblTheme.Text = "Light";
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnTheme.Checked = false;
            this.btnTheme.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnTheme.CheckedSwitchColor = System.Drawing.Color.White;
            this.btnTheme.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.btnTheme.Location = new System.Drawing.Point(674, 14);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.OutlineThickness = 2;
            this.btnTheme.Size = new System.Drawing.Size(60, 25);
            this.btnTheme.TabIndex = 22;
            this.btnTheme.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnTheme.UncheckedSwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTheme.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.btnTheme.CheckedChanged += new System.EventHandler(this.btnTheme_CheckedChanged);
            // 
            // btnList
            // 
            this.btnList.AllowAnimations = true;
            this.btnList.AllowMouseEffects = true;
            this.btnList.AllowToggling = false;
            this.btnList.AnimationSpeed = 200;
            this.btnList.AutoGenerateColors = false;
            this.btnList.AutoRoundBorders = true;
            this.btnList.AutoSizeLeftIcon = true;
            this.btnList.AutoSizeRightIcon = true;
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnList.BackgroundImage")));
            this.btnList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.ButtonText = "List";
            this.btnList.ButtonTextMarginLeft = 0;
            this.btnList.ColorContrastOnClick = 45;
            this.btnList.ColorContrastOnHover = 45;
            this.btnList.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnList.CustomizableEdges = borderEdges1;
            this.btnList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnList.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnList.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.IconLeft = null;
            this.btnList.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnList.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnList.IconMarginLeft = 11;
            this.btnList.IconPadding = 10;
            this.btnList.IconRight = null;
            this.btnList.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnList.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnList.IconSize = 25;
            this.btnList.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnList.IdleBorderRadius = 0;
            this.btnList.IdleBorderThickness = 0;
            this.btnList.IdleFillColor = System.Drawing.Color.Empty;
            this.btnList.IdleIconLeftImage = null;
            this.btnList.IdleIconRightImage = null;
            this.btnList.IndicateFocus = false;
            this.btnList.Location = new System.Drawing.Point(259, 190);
            this.btnList.Name = "btnList";
            this.btnList.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnList.OnDisabledState.BorderRadius = 35;
            this.btnList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.OnDisabledState.BorderThickness = 1;
            this.btnList.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnList.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnList.OnDisabledState.IconLeftImage = null;
            this.btnList.OnDisabledState.IconRightImage = null;
            this.btnList.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(170)))), ((int)(((byte)(247)))));
            this.btnList.onHoverState.BorderRadius = 35;
            this.btnList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.onHoverState.BorderThickness = 1;
            this.btnList.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(170)))), ((int)(((byte)(247)))));
            this.btnList.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnList.onHoverState.IconLeftImage = null;
            this.btnList.onHoverState.IconRightImage = null;
            this.btnList.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.btnList.OnIdleState.BorderRadius = 35;
            this.btnList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.OnIdleState.BorderThickness = 1;
            this.btnList.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.btnList.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnList.OnIdleState.IconLeftImage = null;
            this.btnList.OnIdleState.IconRightImage = null;
            this.btnList.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.btnList.OnPressedState.BorderRadius = 35;
            this.btnList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnList.OnPressedState.BorderThickness = 1;
            this.btnList.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(229)))));
            this.btnList.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnList.OnPressedState.IconLeftImage = null;
            this.btnList.OnPressedState.IconRightImage = null;
            this.btnList.Size = new System.Drawing.Size(100, 35);
            this.btnList.TabIndex = 19;
            this.btnList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnList.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnList.TextMarginLeft = 0;
            this.btnList.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnList.UseDefaultRadiusAndThickness = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
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
            this.Separator2.Location = new System.Drawing.Point(240, 188);
            this.Separator2.Name = "Separator2";
            this.Separator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.Separator2.Size = new System.Drawing.Size(14, 40);
            this.Separator2.TabIndex = 18;
            // 
            // lblSymb
            // 
            this.lblSymb.AutoSize = true;
            this.lblSymb.BackColor = System.Drawing.Color.White;
            this.lblSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblSymb.Location = new System.Drawing.Point(570, 203);
            this.lblSymb.Name = "lblSymb";
            this.lblSymb.Size = new System.Drawing.Size(164, 22);
            this.lblSymb.TabIndex = 17;
            this.lblSymb.Text = "Symbols: ( @#$% )";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.White;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblNum.Location = new System.Drawing.Point(570, 167);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(140, 22);
            this.lblNum.TabIndex = 16;
            this.lblNum.Text = "Numbers: ( 0-9 )";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.BackColor = System.Drawing.Color.White;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblLow.Location = new System.Drawing.Point(570, 131);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(153, 22);
            this.lblLow.TabIndex = 15;
            this.lblLow.Text = "Lowercase: ( a-z )";
            // 
            // lblUpp
            // 
            this.lblUpp.AutoSize = true;
            this.lblUpp.BackColor = System.Drawing.Color.White;
            this.lblUpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lblUpp.Location = new System.Drawing.Point(570, 95);
            this.lblUpp.Name = "lblUpp";
            this.lblUpp.Size = new System.Drawing.Size(158, 22);
            this.lblUpp.TabIndex = 14;
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
            this.cbSymbols.Location = new System.Drawing.Point(533, 203);
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
            this.cbSymbols.TabIndex = 13;
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
            this.cbNumbers.Location = new System.Drawing.Point(533, 167);
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
            this.cbNumbers.TabIndex = 12;
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
            this.cbLowercase.Location = new System.Drawing.Point(533, 131);
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
            this.cbLowercase.TabIndex = 11;
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
            this.cbUppercase.Location = new System.Drawing.Point(533, 95);
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
            this.cbUppercase.TabIndex = 10;
            this.cbUppercase.ThreeState = false;
            this.cbUppercase.ToolTipText = null;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.AllowAnimations = true;
            this.btnCopyPassword.AllowMouseEffects = true;
            this.btnCopyPassword.AllowToggling = false;
            this.btnCopyPassword.AnimationSpeed = 200;
            this.btnCopyPassword.AutoGenerateColors = false;
            this.btnCopyPassword.AutoRoundBorders = true;
            this.btnCopyPassword.AutoSizeLeftIcon = true;
            this.btnCopyPassword.AutoSizeRightIcon = true;
            this.btnCopyPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyPassword.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnCopyPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyPassword.BackgroundImage")));
            this.btnCopyPassword.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCopyPassword.ButtonText = "Copy";
            this.btnCopyPassword.ButtonTextMarginLeft = 0;
            this.btnCopyPassword.ColorContrastOnClick = 45;
            this.btnCopyPassword.ColorContrastOnHover = 45;
            this.btnCopyPassword.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCopyPassword.CustomizableEdges = borderEdges2;
            this.btnCopyPassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCopyPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCopyPassword.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCopyPassword.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCopyPassword.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCopyPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPassword.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.IconLeft = null;
            this.btnCopyPassword.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyPassword.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCopyPassword.IconMarginLeft = 11;
            this.btnCopyPassword.IconPadding = 10;
            this.btnCopyPassword.IconRight = null;
            this.btnCopyPassword.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyPassword.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCopyPassword.IconSize = 25;
            this.btnCopyPassword.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnCopyPassword.IdleBorderRadius = 0;
            this.btnCopyPassword.IdleBorderThickness = 0;
            this.btnCopyPassword.IdleFillColor = System.Drawing.Color.Empty;
            this.btnCopyPassword.IdleIconLeftImage = null;
            this.btnCopyPassword.IdleIconRightImage = null;
            this.btnCopyPassword.IndicateFocus = false;
            this.btnCopyPassword.Location = new System.Drawing.Point(135, 190);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCopyPassword.OnDisabledState.BorderRadius = 35;
            this.btnCopyPassword.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCopyPassword.OnDisabledState.BorderThickness = 1;
            this.btnCopyPassword.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCopyPassword.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCopyPassword.OnDisabledState.IconLeftImage = null;
            this.btnCopyPassword.OnDisabledState.IconRightImage = null;
            this.btnCopyPassword.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.btnCopyPassword.onHoverState.BorderRadius = 35;
            this.btnCopyPassword.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCopyPassword.onHoverState.BorderThickness = 1;
            this.btnCopyPassword.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.btnCopyPassword.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.onHoverState.IconLeftImage = null;
            this.btnCopyPassword.onHoverState.IconRightImage = null;
            this.btnCopyPassword.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCopyPassword.OnIdleState.BorderRadius = 35;
            this.btnCopyPassword.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCopyPassword.OnIdleState.BorderThickness = 1;
            this.btnCopyPassword.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCopyPassword.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.OnIdleState.IconLeftImage = null;
            this.btnCopyPassword.OnIdleState.IconRightImage = null;
            this.btnCopyPassword.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCopyPassword.OnPressedState.BorderRadius = 35;
            this.btnCopyPassword.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCopyPassword.OnPressedState.BorderThickness = 1;
            this.btnCopyPassword.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCopyPassword.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.OnPressedState.IconLeftImage = null;
            this.btnCopyPassword.OnPressedState.IconRightImage = null;
            this.btnCopyPassword.Size = new System.Drawing.Size(100, 35);
            this.btnCopyPassword.TabIndex = 2;
            this.btnCopyPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopyPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCopyPassword.TextMarginLeft = 0;
            this.btnCopyPassword.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCopyPassword.UseDefaultRadiusAndThickness = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnGeneratePassword.CustomizableEdges = borderEdges3;
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
            this.btnGeneratePassword.Location = new System.Drawing.Point(25, 190);
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
            this.btnGeneratePassword.TabIndex = 1;
            this.btnGeneratePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeneratePassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGeneratePassword.TextMarginLeft = 0;
            this.btnGeneratePassword.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGeneratePassword.UseDefaultRadiusAndThickness = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // sliderPasswordLength
            // 
            this.sliderPasswordLength.AllowCursorChanges = true;
            this.sliderPasswordLength.AllowHomeEndKeysDetection = false;
            this.sliderPasswordLength.AllowIncrementalClickMoves = true;
            this.sliderPasswordLength.AllowMouseDownEffects = false;
            this.sliderPasswordLength.AllowMouseHoverEffects = false;
            this.sliderPasswordLength.AllowScrollingAnimations = true;
            this.sliderPasswordLength.AllowScrollKeysDetection = true;
            this.sliderPasswordLength.AllowScrollOptionsMenu = true;
            this.sliderPasswordLength.AllowShrinkingOnFocusLost = false;
            this.sliderPasswordLength.BackColor = System.Drawing.Color.Transparent;
            this.sliderPasswordLength.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderPasswordLength.BackgroundImage")));
            this.sliderPasswordLength.BindingContainer = null;
            this.sliderPasswordLength.BorderRadius = 2;
            this.sliderPasswordLength.BorderThickness = 1;
            this.sliderPasswordLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderPasswordLength.DrawThickBorder = true;
            this.sliderPasswordLength.DurationBeforeShrink = 2000;
            this.sliderPasswordLength.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sliderPasswordLength.LargeChange = 10;
            this.sliderPasswordLength.Location = new System.Drawing.Point(115, 123);
            this.sliderPasswordLength.Maximum = 100;
            this.sliderPasswordLength.Minimum = 1;
            this.sliderPasswordLength.MinimumSize = new System.Drawing.Size(0, 31);
            this.sliderPasswordLength.MinimumThumbLength = 18;
            this.sliderPasswordLength.Name = "sliderPasswordLength";
            this.sliderPasswordLength.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderPasswordLength.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderPasswordLength.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderPasswordLength.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.sliderPasswordLength.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.sliderPasswordLength.ShrinkSizeLimit = 3;
            this.sliderPasswordLength.Size = new System.Drawing.Size(370, 31);
            this.sliderPasswordLength.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.sliderPasswordLength.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.sliderPasswordLength.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderPasswordLength.SmallChange = 1;
            this.sliderPasswordLength.TabIndex = 7;
            this.sliderPasswordLength.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sliderPasswordLength.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.sliderPasswordLength.ThumbLength = 37;
            this.sliderPasswordLength.ThumbMargin = 1;
            this.sliderPasswordLength.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Large;
            this.sliderPasswordLength.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.sliderPasswordLength.Value = 10;
            this.sliderPasswordLength.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.sliderPasswordLength_Scroll);
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.AcceptsReturn = false;
            this.txtPasswordLength.AcceptsTab = false;
            this.txtPasswordLength.AnimationSpeed = 200;
            this.txtPasswordLength.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPasswordLength.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPasswordLength.AutoSizeHeight = true;
            this.txtPasswordLength.BackColor = System.Drawing.Color.Transparent;
            this.txtPasswordLength.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPasswordLength.BackgroundImage")));
            this.txtPasswordLength.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtPasswordLength.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPasswordLength.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtPasswordLength.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtPasswordLength.BorderRadius = 5;
            this.txtPasswordLength.BorderThickness = 2;
            this.txtPasswordLength.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPasswordLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLength.DefaultFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLength.DefaultText = "";
            this.txtPasswordLength.FillColor = System.Drawing.Color.White;
            this.txtPasswordLength.HideSelection = true;
            this.txtPasswordLength.IconLeft = null;
            this.txtPasswordLength.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLength.IconPadding = 10;
            this.txtPasswordLength.IconRight = null;
            this.txtPasswordLength.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLength.Lines = new string[0];
            this.txtPasswordLength.Location = new System.Drawing.Point(25, 118);
            this.txtPasswordLength.MaxLength = 4;
            this.txtPasswordLength.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPasswordLength.Modified = false;
            this.txtPasswordLength.Multiline = false;
            this.txtPasswordLength.Name = "txtPasswordLength";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPasswordLength.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPasswordLength.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPasswordLength.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPasswordLength.OnIdleState = stateProperties4;
            this.txtPasswordLength.Padding = new System.Windows.Forms.Padding(3);
            this.txtPasswordLength.PasswordChar = '\0';
            this.txtPasswordLength.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPasswordLength.PlaceholderText = "";
            this.txtPasswordLength.ReadOnly = false;
            this.txtPasswordLength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordLength.SelectedText = "";
            this.txtPasswordLength.SelectionLength = 0;
            this.txtPasswordLength.SelectionStart = 0;
            this.txtPasswordLength.ShortcutsEnabled = true;
            this.txtPasswordLength.Size = new System.Drawing.Size(70, 45);
            this.txtPasswordLength.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPasswordLength.TabIndex = 6;
            this.txtPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordLength.TextMarginBottom = 0;
            this.txtPasswordLength.TextMarginLeft = 3;
            this.txtPasswordLength.TextMarginTop = 1;
            this.txtPasswordLength.TextPlaceholder = "";
            this.txtPasswordLength.UseSystemPasswordChar = false;
            this.txtPasswordLength.WordWrap = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.White;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(28, 88);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 24);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length";
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
            this.Separator1.Location = new System.Drawing.Point(17, 65);
            this.Separator1.Name = "Separator1";
            this.Separator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.Separator1.Size = new System.Drawing.Size(720, 14);
            this.Separator1.TabIndex = 3;
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.BackColor = System.Drawing.Color.White;
            this.lblParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblParameters.Location = new System.Drawing.Point(25, 17);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(370, 33);
            this.lblParameters.TabIndex = 2;
            this.lblParameters.Text = "Set password parameters";
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.Fixed = true;
            this.TopPanelDragControl.Horizontal = true;
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            this.TopPanelDragControl.Vertical = true;
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // ContentPanelDragControl
            // 
            this.ContentPanelDragControl.Fixed = true;
            this.ContentPanelDragControl.Horizontal = true;
            this.ContentPanelDragControl.TargetControl = this.ContentPanel;
            this.ContentPanelDragControl.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 340);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormBorders;
        private Bunifu.UI.WinForms.BunifuPanel TopPanel;
        private Bunifu.UI.WinForms.BunifuPanel ContentPanel;
        private System.Windows.Forms.Label lblSymb;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblUpp;
        private Bunifu.UI.WinForms.BunifuCheckBox cbSymbols;
        private Bunifu.UI.WinForms.BunifuCheckBox cbNumbers;
        private Bunifu.UI.WinForms.BunifuCheckBox cbLowercase;
        private Bunifu.UI.WinForms.BunifuCheckBox cbUppercase;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCopyPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnGeneratePassword;
        private Bunifu.UI.WinForms.BunifuHSlider sliderPasswordLength;
        private Bunifu.UI.WinForms.BunifuTextBox txtPasswordLength;
        private System.Windows.Forms.Label lblLength;
        private Bunifu.UI.WinForms.BunifuSeparator Separator1;
        private System.Windows.Forms.Label lblParameters;
        private Bunifu.UI.WinForms.BunifuProgressBar pbPasswordComplexity;
        private Bunifu.Framework.UI.BunifuDragControl TopPanelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private Bunifu.Framework.UI.BunifuDragControl ContentPanelDragControl;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnList;
        private Bunifu.UI.WinForms.BunifuSeparator Separator2;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 btnTheme;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

