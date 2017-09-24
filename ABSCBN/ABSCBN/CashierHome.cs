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
        protected override CreateParams CreateParams
        {
            get
            {
                var createdParameter = base.CreateParams;
                createdParameter.ExStyle |= 0x2000000;
                return createdParameter;
            }
        }

        
        public CashierHome()
        {
            InitializeComponent();
        }

        

        private void ButtonRegisterCustomer_Click(object sender, EventArgs e)
        {
        
            Form registerCustomer = new Registration();
            registerCustomer.Show();
            Close();

        }

        private void ButtonLoadCard_Click(object sender, EventArgs e)
        {
            
            Form reLoadCard = new Card();
            reLoadCard.Show();
            Close();

        }
    }
}
