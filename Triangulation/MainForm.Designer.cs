namespace Triangulation
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawPolygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImg = new System.Windows.Forms.OpenFileDialog();
            this.SaveImg = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainImage = new System.Windows.Forms.PictureBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FinalImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreCluster = new System.Windows.Forms.CheckBox();
            this.UserDeepSearch = new System.Windows.Forms.CheckBox();
            this.DrawPoly = new System.Windows.Forms.CheckBox();
            this.GraphASE = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.PartCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Triang = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FinalImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainChart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.10201F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.89799F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1202, 549);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainImage
            // 
            this.MainImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainImage.Location = new System.Drawing.Point(3, 3);
            this.MainImage.Name = "MainImage";
            this.MainImage.Size = new System.Drawing.Size(595, 302);
            this.MainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainImage.TabIndex = 1;
            this.MainImage.TabStop = false;
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainChart.Location = new System.Drawing.Point(604, 311);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(595, 235);
            this.MainChart.TabIndex = 4;
            this.MainChart.Text = "chart1";
            // 
            // FinalImage
            // 
            this.FinalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FinalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalImage.Location = new System.Drawing.Point(604, 3);
            this.FinalImage.Name = "FinalImage";
            this.FinalImage.Size = new System.Drawing.Size(595, 302);
            this.FinalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FinalImage.TabIndex = 5;
            this.FinalImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Triang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PartCount);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Controls.Add(this.GraphASE);
            this.panel1.Controls.Add(this.DrawPoly);
            this.panel1.Controls.Add(this.UserDeepSearch);
            this.panel1.Controls.Add(this.PreCluster);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 235);
            this.panel1.TabIndex = 6;
            // 
            // PreCluster
            // 
            this.PreCluster.AutoSize = true;
            this.PreCluster.Location = new System.Drawing.Point(27, 21);
            this.PreCluster.Name = "PreCluster";
            this.PreCluster.Size = new System.Drawing.Size(197, 17);
            this.PreCluster.TabIndex = 0;
            this.PreCluster.Text = "Предварительная кластеризация";
            this.PreCluster.UseVisualStyleBackColor = true;
            // 
            // UserDeepSearch
            // 
            this.UserDeepSearch.AutoSize = true;
            this.UserDeepSearch.Location = new System.Drawing.Point(27, 67);
            this.UserDeepSearch.Name = "UserDeepSearch";
            this.UserDeepSearch.Size = new System.Drawing.Size(219, 17);
            this.UserDeepSearch.TabIndex = 1;
            this.UserDeepSearch.Text = "Использовать глубокий поиск границ";
            this.UserDeepSearch.UseVisualStyleBackColor = true;
            // 
            // DrawPoly
            // 
            this.DrawPoly.AutoSize = true;
            this.DrawPoly.Location = new System.Drawing.Point(27, 90);
            this.DrawPoly.Name = "DrawPoly";
            this.DrawPoly.Size = new System.Drawing.Size(153, 17);
            this.DrawPoly.TabIndex = 2;
            this.DrawPoly.Text = "Обрисовывать полигоны";
            this.DrawPoly.UseVisualStyleBackColor = true;
            // 
            // GraphASE
            // 
            this.GraphASE.AutoSize = true;
            this.GraphASE.Location = new System.Drawing.Point(27, 113);
            this.GraphASE.Name = "GraphASE";
            this.GraphASE.Size = new System.Drawing.Size(112, 17);
            this.GraphASE.TabIndex = 3;
            this.GraphASE.Text = "Нарисовать СКО";
            this.GraphASE.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Red;
            this.Start.Location = new System.Drawing.Point(27, 180);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(252, 46);
            this.Start.TabIndex = 4;
            this.Start.Text = "Начать обработку";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // PartCount
            // 
            this.PartCount.Location = new System.Drawing.Point(402, 18);
            this.PartCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PartCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PartCount.Name = "PartCount";
            this.PartCount.Size = new System.Drawing.Size(190, 20);
            this.PartCount.TabIndex = 5;
            this.PartCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во цветов";
            // 
            // Triang
            // 
            this.Triang.AutoSize = true;
            this.Triang.Location = new System.Drawing.Point(27, 44);
            this.Triang.Name = "Triang";
            this.Triang.Size = new System.Drawing.Size(185, 17);
            this.Triang.TabIndex = 7;
            this.Triang.Text = "Триангулировать изображение";
            this.Triang.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Image Triangulation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangulateToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenImg;
        private System.Windows.Forms.SaveFileDialog SaveImg;
        private System.Windows.Forms.ToolStripMenuItem drawPolygonsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox MainImage;
        private System.Windows.Forms.PictureBox FinalImage;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox DrawPoly;
        private System.Windows.Forms.CheckBox UserDeepSearch;
        private System.Windows.Forms.CheckBox PreCluster;
        private System.Windows.Forms.CheckBox GraphASE;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PartCount;
        private System.Windows.Forms.CheckBox Triang;
    }
}

