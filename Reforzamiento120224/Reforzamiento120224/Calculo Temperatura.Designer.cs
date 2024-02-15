namespace Reforzamiento120224
{
    partial class Calculo_Temperatura
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
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfarenheit = new System.Windows.Forms.TextBox();
            this.txtkelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Temperatura";
            // 
            // txtcelsius
            // 
            this.txtcelsius.Location = new System.Drawing.Point(143, 120);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(100, 23);
            this.txtcelsius.TabIndex = 1;
            this.txtcelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcelsius_KeyPress);
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "Celsius",
            "Farenheit",
            "Kelvin"});
            this.cbotipo.Location = new System.Drawing.Point(143, 64);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(121, 23);
            this.cbotipo.TabIndex = 2;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(168, 242);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(96, 23);
            this.btnconvertir.TabIndex = 3;
            this.btnconvertir.Text = "CONVERTIR";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(63, 242);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(232, 297);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Farenheit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kelvin";
            // 
            // txtfarenheit
            // 
            this.txtfarenheit.Location = new System.Drawing.Point(143, 166);
            this.txtfarenheit.Name = "txtfarenheit";
            this.txtfarenheit.Size = new System.Drawing.Size(100, 23);
            this.txtfarenheit.TabIndex = 9;
            this.txtfarenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfarenheit_KeyPress);
            // 
            // txtkelvin
            // 
            this.txtkelvin.Location = new System.Drawing.Point(143, 199);
            this.txtkelvin.Name = "txtkelvin";
            this.txtkelvin.Size = new System.Drawing.Size(100, 23);
            this.txtkelvin.TabIndex = 10;
            this.txtkelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkelvin_KeyPress);
            // 
            // Calculo_Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 332);
            this.Controls.Add(this.txtkelvin);
            this.Controls.Add(this.txtfarenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.label1);
            this.Name = "Calculo_Temperatura";
            this.Text = "Calculo_Temperatura";
            this.Load += new System.EventHandler(this.Calculo_Temperatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtcelsius;
        private ComboBox cbotipo;
        private Button btnconvertir;
        private Button btnlimpiar;
        private Button btnsalir;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtfarenheit;
        private TextBox txtkelvin;
    }
}