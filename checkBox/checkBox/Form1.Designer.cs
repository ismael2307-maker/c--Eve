
namespace checkBox
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
            this.checkMonitor = new System.Windows.Forms.CheckBox();
            this.checkTeclado = new System.Windows.Forms.CheckBox();
            this.checkMouse = new System.Windows.Forms.CheckBox();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkMonitor
            // 
            this.checkMonitor.AutoSize = true;
            this.checkMonitor.Location = new System.Drawing.Point(31, 53);
            this.checkMonitor.Name = "checkMonitor";
            this.checkMonitor.Size = new System.Drawing.Size(88, 17);
            this.checkMonitor.TabIndex = 0;
            this.checkMonitor.Text = "Monitor $250";
            this.checkMonitor.UseVisualStyleBackColor = true;
            // 
            // checkTeclado
            // 
            this.checkTeclado.AutoSize = true;
            this.checkTeclado.Location = new System.Drawing.Point(31, 86);
            this.checkTeclado.Name = "checkTeclado";
            this.checkTeclado.Size = new System.Drawing.Size(86, 17);
            this.checkTeclado.TabIndex = 1;
            this.checkTeclado.Text = "Teclado $15";
            this.checkTeclado.UseVisualStyleBackColor = true;
            // 
            // checkMouse
            // 
            this.checkMouse.AutoSize = true;
            this.checkMouse.Location = new System.Drawing.Point(31, 119);
            this.checkMouse.Name = "checkMouse";
            this.checkMouse.Size = new System.Drawing.Size(79, 17);
            this.checkMouse.TabIndex = 2;
            this.checkMouse.Text = "Mouse $20";
            this.checkMouse.UseVisualStyleBackColor = true;
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Location = new System.Drawing.Point(31, 165);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(35, 13);
            this.lbl_Mensaje.TabIndex = 3;
            this.lbl_Mensaje.Text = "label1";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(166, 53);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.Location = new System.Drawing.Point(166, 86);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(75, 23);
            this.btn_CLOSE.TabIndex = 5;
            this.btn_CLOSE.Text = "Salir";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 284);
            this.Controls.Add(this.btn_CLOSE);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.checkMouse);
            this.Controls.Add(this.checkTeclado);
            this.Controls.Add(this.checkMonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkMonitor;
        private System.Windows.Forms.CheckBox checkTeclado;
        private System.Windows.Forms.CheckBox checkMouse;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_CLOSE;
    }
}

