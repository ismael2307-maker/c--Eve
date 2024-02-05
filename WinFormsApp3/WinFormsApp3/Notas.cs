using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btn_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CALCULARNOTA_Click(object sender, EventArgs e)
        {
            double not1,not2,not3,not4,notf;
             not1 = double.Parse(maskedTextBox1.Text = (0).ToString());
             not2 = double.Parse(maskedTextBox2.Text = (0).ToString());
             not3 = double.Parse(maskedTextBox3.Text = (0).ToString());
             not4 = double.Parse(maskedTextBox4.Text = (0).ToString());
           

           /* not1 = double.Parse(maskedTextBox1.Text);
            not2 = double.Parse(maskedTextBox2.Text );
            not3 = double.Parse(maskedTextBox3.Text);
            not4 = double.Parse(maskedTextBox4.Text );
           */

            if ((not1<0 || not1>25) && (not2 < 0 || not2 > 25) && (not3 < 0 || not3 > 25) && (not4 < 0 || not4 > 25) )
            {
                MessageBox.Show("No puede meter valores negativos ni mayores a 25");
            }
            else
            {
                notf = not1 + not2 + not3 + not4;
                txt_notfinal.Text = notf.ToString();
            }
               
        }

        private void btn_LIMPIAR_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            txt_notfinal.Text = "";
            maskedTextBox1.Focus();
            maskedTextBox2.Focus(); 
            maskedTextBox3.Focus();
            maskedTextBox4.Focus();
        }
    }
}
