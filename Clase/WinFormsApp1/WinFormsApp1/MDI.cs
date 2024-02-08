using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MDI : Form
    {
        Figuras f = new Figuras();
        public MDI()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }
    }
}
