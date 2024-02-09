using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class MDI : Form
    {
        Form1 f = new Form1();
        Form2 D = new Form2();
        Form3 C = new Form3();
        Form4 P = new Form4();
        public MDI()
        {
            InitializeComponent();
        }

        private void figurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void diagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D.MdiParent = this;
            D.Show();
        }

        private void convertidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C.MdiParent = this;
            C.Show();
        }

        private void convertidorPesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.MdiParent = this;
            P.Show();
        }
    }
}
