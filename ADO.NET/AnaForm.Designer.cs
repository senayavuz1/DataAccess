
namespace ADO.NET
{
    partial class AnaForm
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
            this.northwindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoFirmalariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFromNorthwindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.northwindToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // northwindToolStripMenuItem
            // 
            this.northwindToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kargoFirmalariToolStripMenuItem,
            this.urunlerToolStripMenuItem,
            this.musterilerToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.selectFromNorthwindToolStripMenuItem});
            this.northwindToolStripMenuItem.Name = "northwindToolStripMenuItem";
            this.northwindToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.northwindToolStripMenuItem.Text = "Northwind";
            // 
            // kargoFirmalariToolStripMenuItem
            // 
            this.kargoFirmalariToolStripMenuItem.Name = "kargoFirmalariToolStripMenuItem";
            this.kargoFirmalariToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.kargoFirmalariToolStripMenuItem.Text = "Kargo Firmalari";
            this.kargoFirmalariToolStripMenuItem.Click += new System.EventHandler(this.kargoFirmalariToolStripMenuItem_Click);
            // 
            // urunlerToolStripMenuItem
            // 
            this.urunlerToolStripMenuItem.Name = "urunlerToolStripMenuItem";
            this.urunlerToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.urunlerToolStripMenuItem.Text = "Urunler";
            this.urunlerToolStripMenuItem.Click += new System.EventHandler(this.urunlerToolStripMenuItem_Click);
            // 
            // musterilerToolStripMenuItem
            // 
            this.musterilerToolStripMenuItem.Name = "musterilerToolStripMenuItem";
            this.musterilerToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.musterilerToolStripMenuItem.Text = "Musteriler";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // selectFromNorthwindToolStripMenuItem
            // 
            this.selectFromNorthwindToolStripMenuItem.Name = "selectFromNorthwindToolStripMenuItem";
            this.selectFromNorthwindToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.selectFromNorthwindToolStripMenuItem.Text = "Select * from Northwind";
            this.selectFromNorthwindToolStripMenuItem.Click += new System.EventHandler(this.selectFromNorthwindToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 641);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem northwindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kargoFirmalariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFromNorthwindToolStripMenuItem;
    }
}