namespace Lab_desktop
{
    partial class Product_card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.CountLb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.CountLb);
            this.panel1.Controls.Add(this.PriceLb);
            this.panel1.Controls.Add(this.NameLb);
            this.panel1.Location = new System.Drawing.Point(87, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 285);
            this.panel1.TabIndex = 0;
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.Location = new System.Drawing.Point(25, 34);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(126, 32);
            this.NameLb.TabIndex = 0;
            this.NameLb.Text = "Name:   ";
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLb.Location = new System.Drawing.Point(25, 121);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(101, 32);
            this.PriceLb.TabIndex = 1;
            this.PriceLb.Text = "Price: ";
            // 
            // CountLb
            // 
            this.CountLb.AutoSize = true;
            this.CountLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLb.Location = new System.Drawing.Point(25, 207);
            this.CountLb.Name = "CountLb";
            this.CountLb.Size = new System.Drawing.Size(112, 32);
            this.CountLb.TabIndex = 2;
            this.CountLb.Text = "Count: ";
            // 
            // Product_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.panel1);
            this.Name = "Product_card";
            this.Size = new System.Drawing.Size(572, 392);
            this.Load += new System.EventHandler(this.Product_card_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CountLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.Label NameLb;
    }
}
