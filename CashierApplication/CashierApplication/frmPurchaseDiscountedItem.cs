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
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }
        private DiscountedItem di;

        private void button1_Click(object sender, EventArgs e)
        {
         
            di = new DiscountedItem(ItemName.Text,Convert.ToDouble(PriceT.Text), Convert.ToInt16(QuantityT.Text), Convert.ToInt16(DiscountT.Text));
            TotalAmountT.Text = di.getTotalPrice().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            di.setPayment(Convert.ToDouble(PaymentReceived.Text));
            DisChange.Text = di.getChange().ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoginAccount fLA = new frmLoginAccount();
            fLA.Show();
            this.Hide();

        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
    }
}
