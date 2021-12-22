namespace Otel.Presentation
{
    partial class frmMain
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
            this.otelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otelİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otelİşlemleriToolStripMenuItem
            // 
            this.otelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otelEkleToolStripMenuItem});
            this.otelİşlemleriToolStripMenuItem.Name = "otelİşlemleriToolStripMenuItem";
            this.otelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.otelİşlemleriToolStripMenuItem.Text = "Otel İşlemleri";
            // 
            // otelEkleToolStripMenuItem
            // 
            this.otelEkleToolStripMenuItem.Name = "otelEkleToolStripMenuItem";
            this.otelEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otelEkleToolStripMenuItem.Text = "Otel Ekle";
            this.otelEkleToolStripMenuItem.Click += new System.EventHandler(this.otelEkleToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otelEkleToolStripMenuItem;
    }
}