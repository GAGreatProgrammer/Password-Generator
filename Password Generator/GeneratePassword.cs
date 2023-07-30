using Bunifu.UI.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public class GeneratePassword
    {
        const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string Numbers = "1234567890";
        const string Symbols = @"~!@#$%^&*():;[]{}<>,.?/\|";


        public string Generate(int length, BunifuCheckBox uppercase, BunifuCheckBox lowercase,
                                            BunifuCheckBox numbers, BunifuCheckBox symbols)
        {
            try
            {
                char[] password = new char[length];
                string charSet = "";

                Random random = new Random();

                if (uppercase.Checked == true)
                    charSet += Uppercase;

                if (lowercase.Checked == true)
                    charSet += Lowercase;

                if (numbers.Checked == true)
                    charSet += Numbers;

                if (symbols.Checked == true)
                    charSet += Symbols;

                for (int i = 0; i < length; i++)
                    password[i] = charSet[random.Next(charSet.Length - 1)];

                return string.Join(null, password);
            }
            catch
            {
                return "Choose Password Parameters!!!";
            }
        }

        public void GenerateList(int length, int amount, ListBox listBox,
                                    BunifuCheckBox uppercase, BunifuCheckBox lowercase,
                                    BunifuCheckBox numbers, BunifuCheckBox symbols)
        {
            try
            {
                var passList = new List<string>();

                Random random = new Random();

                for (int p = 0; p < amount; p++)
                {
                    char[] password = new char[length];
                    string charSet = "";

                    if (uppercase.Checked == true)
                        charSet += Uppercase;

                    if (lowercase.Checked == true)
                        charSet += Lowercase;

                    if (numbers.Checked == true)
                        charSet += Numbers;

                    if (symbols.Checked == true)
                        charSet += Symbols;

                    for (int i = 0; i < length; i++)
                        password[i] = charSet[random.Next(charSet.Length - 1)];

                    passList.Add(string.Join(null, password));
                }

                foreach (var pass in passList)
                {
                    listBox.DataSource = passList;
                }
            }
            catch
            {
                
            }
        }
    }
}
