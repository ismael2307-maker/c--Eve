namespace Reforzamiento120224
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnotas1 = new System.Windows.Forms.TextBox();
            this.txtnotas2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnotafinal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2:";
            // 
            // txtnotas1
            // 
            this.txtnotas1.Location = new System.Drawing.Point(110, 51);
            this.txtnotas1.Name = "txtnotas1";
            this.txtnotas1.Size = new System.Drawing.Size(100, 23);
            this.txtnotas1.TabIndex = 2;
            this.txtnotas1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotas1_KeyPress);
            // 
            // txtnotas2
            // 
            this.txtnotas2.Location = new System.Drawing.Point(110, 80);
            this.txtnotas2.Name = "txtnotas2";
            this.txtnotas2.Size = new System.Drawing.Size(100, 23);
            this.txtnotas2.TabIndex = 3;
            this.txtnotas2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnotas2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota Final:";
            // 
            // txtnotafinal
            // 
            this.txtnotafinal.Enabled = false;
            this.txtnotafinal.Location = new System.Drawing.Point(110, 155);
            this.txtnotafinal.Name = "txtnotafinal";
            this.txtnotafinal.Size = new System.Drawing.Size(100, 23);
            this.txtnotafinal.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 252);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnotafinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnotas2);
            this.Controls.Add(this.txtnotas1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnotas1;
        private TextBox txtnotas2;
        private Button button1;
        private Label label3;
        private TextBox txtnotafinal;
        private Button button2;
        private Button button3;
    }
}