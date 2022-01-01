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
    public partial class CustomerChangePersonelInfo : Form
    {
        public CustomerChangePersonelInfo()
        {
            InitializeComponent();
        }
        connectiontosql bg = new connectiontosql();
        public string userid;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void CustomerChangePersonelInfo_Load(object sender, EventArgs e)
        {
            lblid.Text = userid;
            SqlCommand bring = new SqlCommand("Select * From Tbl_Users Where UserID=@p1", bg.connect());
            bring.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader dr = bring.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                txtmail.Text = dr[3].ToString();
                txtpass.Text = dr[4].ToString();
            }
            bg.connect().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("Update Tbl_Users set UserName=@p1,UserSurname=@p2,UserMail=@p3,UserPassword=@p4 where UserID=@p5", bg.connect());
            update.Parameters.AddWithValue("@p1", txtname.Text);
            update.Parameters.AddWithValue("@p2", txtsurname.Text);
            update.Parameters.AddWithValue("@p3", txtmail.Text);
            update.Parameters.AddWithValue("@p4", txtpass.Text);
            update.Parameters.AddWithValue("@p5", lblid.Text);
            update.ExecuteNonQuery();
            bg.connect().Close();
            MessageBox.Show("Updated");
        }
    }
}
