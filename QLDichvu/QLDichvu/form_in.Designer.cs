namespace QLDichvu
{
    partial class form_in
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
            this.inkh = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // inkh
            // 
            this.inkh.Location = new System.Drawing.Point(296, 33);
            this.inkh.Name = "inkh";
            this.inkh.Size = new System.Drawing.Size(75, 23);
            this.inkh.TabIndex = 0;
            this.inkh.Text = "in";
            this.inkh.UseVisualStyleBackColor = true;
            this.inkh.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(102, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(590, 282);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // form_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.inkh);
            this.Name = "form_in";
            this.Text = "form_in";
            this.Load += new System.EventHandler(this.form_in_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inkh;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}