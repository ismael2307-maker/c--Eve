using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_button_textbox_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string textodeltexbox = txt_nombre.Text;
            lbl_TEXT.Text = textodeltexbox;
        }
    }
}
