﻿
namespace Controles_button_textbox_label
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
            this.lbl_TEXT = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(179, 375);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(87, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.Location = new System.Drawing.Point(385, 375);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(87, 23);
            this.btn_CLOSE.TabIndex = 1;
            this.btn_CLOSE.Text = "cerrar";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // lbl_TEXT
            // 
            this.lbl_TEXT.AutoSize = true;
            this.lbl_TEXT.Location = new System.Drawing.Point(137, 65);
            this.lbl_TEXT.Name = "lbl_TEXT";
            this.lbl_TEXT.Size = new System.Drawing.Size(63, 13);
            this.lbl_TEXT.TabIndex = 2;
            this.lbl_TEXT.Text = "Bienvenido:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(223, 57);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_TEXT);
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
        private System.Windows.Forms.Label lbl_TEXT;
        private System.Windows.Forms.TextBox txt_nombre;
    }
}

