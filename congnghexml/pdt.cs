using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace congnghexml
{
    public partial class pdt : Form
    {
        public pdt()
        {
            InitializeComponent();
        }

        private void pdt_Load(object sender, EventArgs e)
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

            // Load tìm kiếm (bao gồm cả mã bệnh nhân và mã điều trị)
            string queryTimKiem = "SELECT DISTINCT mabn FROM PhieuDieuTri UNION SELECT DISTINCT madt FROM PhieuDieuTri";
            DataTable dtTimKiem = DatabaseHelper.ExecuteQuery(queryTimKiem);
            cbbTimKiem.DataSource = dtTimKiem;
            cbbTimKiem.DisplayMember = "mabn"; // Hiển thị mã
        }

        private void LoadDataGrid()
        {
            string query = @"SELECT PDT.madt, PDT.chiphi, BN.tenbn, PDT.mabn
                             FROM PhieuDieuTri PDT
                             JOIN BenhNhan BN ON PDT.mabn = BN.mabn";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            DataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Thêm phiếu điều trị
            string query = @"INSERT INTO PhieuDieuTri (madt, chiphi, mabn)
                             VALUES (@madt, @chiphi, @mabn)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@madt", txtmadt.Text),
                new SqlParameter("@chiphi", decimal.Parse(txtchiphi.Text)),
                new SqlParameter("@mabn", cbbmabn.SelectedValue)
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
            // Cập nhật phiếu điều trị
            string query = @"UPDATE PhieuDieuTri
                             SET chiphi = @chiphi, mabn = @mabn
                             WHERE madt = @madt";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@madt", txtmadt.Text),
                new SqlParameter("@chiphi", decimal.Parse(txtchiphi.Text)),
                new SqlParameter("@mabn", cbbmabn.SelectedValue)
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
            // Xóa phiếu điều trị
            string query = @"DELETE FROM PhieuDieuTri
                             WHERE madt = @madt";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@madt", txtmadt.Text)
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
            // Tìm kiếm theo mã bệnh nhân hoặc mã điều trị
            string query = @"SELECT PDT.madt, PDT.chiphi, BN.tenbn, PDT.mabn
                             FROM PhieuDieuTri PDT
                             JOIN BenhNhan BN ON PDT.mabn = BN.mabn
                             WHERE PDT.madt = @timkiem OR PDT.mabn = @timkiem";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@timkiem", cbbTimKiem.Text)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            DataGridView1.DataSource = dt;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // Reset form
            txtmadt.Clear();
            txtchiphi.Clear();
            cbbmabn.SelectedIndex = -1;
            cbbTimKiem.SelectedIndex = -1;
            LoadDataGrid();
        }
    }
}
