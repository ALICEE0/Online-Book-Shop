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
    public partial class SellerAddBook : Form
    {
        public SellerAddBook()
        {
            InitializeComponent();
        }
        connectiontosql bgl = new connectiontosql();
        private void SellerAddBook_Load(object sender, EventArgs e)
        {
            SqlCommand type = new SqlCommand("Select TypeName From Tbl_Types", bgl.connect());
            SqlDataReader dr = type.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
        }
        public int sellerid;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand addbook = new SqlCommand("insert into Tbl_Books(BookName,BookAuthor,BookPages,BookPrice,BookType,BookAboutAuthor,BookStocks,BookSellerID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.connect());
                addbook.Parameters.AddWithValue("@p1", textBox1.Text);
                addbook.Parameters.AddWithValue("@p2", textBox2.Text);
                addbook.Parameters.AddWithValue("@p3", textBox4.Text);
                addbook.Parameters.AddWithValue("@p4", textBox5.Text);
                addbook.Parameters.AddWithValue("@p5", comboBox1.SelectedItem.ToString());
                addbook.Parameters.AddWithValue("@p6", richTextBox1.Text);
                addbook.Parameters.AddWithValue("@p7", textBox6.Text);
                addbook.Parameters.AddWithValue("@p8", sellerid);
                addbook.ExecuteNonQuery();
                bgl.connect().Close();
                MessageBox.Show("Succesfull");
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again");
                
            }
            
            
        }
    }
}
