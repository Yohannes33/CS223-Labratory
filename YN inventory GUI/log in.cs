using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_desktop
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void log_in_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check = "admin";
            if (textBox1.Text == check && textBox2.Text == check)
            {
                Main_container container = new Main_container(check);
                container.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
