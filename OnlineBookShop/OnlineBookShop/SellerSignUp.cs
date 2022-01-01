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
    public partial class SellerSignUp : Form
    {
        public SellerSignUp()
        {
            InitializeComponent();
        }
        connectiontosql bgl = new connectiontosql();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtsurname.Text == "")
            {
                MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (txtmail.Text == "")
            {
                MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand signup = new SqlCommand("insert into Tbl_Sellers(SellerName,SellerSurname,SellerEmail,SellerPassword) values (@p1,@p2,@p3,@p4)", bgl.connect());
                    signup.Parameters.AddWithValue("@p1", txtname.Text);
                    signup.Parameters.AddWithValue("@p2", txtsurname.Text);
                    signup.Parameters.AddWithValue("@p3", txtmail.Text);
                    signup.Parameters.AddWithValue("@p4", txtpass.Text);
                    signup.ExecuteNonQuery();
                    bgl.connect().Close();
                    MessageBox.Show("You have successfully registered.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Terminal tr = new Frm_Terminal();
            tr.Show();
            this.Hide();
        }
    }
}




