namespace QuanLyBanHang
{
    partial class frmKhachHang
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
            this.textMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaUuDai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(269, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMaKH
            // 
            this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textMaKH.Location = new System.Drawing.Point(596, 47);
            this.textMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textMaKH.Name = "textMaKH";
            this.textMaKH.Size = new System.Drawing.Size(300, 26);
            this.textMaKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(269, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // textTenKH
            // 
            this.textTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textTenKH.Location = new System.Drawing.Point(596, 125);
            this.textTenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTenKH.Name = "textTenKH";
            this.textTenKH.Size = new System.Drawing.Size(300, 26);
            this.textTenKH.TabIndex = 3;
            this.textTenKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(269, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // textSdt
            // 
            this.textSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textSdt.Location = new System.Drawing.Point(596, 202);
            this.textSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(300, 26);
            this.textSdt.TabIndex = 5;
            this.textSdt.TextChanged += new System.EventHandler(this.textSdt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(269, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã ưu đãi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textMaUuDai
            // 
            this.textMaUuDai.Location = new System.Drawing.Point(596, 281);
            this.textMaUuDai.Name = "textMaUuDai";
            this.textMaUuDai.Size = new System.Drawing.Size(300, 26);
            this.textMaUuDai.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Xoa);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1102, 281);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(538, 358);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(75, 36);
            this.Sua.TabIndex = 11;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 764);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMaUuDai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMaKH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaUuDai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Sua;
    }
}

