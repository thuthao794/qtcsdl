using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmTaiKhoan : Form
    {
        string sCon = "Data Source=DESKTOP-LAPTOP\\THAO;Initial Catalog=Banhang;Integrated Security=True";

        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        // Hiển thị dữ liệu từ bảng TaiKhoan
        private void LoadTaiKhoan()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM TaiKhoan";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "TaiKhoan");
                    dataGridView1.DataSource = ds.Tables["TaiKhoan"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string chucVu = txtChucVu.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(chucVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, ChucVu) VALUES (@TenDangNhap, @MatKhau, @ChucVu)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Thêm tài khoản thành công!" : "Thêm tài khoản thất bại.", "Thông báo");
                    LoadTaiKhoan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string chucVu = txtChucVu.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập để sửa!", "Thông báo");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE TaiKhoan SET MatKhau = @MatKhau, ChucVu = @ChucVu WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Cập nhật tài khoản thành công!" : "Cập nhật thất bại.", "Thông báo");
                    LoadTaiKhoan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập để xóa!", "Thông báo");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Xóa tài khoản thành công!" : "Xóa thất bại.", "Thông báo");
                    LoadTaiKhoan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenDangNhap.Text = dataGridView1.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = dataGridView1.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString();
                txtChucVu.Text = dataGridView1.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();
            }
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Đóng", "Thông báo");
        }

        private void frmTaiKhoan_Load_1(object sender, EventArgs e)
        {

        }
    }
}

