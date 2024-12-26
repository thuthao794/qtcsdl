using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Linq.Expressions;

namespace QuanLyBanHang
{
    public partial class frmKhachHang : Form
    {
        string sCon = "Data Source=DESKTOP-LAPTOP\\THAO;Initial Catalog=Banhang;Integrated Security=True";
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình kết nối DataBase");
            }
            //Lấy dữ liệu 
            string sQuery = "select * from KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "KhachHang");

            dataGridView1.DataSource = ds.Tables["KhachHang"];

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Đóng", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string sMaKH = textMaKH.Text.Trim();
            string sTenKH = textTenKH.Text.Trim();
            string sSDT = textSdt.Text.Trim();
            string sMaUuDai = textMaUuDai.Text.Trim();

            // Kiểm tra tính hợp lệ
            if (string.IsNullOrEmpty(sMaKH) || sMaKH.Length > 10 ||
                string.IsNullOrEmpty(sTenKH) || sTenKH.Length > 50 ||
                string.IsNullOrEmpty(sSDT) || sSDT.Length != 10 || !sSDT.All(char.IsDigit) ||
                string.IsNullOrEmpty(sMaUuDai) || sMaUuDai.Length > 10)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kết nối và thêm vào cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SDT, MaUuDai) VALUES (@MaKhachHang, @TenKhachHang, @SDT, @MaUuDai)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaKhachHang", sMaKH);
                    cmd.Parameters.AddWithValue("@TenKhachHang", sTenKH);
                    cmd.Parameters.AddWithValue("@SDT", sSDT);
                    cmd.Parameters.AddWithValue("@MaUuDai", sMaUuDai);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Thêm khách hàng thành công!" : "Thêm khách hàng thất bại.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells["MaKhachHang"].Value.ToString();
            textTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenKhachHang"].Value.ToString();
            textSdt.Text = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            textMaUuDai.Text = dataGridView1.Rows[e.RowIndex].Cells["MaUuDai"].Value.ToString();

            textMaKH.Enabled = false;
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string sMaKH = textMaKH.Text.Trim();
            string sTenKH = textTenKH.Text.Trim();
            string sSDT = textSdt.Text.Trim();
            string sMaUuDai = textMaUuDai.Text.Trim();

            // Kết nối và thêm vào cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang, SDT = @SDT, MaUuDai = @MaUuDai WHERE MaKhachHang = @MaKhachHang";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaKhachHang", sMaKH);
                    cmd.Parameters.AddWithValue("@TenKhachHang", sTenKH);
                    cmd.Parameters.AddWithValue("@SDT", sSDT);
                    cmd.Parameters.AddWithValue("@MaUuDai", sMaUuDai);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Cập nhật thành công!" : "Cập nhật thất bại.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void Xoa(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string sMaKH = textMaKH.Text.Trim();

            // Kết nối và thêm vào cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();
                    string query = @"
                            DELETE FROM HoaDon WHERE MaKhachHang = @MaKhachHang;
                            DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang;";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaKhachHang", sMaKH);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected > 0 ? "Xóa thành công!" : "Xóa thất bại.", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
    }
}

    
