namespace QLDichvu
{
    partial class dichvu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mdv = new System.Windows.Forms.TextBox();
            this.tdv = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // mdv
            // 
            this.mdv.Location = new System.Drawing.Point(140, 17);
            this.mdv.Name = "mdv";
            this.mdv.Size = new System.Drawing.Size(100, 22);
            this.mdv.TabIndex = 3;
            // 
            // tdv
            // 
            this.tdv.Location = new System.Drawing.Point(140, 53);
            this.tdv.Name = "tdv";
            this.tdv.Size = new System.Drawing.Size(100, 22);
            this.tdv.TabIndex = 4;
            // 
            // dg
            // 
            this.dg.Location = new System.Drawing.Point(140, 83);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(100, 22);
            this.dg.TabIndex = 5;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(414, 24);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 6;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(573, 24);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 7;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(414, 68);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // quaylai
            // 
            this.quaylai.Location = new System.Drawing.Point(573, 68);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(75, 23);
            this.quaylai.TabIndex = 9;
            this.quaylai.Text = "Quay lai";
            this.quaylai.UseVisualStyleBackColor = true;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Madv,
            this.Tendv,
            this.Dongia});
            this.dataGridView1.Location = new System.Drawing.Point(42, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 249);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Madv
            // 
            this.Madv.DataPropertyName = "Madv";
            this.Madv.HeaderText = "Mã dich vụ";
            this.Madv.MinimumWidth = 6;
            this.Madv.Name = "Madv";
            this.Madv.Width = 125;
            // 
            // Tendv
            // 
            this.Tendv.DataPropertyName = "Tendv";
            this.Tendv.HeaderText = "Tên dịch vụ";
            this.Tendv.MinimumWidth = 6;
            this.Tendv.Name = "Tendv";
            this.Tendv.Width = 125;
            // 
            // Dongia
            // 
            this.Dongia.DataPropertyName = "Dongia";
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            this.Dongia.Width = 125;
            // 
            // dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.tdv);
            this.Controls.Add(this.mdv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dichvu";
            this.Text = "dichvu";
            this.Load += new System.EventHandler(this.dichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mdv;
        private System.Windows.Forms.TextBox tdv;
        private System.Windows.Forms.TextBox dg;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
    }
}