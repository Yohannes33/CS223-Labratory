using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_desktop.model;

namespace Lab_desktop
{
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void SearchProduct_Load(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            List<Model> Item = new List<Model>();
            Model productSearch = Model.findOne(SearchTxt.Text);
            if (productSearch == null)
            {
                MessageBox.Show("Product was not found.");
            }
            else
            {
                Item.Add(productSearch);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item;
            }
        }
    }
}
