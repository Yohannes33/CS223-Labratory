namespace Lab_desktop
{
    partial class Update_Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnsimple = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnvariable = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Allproducts = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtobjectname = new System.Windows.Forms.TextBox();
            this.txtinventorynum = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsimple
            // 
            this.btnsimple.AutoSize = true;
            this.btnsimple.Location = new System.Drawing.Point(6, 25);
            this.btnsimple.Name = "btnsimple";
            this.btnsimple.Size = new System.Drawing.Size(85, 24);
            this.btnsimple.TabIndex = 17;
            this.btnsimple.TabStop = true;
            this.btnsimple.Text = "simple";
            this.btnsimple.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvariable);
            this.groupBox1.Controls.Add(this.btnsimple);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(118, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 60);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Type";
            // 
            // btnvariable
            // 
            this.btnvariable.Location = new System.Drawing.Point(145, 25);
            this.btnvariable.Name = "btnvariable";
            this.btnvariable.Size = new System.Drawing.Size(126, 24);
            this.btnvariable.TabIndex = 0;
            this.btnvariable.TabStop = true;
            this.btnvariable.Text = "Variable";
            this.btnvariable.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "soap ",
            " snak  ",
            " milk ",
            " fruit "});
            this.checkedListBox1.Location = new System.Drawing.Point(854, 252);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(142, 119);
            this.checkedListBox1.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 12, 17, 39, 28, 0);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Allproducts
            // 
            this.Allproducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Allproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allproducts.Location = new System.Drawing.Point(12, 436);
            this.Allproducts.Name = "Allproducts";
            this.Allproducts.RowHeadersWidth = 62;
            this.Allproducts.RowTemplate.Height = 28;
            this.Allproducts.Size = new System.Drawing.Size(1140, 151);
            this.Allproducts.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Object name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Inventory number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Number";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(551, 326);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(150, 26);
            this.txtprice.TabIndex = 26;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(118, 326);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(198, 26);
            this.txtcount.TabIndex = 25;
            // 
            // txtobjectname
            // 
            this.txtobjectname.Location = new System.Drawing.Point(118, 252);
            this.txtobjectname.Name = "txtobjectname";
            this.txtobjectname.Size = new System.Drawing.Size(642, 26);
            this.txtobjectname.TabIndex = 24;
            // 
            // txtinventorynum
            // 
            this.txtinventorynum.Location = new System.Drawing.Point(759, 160);
            this.txtinventorynum.Name = "txtinventorynum";
            this.txtinventorynum.Size = new System.Drawing.Size(197, 26);
            this.txtinventorynum.TabIndex = 23;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(118, 160);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(137, 26);
            this.txtnumber.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 32);
            this.label7.TabIndex = 41;
            this.label7.Text = "Update Products";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Product Name: ";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(687, 74);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 39);
            this.Searchbtn.TabIndex = 39;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(518, 74);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(100, 26);
            this.SearchTxt.TabIndex = 38;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(584, 374);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(101, 46);
            this.savebtn.TabIndex = 42;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Update_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 599);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Allproducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtobjectname);
            this.Controls.Add(this.txtinventorynum);
            this.Controls.Add(this.txtnumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Products";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Allproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnsimple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnvariable;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView Allproducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtobjectname;
        private System.Windows.Forms.TextBox txtinventorynum;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button savebtn;
    }
}