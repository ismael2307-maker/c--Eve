using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJercicio1
{
    public partial class MDI : Form
    {
        Form1 n = new Form1();
        Form2 V = new Form2();
        Form3 M = new Form3();
        Form4 A = new Form4();
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.MdiParent = this; 
            n.Show();   
        }

        private void velocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V.MdiParent = this;
            V.Show();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            M.MdiParent = this;
            M.Show();
        }

        private void primoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A.MdiParent = this; 
            A.Show();
        }
    }
}
