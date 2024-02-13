namespace Ejerc1
{
    partial class Form2
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
            this.practicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practicaToolStripMenuItem
            // 
            this.practicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradosToolStripMenuItem,
            this.bienesToolStripMenuItem,
            this.utilidadToolStripMenuItem});
            this.practicaToolStripMenuItem.Name = "practicaToolStripMenuItem";
            this.practicaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.practicaToolStripMenuItem.Text = "Practica";
            // 
            // gradosToolStripMenuItem
            // 
            this.gradosToolStripMenuItem.Name = "gradosToolStripMenuItem";
            this.gradosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gradosToolStripMenuItem.Text = "Grados";
            this.gradosToolStripMenuItem.Click += new System.EventHandler(this.gradosToolStripMenuItem_Click);
            // 
            // bienesToolStripMenuItem
            // 
            this.bienesToolStripMenuItem.Name = "bienesToolStripMenuItem";
            this.bienesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bienesToolStripMenuItem.Text = "Bienes";
            this.bienesToolStripMenuItem.Click += new System.EventHandler(this.bienesToolStripMenuItem_Click);
            // 
            // utilidadToolStripMenuItem
            // 
            this.utilidadToolStripMenuItem.Name = "utilidadToolStripMenuItem";
            this.utilidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilidadToolStripMenuItem.Text = "Utilidad";
            this.utilidadToolStripMenuItem.Click += new System.EventHandler(this.utilidadToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem practicaToolStripMenuItem;
        private ToolStripMenuItem gradosToolStripMenuItem;
        private ToolStripMenuItem bienesToolStripMenuItem;
        private ToolStripMenuItem utilidadToolStripMenuItem;
    }
}