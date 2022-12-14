using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Visible = true;
            timer1.Stop();
            await Task.Delay(1000);
            WebClient updatecheck = new WebClient();
            label1.Text = ("Checking Current Version...");
            panel2.Size = new Size(97,27);
            await Task.Delay(1000);
            if (!updatecheck.DownloadString("https://raw.githubusercontent.com/Skateboardkillen/Notepad/main/Version").Contains("1.0"))
            {
                label1.Text = ("Outdated Version...");
                MessageBox.Show("You have an outdated version of Notepad+, Redirecting to download...", "Notepad+");
                System.Diagnostics.Process.Start("https://github.com/Skateboardkillen/Notepad");
                await Task.Delay(1000);
                Application.Exit();
            }
            else
            {
                panel2.Size = new Size(200, 27);
                label1.Text = ("Version is Up-to-date!");
                await Task.Delay(1000);
                label1.Text = ("Finishing Up...");
                panel2.Size = new Size(330, 27);
                await Task.Delay(1000);
                panel2.Size = new Size(370, 27);
                label1.Text = ("Loading Notepad+");
                await Task.Delay(1000);
                panel2.Size = new Size(400, 27);
                await Task.Delay(3000);
                this.Hide();
                MainUI Key = new MainUI();
                Key.Show();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
