using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABSCBN
{
    public partial class CashierHome : Form
    {
        
        Registration registration = new Registration();
        Card card = new Card();


        public CashierHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashierHome cashier2 = new CashierHome();
            registration.Show();
            cashier2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            card.Show();
            registration.Hide();
        }
    }
}
