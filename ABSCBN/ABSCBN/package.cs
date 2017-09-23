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
    public partial class package : Form
    {
        public package()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            package package2 = new package();
            package2.Hide();
            Card card = new Card();
            card.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
        }
    }
}
