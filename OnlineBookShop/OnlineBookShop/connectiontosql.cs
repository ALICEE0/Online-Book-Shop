using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineBookShop
{
    class connectiontosql
    {
        public SqlConnection connect()
        {
            SqlConnection baglan = new SqlConnection("Data Source=OZMEN\\SQLEXPRESS01;Initial Catalog=BookShop;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
