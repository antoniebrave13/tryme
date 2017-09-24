using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ABSCBN
{
    public partial class Registration : Form
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

        public Registration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void ButtonLoadCard_Click(object sender, EventArgs e)
        {
            Form newCard = new Card();
            newCard.Show();
            
        }
    }
}
