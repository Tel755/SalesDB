using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDBDataSet.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.salesDBDataSet.Items);
            // TODO: This line of code loads data into the 'salesDbDataSet.Items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.salesDbDataSet.Items);
            this.WindowState = FormWindowState.Maximized;

            int listBoxWidth = this.ClientSize.Width / 4 - 75;
            int listBoxHeight = this.ClientSize.Height - 200;

            //Table
            //dataGridView1.Size = new Size(this.ClientSize.Width - 440, this.ClientSize.Height - 25);

            //Listbox
            

            //Textbox
            

            //Button
            

        }



























        //Misclick
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
