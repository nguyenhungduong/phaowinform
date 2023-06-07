namespace QLDichvu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpDữLiệuChoBảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứngTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuChoBảngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDữLiệuChoBảngToolStripMenuItem
            // 
            this.nhậpDữLiệuChoBảngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dịchToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.chứngTừToolStripMenuItem,
            this.inKháchHàngToolStripMenuItem});
            this.nhậpDữLiệuChoBảngToolStripMenuItem.Name = "nhậpDữLiệuChoBảngToolStripMenuItem";
            this.nhậpDữLiệuChoBảngToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.nhậpDữLiệuChoBảngToolStripMenuItem.Text = "Nhập dữ liệu cho bảng";
            // 
            // dịchToolStripMenuItem
            // 
            this.dịchToolStripMenuItem.Name = "dịchToolStripMenuItem";
            this.dịchToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dịchToolStripMenuItem.Text = "Dịch vụ ";
            this.dịchToolStripMenuItem.Click += new System.EventHandler(this.dịchToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // chứngTừToolStripMenuItem
            // 
            this.chứngTừToolStripMenuItem.Name = "chứngTừToolStripMenuItem";
            this.chứngTừToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chứngTừToolStripMenuItem.Text = "Chứng từ";
            this.chứngTừToolStripMenuItem.Click += new System.EventHandler(this.chứngTừToolStripMenuItem_Click);
            // 
            // inKháchHàngToolStripMenuItem
            // 
            this.inKháchHàngToolStripMenuItem.Name = "inKháchHàngToolStripMenuItem";
            this.inKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inKháchHàngToolStripMenuItem.Text = "In khách hàng";
            this.inKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.inKháchHàngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuChoBảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứngTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inKháchHàngToolStripMenuItem;
    }
}

