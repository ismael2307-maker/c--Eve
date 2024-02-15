namespace Reforzamiento120224
{
    partial class Numero_Primo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtprimo = new System.Windows.Forms.TextBox();
            this.btnveri = new System.Windows.Forms.Button();
            this.lblprimo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite Numero entero:";
            // 
            // txtprimo
            // 
            this.txtprimo.Location = new System.Drawing.Point(173, 35);
            this.txtprimo.Name = "txtprimo";
            this.txtprimo.Size = new System.Drawing.Size(100, 23);
            this.txtprimo.TabIndex = 1;
            this.txtprimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimo_KeyPress);
            // 
            // btnveri
            // 
            this.btnveri.Location = new System.Drawing.Point(156, 83);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(75, 23);
            this.btnveri.TabIndex = 2;
            this.btnveri.Text = "VERIFICAR";
            this.btnveri.UseVisualStyleBackColor = true;
            this.btnveri.Click += new System.EventHandler(this.btnveri_Click);
            // 
            // lblprimo
            // 
            this.lblprimo.AutoSize = true;
            this.lblprimo.Location = new System.Drawing.Point(32, 128);
            this.lblprimo.Name = "lblprimo";
            this.lblprimo.Size = new System.Drawing.Size(95, 15);
            this.lblprimo.TabIndex = 3;
            this.lblprimo.Text = "SU NUMERO ES :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Numero_Primo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblprimo);
            this.Controls.Add(this.btnveri);
            this.Controls.Add(this.txtprimo);
            this.Controls.Add(this.label1);
            this.Name = "Numero_Primo";
            this.Text = "Numero_Primo";
            this.Load += new System.EventHandler(this.Numero_Primo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtprimo;
        private Button btnveri;
        private Label lblprimo;
        private Button button2;
        private Button button3;
    }
}