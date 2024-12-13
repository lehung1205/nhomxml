namespace congnghexml
{
    partial class pdt
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
            DataGridView1 = new DataGridView();
            Button5 = new Button();
            Button4 = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Button1 = new Button();
            ngaydieutri = new DateTimePicker();
            cbbTimKiem = new ComboBox();
            cbbmabn = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtmadt = new TextBox();
            txtchiphi = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(73, 342);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 29;
            DataGridView1.Size = new Size(725, 259);
            DataGridView1.TabIndex = 24;
            // 
            // Button5
            // 
            Button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button5.Image = Properties.Resources.undo;
            Button5.ImageAlign = ContentAlignment.MiddleLeft;
            Button5.Location = new Point(889, 398);
            Button5.Name = "Button5";
            Button5.Size = new Size(130, 50);
            Button5.TabIndex = 21;
            Button5.Text = "Reset";
            Button5.TextAlign = ContentAlignment.MiddleRight;
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += Button5_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button4.Image = Properties.Resources.find;
            Button4.ImageAlign = ContentAlignment.MiddleLeft;
            Button4.Location = new Point(889, 331);
            Button4.Name = "Button4";
            Button4.Size = new Size(130, 50);
            Button4.TabIndex = 22;
            Button4.Text = "Tìm kiếm";
            Button4.TextAlign = ContentAlignment.MiddleRight;
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // Button3
            // 
            Button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button3.Image = Properties.Resources.delete;
            Button3.ImageAlign = ContentAlignment.MiddleLeft;
            Button3.Location = new Point(889, 259);
            Button3.Name = "Button3";
            Button3.Size = new Size(130, 50);
            Button3.TabIndex = 19;
            Button3.Text = "Xóa";
            Button3.TextAlign = ContentAlignment.MiddleRight;
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button3_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Image = Properties.Resources.arrow;
            Button2.ImageAlign = ContentAlignment.MiddleLeft;
            Button2.Location = new Point(889, 190);
            Button2.Name = "Button2";
            Button2.RightToLeft = RightToLeft.No;
            Button2.Size = new Size(130, 50);
            Button2.TabIndex = 23;
            Button2.Text = "Sửa";
            Button2.TextAlign = ContentAlignment.MiddleRight;
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Image = Properties.Resources.plus;
            Button1.ImageAlign = ContentAlignment.MiddleLeft;
            Button1.Location = new Point(889, 124);
            Button1.Name = "Button1";
            Button1.Size = new Size(130, 50);
            Button1.TabIndex = 20;
            Button1.Text = "Thêm";
            Button1.TextAlign = ContentAlignment.MiddleRight;
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // ngaydieutri
            // 
            ngaydieutri.Format = DateTimePickerFormat.Short;
            ngaydieutri.Location = new Point(680, 228);
            ngaydieutri.Name = "ngaydieutri";
            ngaydieutri.Size = new Size(151, 27);
            ngaydieutri.TabIndex = 18;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(680, 281);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(151, 28);
            cbbTimKiem.TabIndex = 14;
            // 
            // cbbmabn
            // 
            cbbmabn.FormattingEnabled = true;
            cbbmabn.Location = new Point(247, 230);
            cbbmabn.Name = "cbbmabn";
            cbbmabn.Size = new Size(151, 28);
            cbbmabn.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 220);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 10;
            label3.Text = "Mã bệnh nhân";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(507, 220);
            label5.Name = "label5";
            label5.Size = new Size(146, 41);
            label5.TabIndex = 11;
            label5.Text = "Ngày điều trị";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(507, 116);
            label4.Name = "label4";
            label4.Size = new Size(146, 41);
            label4.TabIndex = 12;
            label4.Text = "Chi phí";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 116);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 13;
            label2.Text = "Mã điều trị";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(423, 34);
            label1.Name = "label1";
            label1.Size = new Size(208, 41);
            label1.TabIndex = 9;
            label1.Text = "Phiếu điều trị";
            // 
            // txtmadt
            // 
            txtmadt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtmadt.Location = new Point(247, 124);
            txtmadt.Name = "txtmadt";
            txtmadt.Size = new Size(151, 30);
            txtmadt.TabIndex = 25;
            // 
            // txtchiphi
            // 
            txtchiphi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtchiphi.Location = new Point(680, 124);
            txtchiphi.Name = "txtchiphi";
            txtchiphi.Size = new Size(151, 30);
            txtchiphi.TabIndex = 25;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(507, 271);
            label6.Name = "label6";
            label6.Size = new Size(146, 41);
            label6.TabIndex = 11;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pdt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 635);
            Controls.Add(txtchiphi);
            Controls.Add(txtmadt);
            Controls.Add(DataGridView1);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(ngaydieutri);
            Controls.Add(cbbTimKiem);
            Controls.Add(cbbmabn);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "pdt";
            Text = "pdt";
            Load += pdt_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView1;
        private Button Button5;
        private Button Button4;
        private Button Button3;
        private Button Button2;
        private Button Button1;
        private DateTimePicker ngaydieutri;
        private DateTimePicker ngayhethan;
        private DateTimePicker ngaydk;
        private ComboBox cbbTimKiem;
        private ComboBox cbbmabn;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtmadt;
        private TextBox txtchiphi;
        private Label label6;
    }
}