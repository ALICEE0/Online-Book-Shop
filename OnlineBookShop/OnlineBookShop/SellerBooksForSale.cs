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
    public partial class SellerBooksForSale : Form
    {
        public SellerBooksForSale()
        {
            InitializeComponent();
        }
        connectiontosql bg = new connectiontosql();
        public string sellerid;
        private void SellerBooksForSale_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Books Where BookSellerID =" + sellerid, bg.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bg.connect().Close();
        }
    }
}
