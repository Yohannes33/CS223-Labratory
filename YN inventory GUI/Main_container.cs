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
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 newform = new Form1("Add Product ");
            newform.MdiParent = this;
            newform.Show();
        }

        private void Main_container_Load(object sender, EventArgs e)
        {

        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            SearchProduct search = new SearchProduct();
            search.MdiParent = this;
            search.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Update_Products update = new Update_Products();
            update.MdiParent = this;
            update.Show();
        }

        private void displayProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
