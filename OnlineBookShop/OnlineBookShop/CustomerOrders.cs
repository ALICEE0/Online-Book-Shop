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
    public partial class CustomerOrders : Form
    {
        public CustomerOrders()
        {
            InitializeComponent();
        }
        connectiontosql bg = new connectiontosql();
        public string userid;
        private void CustomerOrders_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select OrderID,OrderBookID,OrderVerify,OrderChoice,OrderSellerID,OrderCustomerID,OrderBookName,OrderCustomerName From Tbl_Orders Where OrderCustomerID =" + userid, bg.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bg.connect().Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
