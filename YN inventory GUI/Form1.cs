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
using System.Text.RegularExpressions;

namespace Lab_desktop
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Regex re = new Regex(@"^[a-z]||[A-Z] {10}$");
            Regex nu = new Regex(@"^[0-9]{5}$");

            Model it = new Model
            {
                Number = txtnumber.Text,
                Inventorynum = txtinventorynum.Text,
                Objectname = txtobjectname.Text,
                Count = txtcount.Text,
                Price = txtprice.Text,
                Date = dateTimePicker1.Value
            };
            
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
                else
                {
                    errorProvider1.Clear();
                    it.save();
                    MessageBox.Show("Added successfully ");
                    Allproducts.DataSource = null;
                    Allproducts.DataSource = Model.GetAllProducts();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("invalid price !!!");
            }
           
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
