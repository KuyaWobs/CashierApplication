using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();

        }

        private void frmLoginAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier user = new Cashier("Robby Buenaventura","Cashier",UserNbox.Text,PassWBox.Text);
            MessageBox.Show("Welcome,  Cashier!");

            if (user.validateLogin(UserNbox.Text,PassWBox.Text) )
            {
                this.Hide();
                frmPurchaseDiscountedItem fPD= new frmPurchaseDiscountedItem();
                fPD.Show();
                

            }  

        }
    }
}
