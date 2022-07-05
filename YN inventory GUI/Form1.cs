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
            Model it = new Model();
            it.Number = txtnumber.Text;
            it.Date = txtdate.Text;
            it.Inventorynum = txtinventorynum.Text;
            it.Objectname = txtobjectname.Text;
            it.Count = txtcount.Text;
            it.Price = txtprice.Text;
            it.save();
            MessageBox.Show("Added successfully ");
            
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
    }
}
