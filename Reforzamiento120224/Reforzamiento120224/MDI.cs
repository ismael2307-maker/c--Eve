using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reforzamiento120224
{
    public partial class MDI : Form
    {
        Form1 f = new Form1();
        Velocidad_Lineal v = new Velocidad_Lineal();
        CALCULO_MEDIA c = new CALCULO_MEDIA();
        Numero_Primo n = new Numero_Primo();
        Calculo_Temperatura ct = new Calculo_Temperatura();
        Dpreciacion_Calculo dp = new Dpreciacion_Calculo();
        Calcule_Utilidad cu = new Calcule_Utilidad();
        EjemploDataGrieview EJ = new EjemploDataGrieview();
        Depreciacion_Bienes_DataGridView dbp = new Depreciacion_Bienes_DataGridView();
        public MDI()
        {
            InitializeComponent();
        }

        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.MdiParent = this;
            v.Show();
        }

        private void eJERCICIO3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.MdiParent = this;
            c.Show();
        }

        private void eJERCICIO4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n.MdiParent = this;
            n.Show();
        }

        private void eJERCICIO5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ct.MdiParent = this;
            ct.Show();
        }

        private void eJERCICIO6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dp.MdiParent = this;
            dp.Show();
        }

        private void eJERCICIO7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cu.MdiParent = this;
            cu.Show();
        }

        private void eJERCICIO8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EJ.MdiParent = this;
            EJ.Show();
        }

        private void eJERCICIO9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbp.MdiParent = this;
            dbp.Show();
        }
    }
}
