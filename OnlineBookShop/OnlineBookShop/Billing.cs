using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OnlineBookShop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        public string bookprice, bookname,choice,bookid,userid,username;
        connectiontosql bgl = new connectiontosql();
        private void btnapprove_Click(object sender, EventArgs e)
        {
            SqlCommand buy = new SqlCommand("insert into Tbl_Orders(OrderBookID,OrderChoice,OrderSellerID,OrderCustomerID,OrderBookName,OrderCustomerName)values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.connect());
            buy.Parameters.AddWithValue("@p1", lblid.Text);
            buy.Parameters.AddWithValue("@p2", choice);
            buy.Parameters.AddWithValue("@p3", sellerid.Text);
            buy.Parameters.AddWithValue("@p4", label6.Text);
            buy.Parameters.AddWithValue("@p5", lblbook.Text);
            buy.Parameters.AddWithValue("@p6", label11.Text);
            buy.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Successful");
            CustomerMainPage cmp = new CustomerMainPage();
            
            this.Hide();

                
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            lblbook.Text = bookname;
            lblprice.Text = bookprice;
            lblid.Text = bookid;
            label6.Text = userid;
            label11.Text = username;
            SqlCommand bring = new SqlCommand("Select BookSellerID From Tbl_Books where BookID = " + bookid, bgl.connect());
            SqlDataReader dr = bring.ExecuteReader();
            while (dr.Read())
            {
                sellerid.Text = dr[0].ToString();
                bgl.connect().Close();

            }


            


        }
    }
}
