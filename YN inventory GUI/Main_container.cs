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
    public partial class Main_container : Form
    {
        public Main_container()
        {
            InitializeComponent();
        }

        public Main_container(string username)
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1("Add Product ");
            newform.MdiParent = this;
            newform.Show();
        }

        private void Main_container_Load(object sender, EventArgs e)
        {

        }
    }
}
