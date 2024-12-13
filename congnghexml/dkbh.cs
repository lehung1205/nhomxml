using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace congnghexml
{
    public partial class dkbh : Form
    {
        public dkbh()
        {
            InitializeComponent();
        }

        private void dkbh_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDataGrid();
        }

        private void LoadComboBoxes()
        {
            // Load mã bệnh nhân
            string queryBenhNhan = "SELECT mabn FROM BenhNhan";
            DataTable dtBenhNhan = DatabaseHelper.ExecuteQuery(queryBenhNhan);
            cbbmabn.DataSource = dtBenhNhan;
            cbbmabn.DisplayMember = "mabn";
            cbbmabn.ValueMember = "mabn";

            // Load mã bảo hiểm
            string queryBaoHiem = "SELECT mabh FROM BaoHiem";
            DataTable dtBaoHiem = DatabaseHelper.ExecuteQuery(queryBaoHiem);
            cbbmabh.DataSource = dtBaoHiem;
            cbbmabh.DisplayMember = "mabh";
            cbbmabh.ValueMember = "mabh";

            // Tải tất cả mã bệnh nhân và mã bảo hiểm vào ComboBox cbbTimKiem
            string query = "SELECT mabn AS Code, 'Bệnh Nhân' AS Type FROM BenhNhan " +
                   "UNION " +
                   "SELECT mabh AS Code, 'Bảo Hiểm' AS Type FROM BaoHiem";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            cbbTimKiem.DataSource = dt;
            cbbTimKiem.DisplayMember = "Code";
            cbbTimKiem.ValueMember = "Code";
        }

        private void LoadDataGrid()
        {
            string query = @"SELECT DK.mabh, BH.loaibh, DK.mabn, BN.tenbn, DK.ngaydangki, DK.ngayhethan
                             FROM DangKiBaoHiem DK
                             JOIN BaoHiem BH ON DK.mabh = BH.mabh
                             JOIN BenhNhan BN ON DK.mabn = BN.mabn";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            DataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO DangKiBaoHiem (mabh, mabn, ngaydangki, ngayhethan)
                             VALUES (@mabh, @mabn, @ngaydangki, @ngayhethan)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mabh", cbbmabh.SelectedValue),
                new SqlParameter("@mabn", cbbmabn.SelectedValue),
                new SqlParameter("@ngaydangki", ngaydk.Value),
                new SqlParameter("@ngayhethan", ngayhethan.Value)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE DangKiBaoHiem
                             SET ngaydangki = @ngaydangki, ngayhethan = @ngayhethan
                             WHERE mabh = @mabh AND mabn = @mabn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mabh", cbbmabh.SelectedValue),
                new SqlParameter("@mabn", cbbmabn.SelectedValue),
                new SqlParameter("@ngaydangki", ngaydk.Value),
                new SqlParameter("@ngayhethan", ngayhethan.Value)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM DangKiBaoHiem
                             WHERE mabh = @mabh AND mabn = @mabn";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@mabh", cbbmabh.SelectedValue),
                new SqlParameter("@mabn", cbbmabn.SelectedValue)
            };

            int result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công!");
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn trong ComboBox
            string? selectedValue = cbbTimKiem.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(selectedValue))
            {
                MessageBox.Show("Vui lòng chọn một giá trị để tìm kiếm!");
                return;
            }

            // Truy vấn thông tin từ bảng dựa trên giá trị được chọn
            string query = @"SELECT DK.mabh, BH.loaibh, DK.mabn, BN.tenbn, DK.ngaydangki, DK.ngayhethan
                     FROM DangKiBaoHiem DK
                     LEFT JOIN BaoHiem BH ON DK.mabh = BH.mabh
                     LEFT JOIN BenhNhan BN ON DK.mabn = BN.mabn
                     WHERE DK.mabh = @code OR DK.mabn = @code";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@code", selectedValue)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataGridView1.DataSource = dt; // Hiển thị dữ liệu lên DataGridView
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin!");
                DataGridView1.DataSource = null;
            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            cbbmabn.SelectedIndex = -1;
            cbbmabh.SelectedIndex = -1;
            ngaydk.Value = DateTime.Now;
            ngayhethan.Value = DateTime.Now;
            LoadDataGrid();
        }

    }
}
