namespace congnghexml
{
    partial class ThongTinBaoHiem
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
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            this.txtphantramchitra = new TextBox();
            this.txtloaibh = new TextBox();
            this.txtmabh = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtmucchitra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(855, 288);
            dataGridView1.TabIndex = 41;
            // 
            // button5
            // 
            button5.Location = new Point(975, 258);
            button5.Name = "button5";
            button5.Size = new Size(128, 35);
            button5.TabIndex = 40;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(975, 193);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 38;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(975, 140);
            button2.Name = "button2";
            button2.Size = new Size(128, 35);
            button2.TabIndex = 37;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(975, 86);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 36;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtphantramchitra
            // 
            this.txtphantramchitra.Location = new Point(677, 90);
            this.txtphantramchitra.Name = "txtphantramchitra";
            this.txtphantramchitra.Size = new Size(207, 27);
            this.txtphantramchitra.TabIndex = 31;
            // 
            // txtloaibh
            // 
            this.txtloaibh.Location = new Point(186, 144);
            this.txtloaibh.Name = "txtloaibh";
            this.txtloaibh.Size = new Size(174, 27);
            this.txtloaibh.TabIndex = 29;
            // 
            // txtmabh
            // 
            this.txtmabh.Location = new Point(186, 90);
            this.txtmabh.Name = "txtmabh";
            this.txtmabh.Size = new Size(174, 27);
            this.txtmabh.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 147);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 25;
            label5.Text = "Mức chi trả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 147);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 24;
            label4.Text = "Loại bảo hiểm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(522, 93);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 23;
            label3.Text = "Phần trăm chi trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 93);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 22;
            label2.Text = "Mã bảo hiểm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(353, 27);
            label1.Name = "label1";
            label1.Size = new Size(286, 29);
            label1.TabIndex = 21;
            label1.Text = "THÔNG TIN BẢO HIỂM";
            // 
            // txtmucchitra
            // 
            txtmucchitra.Location = new Point(677, 140);
            txtmucchitra.Name = "txtmucchitra";
            txtmucchitra.Size = new Size(207, 27);
            txtmucchitra.TabIndex = 42;
            // 
            // ThongTinBaoHiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 600);
            Controls.Add(txtmucchitra);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(this.txtphantramchitra);
            Controls.Add(this.txtloaibh);
            Controls.Add(this.txtmabh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThongTinBaoHiem";
            Text = "Thông tin bảo hiểm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label8;
        private TextBox txtphantramchitra;
        private TextBox txtloaibh;
        private TextBox txtmabh;
        private TextBox tbmabn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtmucchitra;
        private TextBox tbtimkiem;
    }
}