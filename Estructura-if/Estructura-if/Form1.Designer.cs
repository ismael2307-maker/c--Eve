
namespace Estructura_if
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
            this.lbl_USUARIO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_USUARIO = new System.Windows.Forms.TextBox();
            this.txt_CONTRA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(41, 161);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.Location = new System.Drawing.Point(186, 161);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(75, 23);
            this.btn_CLOSE.TabIndex = 1;
            this.btn_CLOSE.Text = "Cancelar";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // lbl_USUARIO
            // 
            this.lbl_USUARIO.AutoSize = true;
            this.lbl_USUARIO.Location = new System.Drawing.Point(16, 24);
            this.lbl_USUARIO.Name = "lbl_USUARIO";
            this.lbl_USUARIO.Size = new System.Drawing.Size(46, 13);
            this.lbl_USUARIO.TabIndex = 2;
            this.lbl_USUARIO.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // txt_USUARIO
            // 
            this.txt_USUARIO.Location = new System.Drawing.Point(104, 24);
            this.txt_USUARIO.Name = "txt_USUARIO";
            this.txt_USUARIO.Size = new System.Drawing.Size(132, 20);
            this.txt_USUARIO.TabIndex = 4;
            // 
            // txt_CONTRA
            // 
            this.txt_CONTRA.Location = new System.Drawing.Point(104, 94);
            this.txt_CONTRA.Name = "txt_CONTRA";
            this.txt_CONTRA.Size = new System.Drawing.Size(132, 20);
            this.txt_CONTRA.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 196);
            this.Controls.Add(this.txt_CONTRA);
            this.Controls.Add(this.txt_USUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_USUARIO);
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
        private System.Windows.Forms.Label lbl_USUARIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_USUARIO;
        private System.Windows.Forms.TextBox txt_CONTRA;
    }
}

