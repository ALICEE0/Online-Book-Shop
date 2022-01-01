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
    public partial class CustomerMainPage : Form
    {
        public CustomerMainPage()
        {
            InitializeComponent();
        }
        public string username, usersurname, usermail,userid;
        connectiontosql bgl = new connectiontosql();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select BookID,BookName,BookAuthor,BookPrice,BookType,BookStocks From Tbl_Books", bgl.connect());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.connect().Close();
            }
            else
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select BookID,BookName,BookAuthor,BookPrice,BookType,BookStocks From Tbl_Books Where BookName like '%" + textBox1.Text+"%'", bgl.connect());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.connect().Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string price;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenone = dataGridView1.SelectedCells[0].RowIndex;
            lblbookid.Text = dataGridView1.Rows[chosenone].Cells[0].Value.ToString();
            lblbookname.Text = dataGridView1.Rows[chosenone].Cells[1].Value.ToString();
            lblstocks.Text = dataGridView1.Rows[chosenone].Cells[5].Value.ToString();
            lblbookprice.Text = dataGridView1.Rows[chosenone].Cells[3].Value.ToString() + "$";
            price= dataGridView1.Rows[chosenone].Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerChangePersonelInfo zort = new CustomerChangePersonelInfo();
            zort.userid = label3.Text;
            zort.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerOrders co = new CustomerOrders();
            co.userid = label3.Text;
            co.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblbookid.Text != "Null" && lblbookname.Text!="Null" && lblbookprice.Text !="Null" && lblstocks.Text != "Null" && lblstocks.Text != "0")
            {
                GiveOrder go = new GiveOrder();
                go.bookid = lblbookid.Text;
                go.bookname = lblbookname.Text;
                go.price = price;
                go.customerid = label3.Text;
                go.customername = lblname.Text;
                go.Show();
            }
            else
            {
                MessageBox.Show("Please Select Book From List.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {
            lblname.Text = username + " " + usersurname;
            lblemail.Text = usermail;
            label3.Text = userid;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BookID,BookName,BookAuthor,BookPrice,BookType,BookStocks From Tbl_Books", bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connect().Close();
        }
    }
}
