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
    public partial class SellerUpdateInfo : Form
    {
        public SellerUpdateInfo()
        {
            InitializeComponent();
        }
        public string sellerid;
        connectiontosql bgl = new connectiontosql();
        private void SellerUpdateInfo_Load(object sender, EventArgs e)
        {
            lblid.Text = sellerid;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Sellers where SellerID=@p1", bgl.connect());
            command.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                SellerMainPage mp = new SellerMainPage();
                mp.sellerid = dr[0].ToString();
                mp.sellername = dr[1].ToString();
                mp.sellersurname = dr[2].ToString();
                mp.selleremail = dr[3].ToString();
                mp.Show();
                this.Hide();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("Update Tbl_Sellers set SellerName=@p1,SellerSurname=@p2,SellerEmail=@p3,SellerPassword=@p4 where SellerID=@p5", bgl.connect());
            update.Parameters.AddWithValue("@p1", txtname.Text);
            update.Parameters.AddWithValue("@p2", txtsurname.Text);
            update.Parameters.AddWithValue("@p3", txtmail.Text);
            update.Parameters.AddWithValue("@p4", txtpass.Text);
            update.Parameters.AddWithValue("@p5", lblid.Text);
            update.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Updated");



        }
    }
}
