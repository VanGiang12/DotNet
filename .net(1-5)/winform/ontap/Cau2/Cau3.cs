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

namespace Cau2
{
    public partial class Cau3 : Form
    {
        public Cau3()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtQQ.Clear();
            cboKhoa.SelectedIndex = -1;
            dtpNS.Value = DateTime.Now;
        }

        private void Cau3_Load(object sender, EventArgs e)
        {
            dgvDS.DataSource = Connection.getDS("");
            dgvDS.ClearSelection();
            dgvDS.Columns[0].HeaderText = "Má SV";
            dgvDS.Columns[1].HeaderText = "Tên SV";
            dgvDS.Columns[2].HeaderText = "Ngày sinh";
            dgvDS.Columns[3].HeaderText = "Khoa";
            dgvDS.Columns[4].HeaderText = "Quê quán";
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dgvDS.DataSource = Connection.getDS("");
            dgvDS.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connection.connection())
            {
                con.Open();
                int ma;
                if (!string.IsNullOrEmpty(txtMa.Text) && !string.IsNullOrEmpty(txtTen.Text)
                    && !string.IsNullOrEmpty(txtQQ.Text) && cboKhoa.SelectedIndex != -1
                    && dtpNS.Value.Date != DateTime.Now.Date)
                {
                    if (int.TryParse(txtMa.Text, out ma))
                    {
                        ma = int.Parse(txtMa.Text);
                        string ten = txtTen.Text;
                        DateTime ns = dtpNS.Value.Date;
                        string khoa = cboKhoa.SelectedItem.ToString();
                        string qq = txtQQ.Text;

                        string sql = "insert into sv values(" + ma + ",N'" + ten + "','" + ns + "',N'" + khoa + "',N'" + qq + "')";
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        btnHienThi_Click(sender, e);
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Mã phải là kiểu nguyên","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connection.connection())
            {
                con.Open();
                int ma;
                if (!string.IsNullOrEmpty(txtMa.Text) && !string.IsNullOrEmpty(txtTen.Text)
                    && !string.IsNullOrEmpty(txtQQ.Text) && cboKhoa.SelectedIndex != -1
                    && dtpNS.Value.Date != DateTime.Now.Date)
                {
                    if (int.TryParse(txtMa.Text, out ma))
                    {
                        ma = int.Parse(txtMa.Text);
                        string ten = txtTen.Text;
                        DateTime ns = dtpNS.Value.Date;
                        string khoa = cboKhoa.SelectedItem.ToString();
                        string qq = txtQQ.Text;

                        string sql = "update sv set HoTen=N'" + ten + "',NgaySinh='" + ns + "',Khoa=N'" + khoa + "',QueQuan=N'" + qq + "' where MaSinhVien=" + ma + "";
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        btnHienThi_Click(sender, e);
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Mã phải là kiểu nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ dữ liệu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Connection.connection())
            {
                con.Open();
                if (dgvDS.SelectedRows.Count > 0)
                {
                    int ma = int.Parse(txtMa.Text);

                    string sql = "delete from sv where MaSinhVien=" + ma + "";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    btnHienThi_Click(sender, e);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("chưa chọn hàng để xóa", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex != -1)
            {
                dgvDS.DataSource = Connection.getDS("where Khoa=N'" + cboKhoa.SelectedItem.ToString() + "'");
                dgvDS.ClearSelection();
            }
            else
            {
                MessageBox.Show("chưa chọn khoa để tìm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDS.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                dtpNS.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                cboKhoa.SelectedItem = row.Cells[3].Value.ToString();
                txtQQ.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
