using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejerc1
{
    public partial class Form2 : Form
    {
        Form1 G = new Form1();  
        Form3 B = new Form3();
        Form4 U = new Form4(); 
        public Form2()
        {
            InitializeComponent();
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G.MdiParent = this;
            G.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bienesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            B.MdiParent = this;
            B.Show();
        }

        private void utilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            U.MdiParent = this;
            U.Show();
        }
    }
}
