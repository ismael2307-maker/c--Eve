
namespace RadiobuttonYgroupbox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.lbl_num1 = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_Suma = new System.Windows.Forms.RadioButton();
            this.rb_Resta = new System.Windows.Forms.RadioButton();
            this.rb_Multiplicar = new System.Windows.Forms.RadioButton();
            this.rb_Dividir = new System.Windows.Forms.RadioButton();
            this.btn_LIMPIAR = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(136, 48);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(136, 85);
            this.maskedTextBox2.Mask = "99999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.ValidatingType = typeof(int);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Dividir);
            this.groupBox1.Controls.Add(this.rb_Multiplicar);
            this.groupBox1.Controls.Add(this.rb_Resta);
            this.groupBox1.Controls.Add(this.rb_Suma);
            this.groupBox1.Location = new System.Drawing.Point(34, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(43, 299);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(87, 25);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.Location = new System.Drawing.Point(165, 299);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(87, 25);
            this.btn_CLOSE.TabIndex = 7;
            this.btn_CLOSE.Text = "Cerrar";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // lbl_num1
            // 
            this.lbl_num1.AutoSize = true;
            this.lbl_num1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num1.Location = new System.Drawing.Point(35, 52);
            this.lbl_num1.Name = "lbl_num1";
            this.lbl_num1.Size = new System.Drawing.Size(95, 14);
            this.lbl_num1.TabIndex = 8;
            this.lbl_num1.Text = "Primer numero:";
            this.lbl_num1.Click += new System.EventHandler(this.lbl_num1_Click);
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num2.Location = new System.Drawing.Point(31, 88);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(106, 14);
            this.lbl_num2.TabIndex = 9;
            this.lbl_num2.Text = "Segundo numero:";
            this.lbl_num2.Click += new System.EventHandler(this.lbl_num2_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(35, 125);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(65, 14);
            this.lbl_Resultado.TabIndex = 10;
            this.lbl_Resultado.Text = "Resultado:";
            this.lbl_Resultado.Click += new System.EventHandler(this.lbl_Resultado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rb_Suma
            // 
            this.rb_Suma.AutoSize = true;
            this.rb_Suma.Checked = true;
            this.rb_Suma.Location = new System.Drawing.Point(9, 20);
            this.rb_Suma.Name = "rb_Suma";
            this.rb_Suma.Size = new System.Drawing.Size(56, 18);
            this.rb_Suma.TabIndex = 0;
            this.rb_Suma.TabStop = true;
            this.rb_Suma.Text = "Suma";
            this.rb_Suma.UseVisualStyleBackColor = true;
            // 
            // rb_Resta
            // 
            this.rb_Resta.AutoSize = true;
            this.rb_Resta.Location = new System.Drawing.Point(9, 45);
            this.rb_Resta.Name = "rb_Resta";
            this.rb_Resta.Size = new System.Drawing.Size(56, 18);
            this.rb_Resta.TabIndex = 1;
            this.rb_Resta.Text = "Resta";
            this.rb_Resta.UseVisualStyleBackColor = true;
            // 
            // rb_Multiplicar
            // 
            this.rb_Multiplicar.AutoSize = true;
            this.rb_Multiplicar.Location = new System.Drawing.Point(9, 69);
            this.rb_Multiplicar.Name = "rb_Multiplicar";
            this.rb_Multiplicar.Size = new System.Drawing.Size(82, 18);
            this.rb_Multiplicar.TabIndex = 2;
            this.rb_Multiplicar.Text = "Multiplicar";
            this.rb_Multiplicar.UseVisualStyleBackColor = true;
            // 
            // rb_Dividir
            // 
            this.rb_Dividir.AutoSize = true;
            this.rb_Dividir.Location = new System.Drawing.Point(9, 95);
            this.rb_Dividir.Name = "rb_Dividir";
            this.rb_Dividir.Size = new System.Drawing.Size(59, 18);
            this.rb_Dividir.TabIndex = 3;
            this.rb_Dividir.Text = "Dividir";
            this.rb_Dividir.UseVisualStyleBackColor = true;
            // 
            // btn_LIMPIAR
            // 
            this.btn_LIMPIAR.Location = new System.Drawing.Point(105, 341);
            this.btn_LIMPIAR.Name = "btn_LIMPIAR";
            this.btn_LIMPIAR.Size = new System.Drawing.Size(75, 23);
            this.btn_LIMPIAR.TabIndex = 12;
            this.btn_LIMPIAR.Text = "Limpiar";
            this.btn_LIMPIAR.UseVisualStyleBackColor = true;
            this.btn_LIMPIAR.Click += new System.EventHandler(this.btn_LIMPIAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 410);
            this.Controls.Add(this.btn_LIMPIAR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_num1);
            this.Controls.Add(this.btn_CLOSE);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_CLOSE;
        private System.Windows.Forms.Label lbl_num1;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_Dividir;
        private System.Windows.Forms.RadioButton rb_Multiplicar;
        private System.Windows.Forms.RadioButton rb_Resta;
        private System.Windows.Forms.RadioButton rb_Suma;
        private System.Windows.Forms.Button btn_LIMPIAR;
    }
}

