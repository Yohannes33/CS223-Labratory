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
    public partial class Product_card : UserControl
    {
        private string product_Name;

        public string Product
        {
            get { return product_Name; }
            set { product_Name = value; NameLb.Text += value; }
        }

        

        private int Product_Count;

        public int ProductQuantity
        {
            get { return Product_Count; }
            set { Product_Count = value; CountLb.Text += value; }
        }

        private double product_Price;

        public double ProductPrice
        {
            get { return product_Price; }
            set { product_Price = value; PriceLb.Text += value; }
        }
        public Product_card()
        {
            InitializeComponent();
        }

        private void Product_card_Load(object sender, EventArgs e)
        {

        }
    }
}
