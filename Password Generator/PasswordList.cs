using Password_Generator.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class PasswordList : Form
    {
        GeneratePassword generatePassword = new GeneratePassword();

        public PasswordList()
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

        private void PasswordList_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Theme == true)
            {
                DarkTheme();
            }
            else if (Settings.Default.Theme == false)
            {
                LightTheme();
            }
        }

        private void DarkTheme()
        {
            this.BackColor = Color.FromArgb(33, 33, 33);

            btnClose.Image = Resources.Close_W;

            btnClose.BackColor = Color.FromArgb(33, 33, 33);

            Separator1.LineColor = Color.White;
            Separator2.LineColor = Color.White;

            lblParameters.BackColor = Color.FromArgb(33, 33, 33);
            lblParameters.ForeColor = Color.White;

            lblLength.BackColor = Color.FromArgb(33, 33, 33);
            lblLength.ForeColor = Color.White;

            lblAmount.BackColor = Color.FromArgb(33, 33, 33);
            lblAmount.ForeColor = Color.White;

            lblUpp.BackColor = Color.FromArgb(33, 33, 33);
            lblUpp.ForeColor = Color.White;

            lblLow.BackColor = Color.FromArgb(33, 33, 33);
            lblLow.ForeColor = Color.White;

            lblNum.BackColor = Color.FromArgb(33, 33, 33);
            lblNum.ForeColor = Color.White;

            lblSymb.BackColor = Color.FromArgb(33, 33, 33);
            lblSymb.ForeColor = Color.White;
        }

        private void LightTheme()
        {
            this.BackColor = Color.White;

            btnClose.Image = Resources.Close;

            btnClose.BackColor = Color.White;

            Separator1.LineColor = Color.FromArgb(210, 210, 210);
            Separator2.LineColor = Color.FromArgb(210, 210, 210);

            lblParameters.BackColor = Color.White;
            lblParameters.ForeColor = Color.Black;

            lblLength.BackColor = Color.White;
            lblLength.ForeColor = Color.Black;

            lblAmount.BackColor = Color.White;
            lblAmount.ForeColor = Color.Black;

            lblUpp.BackColor = Color.White;
            lblUpp.ForeColor = Color.Black;

            lblLow.BackColor = Color.White;
            lblLow.ForeColor = Color.Black;

            lblNum.BackColor = Color.White;
            lblNum.ForeColor = Color.Black;

            lblSymb.BackColor = Color.White;
            lblSymb.ForeColor = Color.Black;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                int Length;
                int Amount;

                int maxLength = 100;
                int maxAmount = 1000;

                if (int.Parse(txtLength.Text) > maxLength)
                {
                    Length = maxLength;
                    txtLength.Text = "100";
                }

                else
                {
                    Length = int.Parse(txtLength.Text);
                }

                if (int.Parse(txtAmount.Text) > maxAmount)
                {
                    Amount = maxAmount;
                    txtAmount.Text = "1000";
                }

                else
                {
                    Amount = int.Parse(txtAmount.Text);
                }

                generatePassword.GenerateList(Length, Amount, lstPasswords,
                                              cbUppercase, cbLowercase, cbNumbers, cbSymbols);
            }
            catch
            {

            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPasswords.Items.Count == 0)
                {
                    MessageBox.Show("To save the file, first generate the passwords!",
                                    "Save Passwords File",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (lstPasswords.Items.Count != 0)
                {
                    string file = null;

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.InitialDirectory = @"C:\";
                    saveFileDialog1.Title = "Save Passwords File";
                    saveFileDialog1.DefaultExt = "txt";
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        file = saveFileDialog1.FileName;

                        StreamWriter SaveFile = new StreamWriter(file);

                        foreach (var item in lstPasswords.Items)
                        {
                            SaveFile.WriteLine(item.ToString());
                        }

                        SaveFile.Close();

                        MessageBox.Show("File saved successfully!", 
                                        "Save Passwords File",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch
            {

            }  
        }
    }
}
