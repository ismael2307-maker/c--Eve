
namespace Prueba1
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertidorPesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.convertidorToolStripMenuItem,
            this.convertidorPesoToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.figurasToolStripMenuItem.Text = "Figuras";
            this.figurasToolStripMenuItem.Click += new System.EventHandler(this.figurasToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            this.diagnosticoToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoToolStripMenuItem_Click);
            // 
            // convertidorToolStripMenuItem
            // 
            this.convertidorToolStripMenuItem.Name = "convertidorToolStripMenuItem";
            this.convertidorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertidorToolStripMenuItem.Text = "Convertidor Dinero";
            this.convertidorToolStripMenuItem.Click += new System.EventHandler(this.convertidorToolStripMenuItem_Click);
            // 
            // convertidorPesoToolStripMenuItem
            // 
            this.convertidorPesoToolStripMenuItem.Name = "convertidorPesoToolStripMenuItem";
            this.convertidorPesoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertidorPesoToolStripMenuItem.Text = "Convertidor Peso";
            this.convertidorPesoToolStripMenuItem.Click += new System.EventHandler(this.convertidorPesoToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertidorPesoToolStripMenuItem;
    }
}