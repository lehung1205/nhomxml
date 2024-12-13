
namespace congnghexml
{
    partial class dkbh
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbbmabn = new ComboBox();
            cbbmabh = new ComboBox();
            ngaydk = new DateTimePicker();
            ngayhethan = new DateTimePicker();
            Button1 = new Button();
            Button2 = new Button();
            Button3 = new Button();
            Button4 = new Button();
            Button5 = new Button();
            DataGridView1 = new DataGridView();
            cbbTimKiem = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(388, 35);
            label1.Name = "label1";
            label1.Size = new Size(273, 41);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký bảo hiểm";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 117);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "Mã bệnh nhân";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 221);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 1;
            label3.Text = "Mã bảo hiểm";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(472, 117);
            label4.Name = "label4";
            label4.Size = new Size(146, 41);
            label4.TabIndex = 1;
            label4.Text = "Ngày đăng ký";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(472, 221);
            label5.Name = "label5";
            label5.Size = new Size(146, 41);
            label5.TabIndex = 1;
            label5.Text = "Ngày hết hạn";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbmabn
            // 
            cbbmabn.FormattingEnabled = true;
            cbbmabn.Location = new Point(212, 127);
            cbbmabn.Name = "cbbmabn";
            cbbmabn.Size = new Size(151, 28);
            cbbmabn.TabIndex = 2;
            // 
            // cbbmabh
            // 
            cbbmabh.FormattingEnabled = true;
            cbbmabh.Location = new Point(212, 231);
            cbbmabh.Name = "cbbmabh";
            cbbmabh.Size = new Size(151, 28);
            cbbmabh.TabIndex = 2;
            // 
            // ngaydk
            // 
            ngaydk.Format = DateTimePickerFormat.Short;
            ngaydk.Location = new Point(656, 125);
            ngaydk.Name = "ngaydk";
            ngaydk.Size = new Size(107, 27);
            ngaydk.TabIndex = 3;
            // 
            // ngayhethan
            // 
            ngayhethan.Format = DateTimePickerFormat.Short;
            ngayhethan.Location = new Point(656, 229);
            ngayhethan.Name = "ngayhethan";
            ngayhethan.Size = new Size(107, 27);
            ngayhethan.TabIndex = 4;
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button1.Image = Properties.Resources.plus;
            Button1.ImageAlign = ContentAlignment.MiddleLeft;
            Button1.Location = new Point(854, 125);
            Button1.Name = "Button1";
            Button1.Size = new Size(130, 50);
            Button1.TabIndex = 6;
            Button1.Text = "Thêm";
            Button1.TextAlign = ContentAlignment.MiddleRight;
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // Button2
            // 
            Button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button2.Image = Properties.Resources.arrow;
            Button2.ImageAlign = ContentAlignment.MiddleLeft;
            Button2.Location = new Point(854, 191);
            Button2.Name = "Button2";
            Button2.RightToLeft = RightToLeft.No;
            Button2.Size = new Size(130, 50);
            Button2.TabIndex = 7;
            Button2.Text = "Sửa";
            Button2.TextAlign = ContentAlignment.MiddleRight;
            Button2.UseVisualStyleBackColor = true;
            Button2.Click += Button2_Click;
            // 
            // Button3
            // 
            Button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button3.Image = Properties.Resources.delete;
            Button3.ImageAlign = ContentAlignment.MiddleLeft;
            Button3.Location = new Point(854, 260);
            Button3.Name = "Button3";
            Button3.Size = new Size(130, 50);
            Button3.TabIndex = 6;
            Button3.Text = "Xóa";
            Button3.TextAlign = ContentAlignment.MiddleRight;
            Button3.UseVisualStyleBackColor = true;
            Button3.Click += Button5_Click;
            // 
            // Button4
            // 
            Button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button4.Image = Properties.Resources.find;
            Button4.ImageAlign = ContentAlignment.MiddleLeft;
            Button4.Location = new Point(854, 332);
            Button4.Name = "Button4";
            Button4.Size = new Size(130, 50);
            Button4.TabIndex = 7;
            Button4.Text = "Tìm kiếm";
            Button4.TextAlign = ContentAlignment.MiddleRight;
            Button4.UseVisualStyleBackColor = true;
            Button4.Click += Button4_Click;
            // 
            // Button5
            // 
            Button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Button5.Image = Properties.Resources.undo;
            Button5.ImageAlign = ContentAlignment.MiddleLeft;
            Button5.Location = new Point(854, 399);
            Button5.Name = "Button5";
            Button5.Size = new Size(130, 50);
            Button5.TabIndex = 7;
            Button5.Text = "Reset";
            Button5.TextAlign = ContentAlignment.MiddleRight;
            Button5.UseVisualStyleBackColor = true;
            Button5.Click += Button5_Click;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(38, 316);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 29;
            DataGridView1.Size = new Size(725, 286);
            DataGridView1.TabIndex = 8;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(612, 273);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(151, 28);
            cbbTimKiem.TabIndex = 2;
            // 
            // dkbh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1092, 635);
            Controls.Add(DataGridView1);
            Controls.Add(Button5);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(Button1);
            Controls.Add(ngayhethan);
            Controls.Add(ngaydk);
            Controls.Add(cbbTimKiem);
            Controls.Add(cbbmabh);
            Controls.Add(cbbmabn);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "dkbh";
            Text = "dkbh";
            Load += dkbh_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbbmabn;
        private ComboBox cbbmabh;
        private DateTimePicker ngaydk;
        private DateTimePicker ngayhethan;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button utton5;
        private DataGridView DataGridView1;
        private Button Button5;
        private ComboBox cbbTimKiem;
    }
}