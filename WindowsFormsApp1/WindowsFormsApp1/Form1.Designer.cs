
namespace WindowsFormsApp1
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.lbl_EDAD = new System.Windows.Forms.Label();
            this.txt_EDAD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(28, 147);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.Location = new System.Drawing.Point(187, 147);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(75, 23);
            this.btn_CLOSE.TabIndex = 1;
            this.btn_CLOSE.Text = "Cancelar";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // lbl_EDAD
            // 
            this.lbl_EDAD.AutoSize = true;
            this.lbl_EDAD.Location = new System.Drawing.Point(25, 66);
            this.lbl_EDAD.Name = "lbl_EDAD";
            this.lbl_EDAD.Size = new System.Drawing.Size(35, 13);
            this.lbl_EDAD.TabIndex = 2;
            this.lbl_EDAD.Text = "Edad:";
            // 
            // txt_EDAD
            // 
            this.txt_EDAD.Location = new System.Drawing.Point(102, 66);
            this.txt_EDAD.Name = "txt_EDAD";
            this.txt_EDAD.Size = new System.Drawing.Size(100, 20);
            this.txt_EDAD.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 194);
            this.Controls.Add(this.txt_EDAD);
            this.Controls.Add(this.lbl_EDAD);
            this.Controls.Add(this.btn_CLOSE);
            this.Controls.Add(this.btn_OK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_CLOSE;
        private System.Windows.Forms.Label lbl_EDAD;
        private System.Windows.Forms.TextBox txt_EDAD;
    }
}

