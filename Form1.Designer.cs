namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(386, 378);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(404, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(415, 378);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(825, 12);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(376, 378);
            dataGridView3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(128, 396);
            button1.Name = "button1";
            button1.Size = new Size(139, 110);
            button1.TabIndex = 3;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(404, 396);
            button2.Name = "button2";
            button2.Size = new Size(139, 110);
            button2.TabIndex = 4;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(680, 396);
            button3.Name = "button3";
            button3.Size = new Size(139, 110);
            button3.TabIndex = 5;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(946, 396);
            button4.Name = "button4";
            button4.Size = new Size(139, 110);
            button4.TabIndex = 6;
            button4.Text = "Tạo hoá đơn";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(190, 549);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 31);
            txtTen.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 555);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 8;
            label1.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 628);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 9;
            label2.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(190, 622);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(150, 31);
            txtSoDienThoai.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 699);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 11;
            label3.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(190, 693);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(150, 31);
            txtDiaChi.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 742);
            Controls.Add(txtDiaChi);
            Controls.Add(label3);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtTen;
        private Label label1;
        private Label label2;
        private TextBox txtSoDienThoai;
        private Label label3;
        private TextBox txtDiaChi;
    }
}
