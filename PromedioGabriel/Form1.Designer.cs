namespace PromedioGabriel
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnAgregar = new Button();
            lsbResultados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del estudiante";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 26);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 26);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 26);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Nota 3";
            
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(199, 44);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(42, 23);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(278, 44);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(39, 23);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(352, 44);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(39, 23);
            txtNota3.TabIndex = 7;
            
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(416, 44);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agragar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lsbResultados
            // 
            lsbResultados.FormattingEnabled = true;
            lsbResultados.ItemHeight = 15;
            lsbResultados.Location = new Point(12, 107);
            lsbResultados.Name = "lsbResultados";
            lsbResultados.Size = new Size(488, 94);
            lsbResultados.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 268);
            Controls.Add(lsbResultados);
            Controls.Add(btnAgregar);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnAgregar;
        private ListBox lsbResultados;
    }
}
