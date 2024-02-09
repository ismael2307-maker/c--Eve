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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((checkBox1.Checked == true) && (checkBox3.Checked == true) && (checkBox5.Checked == true && checkBox7.Checked == true) && (checkBox9.Checked == true) && (checkBox11.Checked == true))
            {
                richTextBox1.Text = "Posible caso de esclerosis multiple" +
                    " Se recomienda evitar la exposición a ambientes muy calurosos. En verano, evitar exponerse al sol en las horas centrales del día. A la hora de realizar ejercicio físico llevar ropa cómoda y ligera. En el baño, evitar que la temperatura del agua sea demasiado elevada.";

            }else if ((checkBox2.Checked == true) && (checkBox4.Checked == true) && (checkBox6.Checked == true) && (checkBox3.Checked == true) && (checkBox9.Checked == true))
            {
                richTextBox1.Text = "Posible caso de la enfermedad de Lyme" +
                    " Se recomienda  Usar repelentes de insectos que contengan DEET, picaridina, IR3535, aceite de eucalipto limón, para-mentano-3,8-diol o 2-undecanona. › Rociar zapatos, ropa y equipo con permetrina al 0,5 %. › Bañarse lo antes posible luego de haber estado al aire libre. › Revisar a diario que el cuerpo no tenga garrapatas.";

            }else if ((checkBox8.Checked == true) && (checkBox10.Checked == true) && (checkBox1.Checked == true) && (checkBox3.Checked == true) && (checkBox11.Checked == true))
            {
                richTextBox1.Text = "Posible caso de Neuropatia" +
                    " Se recomienda el ejercicio regular, como caminar tres veces a la semana, puede reducir el dolor de la neuropatía, mejorar la fuerza muscular y ayudar a controlar los niveles de glucosa en la sangre. Rutinas sutiles como el yoga y el taichí también pueden ayudar.";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Focus();
        }
    }
}
