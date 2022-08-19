namespace Lab_desktop
{
    partial class Form1
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
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtinventorynum = new System.Windows.Forms.TextBox();
            this.txtobjectname = new System.Windows.Forms.TextBox();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.Allproducts = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnsimple = new System.Windows.Forms.RadioButton();
            this.btnvariable = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblusername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Allproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(23, 68);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(137, 26);
            this.txtnumber.TabIndex = 0;
            this.txtnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(192, 335);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 40);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtinventorynum
            // 
            this.txtinventorynum.Location = new System.Drawing.Point(664, 68);
            this.txtinventorynum.Name = "txtinventorynum";
            this.txtinventorynum.Size = new System.Drawing.Size(197, 26);
            this.txtinventorynum.TabIndex = 3;
            this.txtinventorynum.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtobjectname
            // 
            this.txtobjectname.Location = new System.Drawing.Point(23, 160);
            this.txtobjectname.Name = "txtobjectname";
            this.txtobjectname.Size = new System.Drawing.Size(642, 26);
            this.txtobjectname.TabIndex = 4;
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(23, 234);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(198, 26);
            this.txtcount.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(456, 234);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(150, 26);
            this.txtprice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventory number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Object name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(456, 336);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(103, 39);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Allproducts
            // 
            this.Allproducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Allproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allproducts.Location = new System.Drawing.Point(2, 381);
            this.Allproducts.Name = "Allproducts";
            this.Allproducts.RowHeadersWidth = 62;
            this.Allproducts.RowTemplate.Height = 28;
            this.Allproducts.Size = new System.Drawing.Size(953, 250);
            this.Allproducts.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 12, 17, 39, 28, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "soap ",
            " snak  ",
            " milk ",
            " fruit "});
            this.checkedListBox1.Location = new System.Drawing.Point(759, 160);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(142, 119);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
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
            this.btnsimple.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvariable);
            this.groupBox1.Controls.Add(this.btnsimple);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 60);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(858, 9);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(84, 20);
            this.lblusername.TabIndex = 20;
            this.lblusername.Text = "user name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 634);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Allproducts);
            this.Controls.Add(this.btncancel);
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
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Allproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtinventorynum;
        private System.Windows.Forms.TextBox txtobjectname;
        private System.Windows.Forms.TextBox txtcount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView Allproducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton btnsimple;
        private System.Windows.Forms.RadioButton btnvariable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblusername;
    }
}

