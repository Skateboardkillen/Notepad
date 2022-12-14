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
    public partial class MainUI : Form
    {
        DataTable Data; // Initialize Data For Scope

        public MainUI()
        {
            InitializeComponent();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            Data = new DataTable(); // Construct New Datatble For GridLayout
            Data.Columns.Add("Title", typeof(String));
            Data.Columns.Add("Content", typeof(String));

            GridLayout.DataSource = Data;

            GridLayout.Columns["Title"].Width = 183;
            GridLayout.Columns["Content"].Visible = false;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = GridLayout.CurrentCell.RowIndex;

                if (i > -1)
                {
                    // https://learn.microsoft.com/en-us/dotnet/api/system.data.datarow.itemarray?view=net-6.0
                    TitleBox.Text = Data.Rows[i].ItemArray[0].ToString(); 
                    ContentBox.Text = Data.Rows[i].ItemArray[1].ToString();
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            TitleBox.Clear();
            ContentBox.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Data.Rows.Add(TitleBox.Text, ContentBox.Text);

            TitleBox.Clear();
            ContentBox.Clear();
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = GridLayout.CurrentCell.RowIndex;
                Data.Rows[i].Delete();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error");
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
