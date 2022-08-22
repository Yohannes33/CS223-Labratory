using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_desktop.model;

namespace Lab_desktop
{
    public partial class Update_Products : Form
    {

        Model updatedProduct = new Model();
        Model productList = new Model();
        public Update_Products()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            productList = Model.findOne(SearchTxt.Text);
            if (updatedProduct == null)
            {
                MessageBox.Show("Product is not found.");
            }
            else if (productList == null)
            {
                MessageBox.Show("No Product was added. Add Products first!");
            }
            else
            {
                txtcount.Text = productList.Count.ToString();
                txtinventorynum.Text = productList.Inventorynum.ToString();
                txtnumber.Text = productList.Number.ToString();
                txtobjectname.Text = productList.Objectname;
                txtprice.Text = productList.Price.ToString();
                if (productList.productType == "Variable")
                {
                    btnvariable.Checked = true;
                }
                else
                {
                    btnsimple.Checked = true;
                }
            }

            List<Model> P_List = new List<Model>();
            P_List.Add(productList);
            Allproducts.DataSource = null;
            Allproducts.DataSource = P_List;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[a-z]||[A-Z] {10}$");
            Regex nu = new Regex(@"^[0-9]{5}$");

     
            string checkedItems = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                checkedItems += item.ToString();
            }
            if (string.IsNullOrEmpty(txtnumber.Text))
            {

                errorProvider1.SetError(txtnumber, "INVALID number !!!  ");

            }
            else if (!nu.IsMatch(txtnumber.Text))
            {
                errorProvider1.SetError(txtnumber, "INVALID number- !!!  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(txtinventorynum.Text))
            {
                errorProvider1.SetError(txtinventorynum, "INVALID inventorynum !!!  ");
            }
            else if (!nu.IsMatch(txtinventorynum.Text))
            {

                errorProvider1.SetError(txtinventorynum, "INVALID inventorynum- !!!  ");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtobjectname.Text))
            {
                errorProvider1.SetError(txtobjectname, "INVALID object name !!!  ");

            }

            else if (!re.IsMatch(txtobjectname.Text))
            {
                errorProvider1.SetError(txtobjectname, "INVALID object name- !!!  ");
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtcount.Text))
            {
                errorProvider1.SetError(txtcount, "INVALID count !!!  ");

            }
            else if (!nu.IsMatch(txtcount.Text))
            {

                errorProvider1.SetError(txtcount, "INVALID Count- !!!  ");
            }
            else
            {
                errorProvider1.Clear();
            }

            try
            {
                if (string.IsNullOrEmpty(txtprice.Text))
                {

                    errorProvider1.SetError(txtprice, "INVALID PRICE !!!  ");
                }
                else if (!nu.IsMatch(txtprice.Text))
                {

                    errorProvider1.SetError(txtprice, "INVALID price- !!!  ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            updatedProduct.Number = txtnumber.Text;
            updatedProduct.Inventorynum = txtinventorynum.Text;
            updatedProduct.Objectname = txtobjectname.Text;
            updatedProduct.Price = txtprice.Text;
            updatedProduct.Count = txtcount.Text;
            updatedProduct.Date = dateTimePicker1.Value;
            updatedProduct.productType = (btnsimple.Checked == true) ? "Simple" : "Variable";
            

            if (updatedProduct != null)
            {
                Model.updateProduct(updatedProduct, productList);
                Allproducts.DataSource = null;
                Allproducts.DataSource = Model.GetAllProducts();
                MessageBox.Show("Product has been updated sucessfully.");
            }
            else
            {
                MessageBox.Show("Please be sure that the product was added");
            }
        }
    }
}

