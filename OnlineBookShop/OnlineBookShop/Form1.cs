using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop
{
    public partial class Frm_Terminal : Form
    {
        public Frm_Terminal()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CostumerSignUp sup = new CostumerSignUp();
            sup.Show();
            this.Hide();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            Signin sg = new Signin();
            sg.Show();
            this.Hide();
        }

        private void Frm_Terminal_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SellerSignUp su = new SellerSignUp();
            su.Show();
        }

        private void btnseller_Click(object sender, EventArgs e)
        {
            SellerSignin si = new SellerSignin();
            si.Show();
            this.Hide();
        }
    }
}
