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
    public partial class Card : Form
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

        NFCReader nfcReader = new NFCReader();


        public Card()
        {
            InitializeComponent();
            LoadCardNumber();
        }
        
        public void LoadCardNumber()
        {
            
            TextBoxCardNumber.Text =nfcReader.ConnectHardware();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonLoadCard_Click(object sender, EventArgs e)
        {
            Form cashierHomePage = new CashierHome();
            cashierHomePage.Show();
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Form cashierHomePage = new CashierHome();
            cashierHomePage.Show();
            Close();

        }
    }
}
