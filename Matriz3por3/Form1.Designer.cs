namespace Matriz3por3
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtNum3 = new TextBox();
            txtNum4 = new TextBox();
            txtNum5 = new TextBox();
            txtNum6 = new TextBox();
            lsbPromedio = new ListBox();
            txtNum7 = new TextBox();
            txtNum8 = new TextBox();
            txtNum9 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(70, 48);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(48, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(156, 48);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(48, 23);
            txtNum2.TabIndex = 1;
            // 
            // txtNum3
            // 
            txtNum3.Location = new Point(245, 48);
            txtNum3.Name = "txtNum3";
            txtNum3.Size = new Size(48, 23);
            txtNum3.TabIndex = 2;
            // 
            // txtNum4
            // 
            txtNum4.Location = new Point(70, 102);
            txtNum4.Name = "txtNum4";
            txtNum4.Size = new Size(48, 23);
            txtNum4.TabIndex = 3;
            // 
            // txtNum5
            // 
            txtNum5.Location = new Point(156, 102);
            txtNum5.Name = "txtNum5";
            txtNum5.Size = new Size(48, 23);
            txtNum5.TabIndex = 4;
            // 
            // txtNum6
            // 
            txtNum6.Location = new Point(245, 102);
            txtNum6.Name = "txtNum6";
            txtNum6.Size = new Size(48, 23);
            txtNum6.TabIndex = 5;
            // 
            // lsbPromedio
            // 
            lsbPromedio.FormattingEnabled = true;
            lsbPromedio.ItemHeight = 15;
            lsbPromedio.Location = new Point(12, 221);
            lsbPromedio.Name = "lsbPromedio";
            lsbPromedio.Size = new Size(281, 94);
            lsbPromedio.TabIndex = 6;
            // 
            // txtNum7
            // 
            txtNum7.Location = new Point(70, 162);
            txtNum7.Name = "txtNum7";
            txtNum7.Size = new Size(48, 23);
            txtNum7.TabIndex = 7;
            // 
            // txtNum8
            // 
            txtNum8.Location = new Point(156, 162);
            txtNum8.Name = "txtNum8";
            txtNum8.Size = new Size(48, 23);
            txtNum8.TabIndex = 8;
            // 
            // txtNum9
            // 
            txtNum9.Location = new Point(245, 162);
            txtNum9.Name = "txtNum9";
            txtNum9.Size = new Size(48, 23);
            txtNum9.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(144, 327);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 362);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum9);
            Controls.Add(txtNum8);
            Controls.Add(txtNum7);
            Controls.Add(lsbPromedio);
            Controls.Add(txtNum6);
            Controls.Add(txtNum5);
            Controls.Add(txtNum4);
            Controls.Add(txtNum3);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtNum4;
        private TextBox txtNum5;
        private TextBox txtNum6;
        private ListBox lsbPromedio;
        private TextBox txtNum7;
        private TextBox txtNum8;
        private TextBox txtNum9;
        private Button btnCalcular;
    }
}
