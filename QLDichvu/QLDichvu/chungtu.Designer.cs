namespace QLDichvu
{
    partial class chungtu
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.mct = new System.Windows.Forms.TextBox();
            this.sl = new System.Windows.Forms.TextBox();
            this.mkh = new System.Windows.Forms.ComboBox();
            this.mdv = new System.Windows.Forms.ComboBox();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Madv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chứng từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // time
            // 
            this.time.CustomFormat = "yyyy-mm-dd";
            this.time.Location = new System.Drawing.Point(135, 39);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(188, 22);
            this.time.TabIndex = 5;
            // 
            // mct
            // 
            this.mct.Location = new System.Drawing.Point(135, 9);
            this.mct.Name = "mct";
            this.mct.Size = new System.Drawing.Size(188, 22);
            this.mct.TabIndex = 6;
            // 
            // sl
            // 
            this.sl.Location = new System.Drawing.Point(135, 133);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(188, 22);
            this.sl.TabIndex = 7;
            // 
            // mkh
            // 
            this.mkh.FormattingEnabled = true;
            this.mkh.Location = new System.Drawing.Point(135, 67);
            this.mkh.Name = "mkh";
            this.mkh.Size = new System.Drawing.Size(188, 24);
            this.mkh.TabIndex = 8;
            // 
            // mdv
            // 
            this.mdv.FormattingEnabled = true;
            this.mdv.Location = new System.Drawing.Point(135, 99);
            this.mdv.Name = "mdv";
            this.mdv.Size = new System.Drawing.Size(188, 24);
            this.mdv.TabIndex = 9;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(471, 31);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 10;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(628, 31);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 11;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // Xóa
            // 
            this.Xóa.Location = new System.Drawing.Point(471, 93);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(75, 23);
            this.Xóa.TabIndex = 12;
            this.Xóa.Text = "xoa";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // quaylai
            // 
            this.quaylai.Location = new System.Drawing.Point(628, 93);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(75, 23);
            this.quaylai.TabIndex = 13;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = true;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mact,
            this.Ngay,
            this.Makh,
            this.Madv,
            this.Soluong});
            this.dataGridView1.Location = new System.Drawing.Point(68, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 249);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Mact
            // 
            this.Mact.DataPropertyName = "Mact";
            this.Mact.HeaderText = "Mã chứng từ";
            this.Mact.MinimumWidth = 6;
            this.Mact.Name = "Mact";
            this.Mact.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày ";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // Makh
            // 
            this.Makh.DataPropertyName = "Makh";
            this.Makh.HeaderText = "Mã khách hàng";
            this.Makh.MinimumWidth = 6;
            this.Makh.Name = "Makh";
            this.Makh.Width = 125;
            // 
            // Madv
            // 
            this.Madv.DataPropertyName = "Madv";
            this.Madv.HeaderText = "Mã dịch vụ";
            this.Madv.MinimumWidth = 6;
            this.Madv.Name = "Madv";
            this.Madv.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // chungtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.them);
            this.Controls.Add(this.mdv);
            this.Controls.Add(this.mkh);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.mct);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "chungtu";
            this.Text = "chungtu";
            this.Load += new System.EventHandler(this.chungtu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.TextBox mct;
        private System.Windows.Forms.TextBox sl;
        private System.Windows.Forms.ComboBox mkh;
        private System.Windows.Forms.ComboBox mdv;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Madv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}