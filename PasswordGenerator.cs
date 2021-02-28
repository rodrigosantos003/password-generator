using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        private static Random random = new Random();

        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();

            txt_Password.Text = RandomPass(16);
        }

        public static string RandomPass(int lenght)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0abcdefghijklmnopqrstuvwxyz123456789_=+-*/.!#%?";
            return new string(Enumerable.Repeat(chars, lenght).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
