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
    public partial class AdminHome : Form
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


        public AdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
