using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTracbarBarprogress
{
    public partial class Form1 : Form
    {
        private int conteo;
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            label1.Text = conteo.ToString();

            if (progressBar1.Value <100) 
            {
               progressBar1.Value++;

            }else if (progressBar1.Value==100)
            {
               timer1.Enabled = false;
            }
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Value = 0;
        }

        private void btn_Detener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            trackBar1.Value = trackBar1.Minimum;
            label2.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
