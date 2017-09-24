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
    public partial class Login : Form
    {
        Form adminHome;
        Form cashierHome;
        

        protected override CreateParams CreateParams
        {
            get
            {
                var createdParameter = base.CreateParams;
                createdParameter.ExStyle |= 0x2000000;
                return createdParameter;
            }
        }

       
        public Login()
        {
        
            InitializeComponent();
           
        }

        private void SelectViews(string user)
        {
            adminHome = new AdminHome
            {
                Name = "adminHome"
            };

            cashierHome = new CashierHome
            {
                Name = "cashierHome"
            };

            if (user.Equals("Admin"))
            {
                adminHome.Show();
                
            }
            else
            {
                cashierHome.Show();
               
            }
        }
     
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userAccount = "notAdmin";
            SelectViews(userAccount);
            this.Hide();
            
            

        }
    }
}
