namespace Reforzamiento120224
{
    partial class Velocidad_Lineal
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
            this.lblmetro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmetro = new System.Windows.Forms.TextBox();
            this.txtsegundos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvelo = new System.Windows.Forms.TextBox();
            this.btncalcualr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmetro
            // 
            this.lblmetro.AutoSize = true;
            this.lblmetro.Location = new System.Drawing.Point(25, 47);
            this.lblmetro.Name = "lblmetro";
            this.lblmetro.Size = new System.Drawing.Size(109, 15);
            this.lblmetro.TabIndex = 0;
            this.lblmetro.Text = "Distancia en Metro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo en Segundos:";
            // 
            // txtmetro
            // 
            this.txtmetro.Location = new System.Drawing.Point(140, 44);
            this.txtmetro.Name = "txtmetro";
            this.txtmetro.Size = new System.Drawing.Size(100, 23);
            this.txtmetro.TabIndex = 2;
            this.txtmetro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmetro_KeyPress);
            // 
            // txtsegundos
            // 
            this.txtsegundos.Location = new System.Drawing.Point(382, 44);
            this.txtsegundos.Name = "txtsegundos";
            this.txtsegundos.Size = new System.Drawing.Size(100, 23);
            this.txtsegundos.TabIndex = 3;
            this.txtsegundos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Velocidad Lineal:";
            // 
            // txtvelo
            // 
            this.txtvelo.Enabled = false;
            this.txtvelo.Location = new System.Drawing.Point(255, 132);
            this.txtvelo.Name = "txtvelo";
            this.txtvelo.Size = new System.Drawing.Size(172, 23);
            this.txtvelo.TabIndex = 5;
            // 
            // btncalcualr
            // 
            this.btncalcualr.Location = new System.Drawing.Point(230, 92);
            this.btncalcualr.Name = "btncalcualr";
            this.btncalcualr.Size = new System.Drawing.Size(75, 23);
            this.btncalcualr.TabIndex = 6;
            this.btncalcualr.Text = "CALCULAR";
            this.btncalcualr.UseVisualStyleBackColor = true;
            this.btncalcualr.Click += new System.EventHandler(this.btncalcualr_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Velocidad_Lineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 232);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncalcualr);
            this.Controls.Add(this.txtvelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsegundos);
            this.Controls.Add(this.txtmetro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmetro);
            this.Name = "Velocidad_Lineal";
            this.Text = "Velocidad_Lineal";
            this.Load += new System.EventHandler(this.Velocidad_Lineal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmetro;
        private Label label2;
        private TextBox txtmetro;
        private TextBox txtsegundos;
        private Label label3;
        private TextBox txtvelo;
        private Button btncalcualr;
        private Button button2;
        private Button button3;
    }
}