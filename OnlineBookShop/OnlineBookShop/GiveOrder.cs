using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop
{
    public partial class GiveOrder : Form
    {
        public GiveOrder()
        {
            InitializeComponent();
        }
        public string bookname, price, bookid,customername,customerid;
        public int price2;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                txtprice.Text = price + "$";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                price2 = Convert.ToInt32(price) + 5;
                txtprice.Text = price2 + "$";
            }

            
        }

        private void btngoon_Click(object sender, EventArgs e)
        {
            Billing bl = new Billing();
            if (radioButton1.Checked)
            {
                bl.choice = "False";
                bl.bookname = txtbookname.Text;
                bl.bookprice = txtprice.Text;
                bl.bookid = lblbookid.Text;
                bl.userid = label6.Text;
                bl.username = label11.Text;

                bl.Show();
            }
            if (radioButton2.Checked)
            {
                
                bl.choice = "True";

                bl.bookname = txtbookname.Text;
                bl.bookprice = txtprice.Text;
                bl.bookid = lblbookid.Text;
                bl.userid = label6.Text;
                bl.username = label11.Text;
                bl.Show();
            }
            if(radioButton1.Checked==false && radioButton2.Checked==false)
            {
                MessageBox.Show("Please check your answers");
            }
        }

        private void GiveOrder_Load(object sender, EventArgs e)
        {
            lblbookid.Text = bookid;
            txtbookname.Text = bookname;
            label6.Text = customerid;
            label11.Text = customername;
            
            txtprice.Text = price+"$";
        }
    }
}
