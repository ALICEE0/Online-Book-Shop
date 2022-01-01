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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }
        connectiontosql bgl = new connectiontosql();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand signin = new SqlCommand("Select * From Tbl_Users where UserMail=@p1 and UserPassword=@p2", bgl.connect());
                signin.Parameters.AddWithValue("@p1", txtmail.Text);
                signin.Parameters.AddWithValue("@p2", txtpass.Text);

                SqlDataReader dr = signin.ExecuteReader();
                if (dr.Read())
                {
                    CustomerMainPage mp = new CustomerMainPage();
                    mp.usermail = txtmail.Text;
                    mp.username = dr[1].ToString();
                    mp.usersurname = dr[2].ToString();
                    mp.userid = dr[0].ToString();
                    mp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please check your answers", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }
            
            

        }
    }
}
