namespace Triangulation
{
    partial class Form1
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
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImg = new System.Windows.Forms.OpenFileDialog();
            this.SaveImg = new System.Windows.Forms.SaveFileDialog();
            this.drawPolygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainImage
            // 
            this.MainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainImage.Location = new System.Drawing.Point(0, 24);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(800, 464);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 0;
            this.MainImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.triangulateToolStripMenuItem,
            this.drawPolygonsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // triangulateToolStripMenuItem
            // 
            this.triangulateToolStripMenuItem.Name = "triangulateToolStripMenuItem";
            this.triangulateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triangulateToolStripMenuItem.Text = "Triangulate";
            this.triangulateToolStripMenuItem.Click += new System.EventHandler(this.triangulateToolStripMenuItem_Click);
            // 
            // drawPolygonsToolStripMenuItem
            // 
            this.drawPolygonsToolStripMenuItem.Name = "drawPolygonsToolStripMenuItem";
            this.drawPolygonsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawPolygonsToolStripMenuItem.Text = "Draw Polygons";
            this.drawPolygonsToolStripMenuItem.Click += new System.EventHandler(this.drawPolygonsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.MainImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Triangulation";
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangulateToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenImg;
        private System.Windows.Forms.SaveFileDialog SaveImg;
        private System.Windows.Forms.ToolStripMenuItem drawPolygonsToolStripMenuItem;
    }
}

