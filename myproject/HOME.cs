using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myproject
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            REGISTRATION f = new REGISTRATION();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SUBMISSION F = new SUBMISSION();
            F.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RECORD F = new RECORD();
            F.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TRANSACTION F = new TRANSACTION();
            F.Show();
        }
    }
}
