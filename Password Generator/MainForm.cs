using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
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

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = generatePassword.Generate(int.Parse(txtPasswordLength.Text),
                                                             cbUppercase, cbLowercase, cbNumbers, cbSymbols);

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

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
