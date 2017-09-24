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
    public partial class Transaction : Form
    {
        AdminHome admin = new AdminHome();
        public Transaction()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin.Show();
        }
    }
}
