﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image miImagen = Image.FromFile("Fer.jpg");
            pictureBox1.Image = miImagen;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
