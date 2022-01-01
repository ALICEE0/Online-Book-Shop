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
    public partial class SellerMainPage : Form
    {
        public SellerMainPage()
        {
            InitializeComponent();
        }
        connectiontosql bgl = new connectiontosql();
        public string sellername, sellersurname, selleremail,sellerid;

        private void button4_Click(object sender, EventArgs e)
        {
            SellerBooksForSale sbfs = new SellerBooksForSale();
            sbfs.sellerid = label6.Text;
            sbfs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerUpdateInfo ui = new SellerUpdateInfo();
            ui.sellerid = label6.Text;
            ui.Show();
            this.Hide();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label9.Text = "True";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label9.Text = "False";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosenone = dataGridView1.SelectedCells[0].RowIndex;
            txtbookname.Text = dataGridView1.Rows[chosenone].Cells[0].Value.ToString();
            txtorderid.Text = dataGridView1.Rows[chosenone].Cells[4].Value.ToString();
            
            txtcostumer.Text = dataGridView1.Rows[chosenone].Cells[1].Value.ToString();
            if (dataGridView1.Rows[chosenone].Cells[1].Value.ToString() == "True")
            {
                label9.Text = "False";
            }
            if (dataGridView1.Rows[chosenone].Cells[1].Value.ToString() == "False")
            {
                label9.Text = "False";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand updatee = new SqlCommand("Update  Tbl_Orders set OrderVerify=@p2 where OrderId=@p1", bgl.connect());
            updatee.Parameters.AddWithValue("@p1", txtorderid.Text);
            updatee.Parameters.AddWithValue("@p2", label9.Text);
            updatee.ExecuteNonQuery();
            bgl.connect().Close();
            MessageBox.Show("Done");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select OrderBookName,OrderCustomerName,OrderNumber,OrderVerify,OrderID From Tbl_Orders Where OrderSellerID=" + selerid, bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connect().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerAddBook ab = new SellerAddBook();
            ab.sellerid = Convert.ToInt32(sellerid);
            ab.Show();
        }
        public string selerid;
        private void SellerMainPage_Load(object sender, EventArgs e)
        {
            lblname.Text = sellername + " " + sellersurname;
            lblmail.Text = selleremail;
            label6.Text = sellerid;


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select OrderBookName,OrderCustomerName,OrderNumber,OrderVerify,OrderID From Tbl_Orders Where OrderSellerID=" + selerid, bgl.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connect().Close();
        }
    }
}
