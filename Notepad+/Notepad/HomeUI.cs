using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void HomeUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Skateboardkillen/Notepad");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loader Key = new Loader();
            Key.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("");
        }
    }
}
