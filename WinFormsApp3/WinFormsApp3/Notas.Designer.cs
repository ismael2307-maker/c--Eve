namespace WinFormsApp3
{
    partial class Notas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_nota1 = new System.Windows.Forms.Button();
            this.btn_nota2 = new System.Windows.Forms.Button();
            this.btn_nota3 = new System.Windows.Forms.Button();
            this.btn_nota4 = new System.Windows.Forms.Button();
            this.btn_Notafinal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.txt_notfinal = new System.Windows.Forms.TextBox();
            this.btn_CALCULARNOTA = new System.Windows.Forms.Button();
            this.btn_LIMPIAR = new System.Windows.Forms.Button();
            this.btn_SALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nota1
            // 
            this.btn_nota1.Location = new System.Drawing.Point(21, 76);
            this.btn_nota1.Name = "btn_nota1";
            this.btn_nota1.Size = new System.Drawing.Size(75, 23);
            this.btn_nota1.TabIndex = 0;
            this.btn_nota1.Text = "Nota #1:";
            this.btn_nota1.UseVisualStyleBackColor = true;
            // 
            // btn_nota2
            // 
            this.btn_nota2.Location = new System.Drawing.Point(21, 140);
            this.btn_nota2.Name = "btn_nota2";
            this.btn_nota2.Size = new System.Drawing.Size(75, 23);
            this.btn_nota2.TabIndex = 1;
            this.btn_nota2.Text = "Nota #2:";
            this.btn_nota2.UseVisualStyleBackColor = true;
            // 
            // btn_nota3
            // 
            this.btn_nota3.Location = new System.Drawing.Point(249, 74);
            this.btn_nota3.Name = "btn_nota3";
            this.btn_nota3.Size = new System.Drawing.Size(75, 23);
            this.btn_nota3.TabIndex = 2;
            this.btn_nota3.Text = "nota #3:";
            this.btn_nota3.UseVisualStyleBackColor = true;
            // 
            // btn_nota4
            // 
            this.btn_nota4.Location = new System.Drawing.Point(249, 139);
            this.btn_nota4.Name = "btn_nota4";
            this.btn_nota4.Size = new System.Drawing.Size(75, 23);
            this.btn_nota4.TabIndex = 3;
            this.btn_nota4.Text = "Nota #4:";
            this.btn_nota4.UseVisualStyleBackColor = true;
            // 
            // btn_Notafinal
            // 
            this.btn_Notafinal.Location = new System.Drawing.Point(136, 191);
            this.btn_Notafinal.Name = "btn_Notafinal";
            this.btn_Notafinal.Size = new System.Drawing.Size(75, 23);
            this.btn_Notafinal.TabIndex = 4;
            this.btn_Notafinal.Text = "Nota final:";
            this.btn_Notafinal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido a la app de calculo de notas";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(120, 75);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(120, 140);
            this.maskedTextBox2.Mask = "99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 7;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(349, 74);
            this.maskedTextBox3.Mask = "99";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox3.TabIndex = 8;
            this.maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(349, 139);
            this.maskedTextBox4.Mask = "99";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox4.TabIndex = 9;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // txt_notfinal
            // 
            this.txt_notfinal.Location = new System.Drawing.Point(249, 191);
            this.txt_notfinal.Name = "txt_notfinal";
            this.txt_notfinal.Size = new System.Drawing.Size(100, 23);
            this.txt_notfinal.TabIndex = 10;
            // 
            // btn_CALCULARNOTA
            // 
            this.btn_CALCULARNOTA.Location = new System.Drawing.Point(82, 278);
            this.btn_CALCULARNOTA.Name = "btn_CALCULARNOTA";
            this.btn_CALCULARNOTA.Size = new System.Drawing.Size(75, 23);
            this.btn_CALCULARNOTA.TabIndex = 11;
            this.btn_CALCULARNOTA.Text = "Calcular nota";
            this.btn_CALCULARNOTA.UseVisualStyleBackColor = true;
            this.btn_CALCULARNOTA.Click += new System.EventHandler(this.btn_CALCULARNOTA_Click);
            // 
            // btn_LIMPIAR
            // 
            this.btn_LIMPIAR.Location = new System.Drawing.Point(202, 278);
            this.btn_LIMPIAR.Name = "btn_LIMPIAR";
            this.btn_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.btn_LIMPIAR.TabIndex = 12;
            this.btn_LIMPIAR.Text = "Limpiar";
            this.btn_LIMPIAR.UseVisualStyleBackColor = true;
            this.btn_LIMPIAR.Click += new System.EventHandler(this.btn_LIMPIAR_Click);
            // 
            // btn_SALIR
            // 
            this.btn_SALIR.Location = new System.Drawing.Point(324, 278);
            this.btn_SALIR.Name = "btn_SALIR";
            this.btn_SALIR.Size = new System.Drawing.Size(75, 23);
            this.btn_SALIR.TabIndex = 13;
            this.btn_SALIR.Text = "Salir";
            this.btn_SALIR.UseVisualStyleBackColor = true;
            this.btn_SALIR.Click += new System.EventHandler(this.btn_SALIR_Click);
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 386);
            this.Controls.Add(this.btn_SALIR);
            this.Controls.Add(this.btn_LIMPIAR);
            this.Controls.Add(this.btn_CALCULARNOTA);
            this.Controls.Add(this.txt_notfinal);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Notafinal);
            this.Controls.Add(this.btn_nota4);
            this.Controls.Add(this.btn_nota3);
            this.Controls.Add(this.btn_nota2);
            this.Controls.Add(this.btn_nota1);
            this.Name = "Notas";
            this.Text = "Curso de verano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_nota1;
        private Button btn_nota2;
        private Button btn_nota3;
        private Button btn_nota4;
        private Button btn_Notafinal;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private TextBox txt_notfinal;
        private Button btn_CALCULARNOTA;
        private Button btn_LIMPIAR;
        private Button btn_SALIR;
    }
}