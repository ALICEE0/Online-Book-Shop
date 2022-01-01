
namespace OnlineBookShop
{
    partial class Billing
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
            this.txtnamesurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcardno = new System.Windows.Forms.MaskedTextBox();
            this.txtdate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcvc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblbook = new System.Windows.Forms.Label();
            this.btnapprove = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sellerid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnamesurname
            // 
            this.txtnamesurname.Location = new System.Drawing.Point(330, 71);
            this.txtnamesurname.Name = "txtnamesurname";
            this.txtnamesurname.Size = new System.Drawing.Size(329, 33);
            this.txtnamesurname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Surname on the card:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expiration Date:";
            // 
            // txtcardno
            // 
            this.txtcardno.Location = new System.Drawing.Point(330, 126);
            this.txtcardno.Mask = "0000 0000 0000 0000";
            this.txtcardno.Name = "txtcardno";
            this.txtcardno.Size = new System.Drawing.Size(329, 33);
            this.txtcardno.TabIndex = 6;
            this.txtcardno.ValidatingType = typeof(int);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(330, 176);
            this.txtdate.Mask = "00/00";
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(142, 33);
            this.txtdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVC:";
            // 
            // txtcvc
            // 
            this.txtcvc.Location = new System.Drawing.Point(330, 227);
            this.txtcvc.Mask = "000";
            this.txtcvc.Name = "txtcvc";
            this.txtcvc.Size = new System.Drawing.Size(142, 33);
            this.txtcvc.TabIndex = 9;
            this.txtcvc.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(579, 179);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(61, 26);
            this.lblprice.TabIndex = 11;
            this.lblprice.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Book:";
            // 
            // lblbook
            // 
            this.lblbook.AutoSize = true;
            this.lblbook.Location = new System.Drawing.Point(579, 230);
            this.lblbook.Name = "lblbook";
            this.lblbook.Size = new System.Drawing.Size(61, 26);
            this.lblbook.TabIndex = 13;
            this.lblbook.Text = "label8";
            // 
            // btnapprove
            // 
            this.btnapprove.Location = new System.Drawing.Point(504, 278);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(136, 33);
            this.btnapprove.TabIndex = 14;
            this.btnapprove.Text = "Approve";
            this.btnapprove.UseVisualStyleBackColor = true;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(122, 450);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(61, 26);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book ID:";
            // 
            // sellerid
            // 
            this.sellerid.AutoSize = true;
            this.sellerid.Location = new System.Drawing.Point(122, 424);
            this.sellerid.Name = "sellerid";
            this.sellerid.Size = new System.Drawing.Size(61, 26);
            this.sellerid.TabIndex = 18;
            this.sellerid.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Seller ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Customer ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(758, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "label8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(524, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Customer Name-Surname:";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(883, 513);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sellerid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.lblbook);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcvc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtcardno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnamesurname);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnamesurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtcardno;
        private System.Windows.Forms.MaskedTextBox txtdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtcvc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblbook;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label sellerid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}