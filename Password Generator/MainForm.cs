using Password_Generator.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class MainForm : Form
    {

        GeneratePassword generatePassword = new GeneratePassword();

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Password;
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Theme == true)
            {
                DarkTheme();
                btnTheme.Checked = true;
            }
            else if (Settings.Default.Theme == false)
            {
                LightTheme();
                btnTheme.Checked = false;
            }

            txtPasswordLength.Text = "10";
            sliderPasswordLength.Value = 10;

            txtPassword.Text = generatePassword.Generate(int.Parse(txtPasswordLength.Text),
                                                             cbUppercase, cbLowercase, cbNumbers, cbSymbols);

            pbPasswordComplexity.TransitionValue(85, 1000);
            pbPasswordComplexity.ProgressColorLeft = Color.FromArgb(0, 168, 120);
            pbPasswordComplexity.ProgressColorRight = Color.FromArgb(0, 168, 120);


            cbUppercase.Checked = true;
            cbLowercase.Checked = true;
            cbNumbers.Checked = true;
            cbSymbols.Checked = true;
        }

        private void SliderState()
        {
            try
            {
                sliderPasswordLength.Value = int.Parse(txtPasswordLength.Text);

                if (int.Parse(txtPasswordLength.Text) < 7)
                {
                    //pbPasswordComplexity.Value = 30;
                    pbPasswordComplexity.TransitionValue(30, 1000);
                    pbPasswordComplexity.ProgressColorLeft = Color.FromArgb(194, 30, 30);
                    pbPasswordComplexity.ProgressColorRight = Color.FromArgb(194, 30, 30);
                }
                else if (int.Parse(txtPasswordLength.Text) > 7 && int.Parse(txtPasswordLength.Text) < 9)
                {
                    //pbPasswordComplexity.Value = 50;
                    pbPasswordComplexity.TransitionValue(50, 1000);
                    pbPasswordComplexity.ProgressColorLeft = Color.FromArgb(239, 194, 15);
                    pbPasswordComplexity.ProgressColorRight = Color.FromArgb(239, 194, 15);
                }
                else if (int.Parse(txtPasswordLength.Text) > 9 && int.Parse(txtPasswordLength.Text) < 12)
                {
                    //pbPasswordComplexity.Value = 85;
                    pbPasswordComplexity.TransitionValue(85, 1000);
                    pbPasswordComplexity.ProgressColorLeft = Color.FromArgb(0, 168, 120);
                    pbPasswordComplexity.ProgressColorRight = Color.FromArgb(0, 168, 120);
                }
                else if (int.Parse(txtPasswordLength.Text) > 12)
                {
                    //pbPasswordComplexity.Value = 100;
                    pbPasswordComplexity.TransitionValue(100, 1000);
                    pbPasswordComplexity.ProgressColorLeft = Color.FromArgb(0, 107, 77);
                    pbPasswordComplexity.ProgressColorRight = Color.FromArgb(0, 107, 77);
                }
            }
            catch
            {

            }
        }

        private void DarkTheme()
        {
            Settings.Default.Theme = true;
            Settings.Default.Save();

            this.BackColor = Color.FromArgb(33, 33, 33);

            btnClose.Image = Resources.Close_W;

            TopPanel.BackgroundColor = Color.FromArgb(33, 33, 33);

            ContentPanel.BackgroundColor = Color.FromArgb(33, 33, 33);

            pbPasswordComplexity.BackColor = Color.White;
            pbPasswordComplexity.BorderColor = Color.FromArgb(33, 33, 33);

            sliderPasswordLength.SliderColor = Color.White;

            txtPassword.BackColor = Color.FromArgb(33, 33, 33);
            txtPassword.ForeColor = Color.White;

            btnClose.BackColor = Color.FromArgb(33, 33, 33);

            Separator1.LineColor = Color.White;
            Separator2.LineColor = Color.White;

            lblParameters.BackColor = Color.FromArgb(33, 33, 33);
            lblParameters.ForeColor = Color.White;

            lblTheme.BackColor = Color.FromArgb(33, 33, 33);
            lblTheme.ForeColor = Color.White;

            lblLength.BackColor = Color.FromArgb(33, 33, 33);
            lblLength.ForeColor = Color.White;

            lblUpp.BackColor = Color.FromArgb(33, 33, 33);
            lblUpp.ForeColor = Color.White;

            lblLow.BackColor = Color.FromArgb(33, 33, 33);
            lblLow.ForeColor = Color.White;

            lblNum.BackColor = Color.FromArgb(33, 33, 33);
            lblNum.ForeColor = Color.White;

            lblSymb.BackColor = Color.FromArgb(33, 33, 33);
            lblSymb.ForeColor = Color.White;

            lblTheme.Text = "Dark";
        }

        private void LightTheme()
        {
            Settings.Default.Theme = false;
            Settings.Default.Save();

            this.BackColor = Color.White;

            btnClose.Image = Resources.Close;

            TopPanel.BackgroundColor = Color.White;

            ContentPanel.BackgroundColor = Color.White;

            pbPasswordComplexity.BackColor = Color.FromArgb(210, 210, 210);
            pbPasswordComplexity.BorderColor = Color.FromArgb(210, 210, 210);

            sliderPasswordLength.SliderColor = Color.FromArgb(210, 210, 210);

            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;

            btnClose.BackColor = Color.White;

            Separator1.LineColor = Color.FromArgb(210, 210, 210);
            Separator2.LineColor = Color.FromArgb(210, 210, 210);

            lblParameters.BackColor = Color.White;
            lblParameters.ForeColor = Color.Black;

            lblTheme.BackColor = Color.White;
            lblTheme.ForeColor = Color.Black;

            lblLength.BackColor = Color.White;
            lblLength.ForeColor = Color.Black;

            lblUpp.BackColor = Color.White;
            lblUpp.ForeColor = Color.Black;

            lblLow.BackColor = Color.White;
            lblLow.ForeColor = Color.Black;

            lblNum.BackColor = Color.White;
            lblNum.ForeColor = Color.Black;

            lblSymb.BackColor = Color.White;
            lblSymb.ForeColor = Color.Black;

            lblTheme.Text = "Light";
        }

        private void ChangeTheme()
        {
            if (btnTheme.Checked == true)
            {
                DarkTheme();
            }

            if (btnTheme.Checked == false)
            {
                LightTheme();
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int Length;

                int maxLength = 100;

                if (int.Parse(txtPasswordLength.Text) > maxLength)
                {
                    Length = maxLength;

                    txtPasswordLength.Text = "100";
                }

                else 
                {
                    Length = int.Parse(txtPasswordLength.Text);
                }

                txtPassword.Text = generatePassword.Generate(Length, cbUppercase, cbLowercase, 
                                                             cbNumbers, cbSymbols);

                SliderState();
            }
            catch
            {

            }
        }

        private void sliderPasswordLength_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            txtPasswordLength.Text = sliderPasswordLength.Value.ToString();
            SliderState();
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTheme_CheckedChanged(object sender, EventArgs e)
        {
            ChangeTheme();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            new PasswordList().Show();
        }
    }
}
