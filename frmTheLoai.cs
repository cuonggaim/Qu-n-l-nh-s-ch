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
using QLBS.Class;

namespace QLBS
{
    public partial class frmTheLoai : Form
    {
        DataTable TheLoai;
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaLoai, TheLoai FROM TheLoai";
            TheLoai = Class.Functions.GetDataToTable(sql);
            dgvTheLoai.DataSource = TheLoai;           
            dgvTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvTheLoai.Columns[1].HeaderText = "Thể loại";
            dgvTheLoai.Columns[0].Width = 100;
            dgvTheLoai.Columns[1].Width = 300;
            dgvTheLoai.AllowUserToAddRows = false; 
            dgvTheLoai.EditMode = DataGridViewEditMode.EditProgrammatically; 
        }

        private void dgvTheLoai_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoai.Focus();
                return;
            }
            if (TheLoai.Rows.Count == 0) 
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLoai.Text = dgvTheLoai.CurrentRow.Cells["MaLoai"].Value.ToString();
            txtTheLoai.Text = dgvTheLoai.CurrentRow.Cells["TheLoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }
        private void ResetValue()
        {
            txtMaLoai.Text = "";
            txtTheLoai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); 
            txtMaLoai.Enabled = true; 
            txtTheLoai.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; 
            if (txtMaLoai.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập mã thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoai.Focus();
                return;
            }
            if (txtTheLoai.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn phải nhập thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTheLoai.Focus();
                return;
            }
            sql = "Select MaLoai From TheLoai where MaLoai=N'" + txtMaLoai.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã thể loại này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaLoai.Focus();
                return;
            }

            sql = "INSERT INTO TheLoai VALUES(N'" +
                txtMaLoai.Text + "',N'" + txtTheLoai.Text + "')";
            Class.Functions.RunSQL(sql); 
            LoadDataGridView();
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaLoai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; 
            if (TheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLoai.Text == "") 
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTheLoai.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Bạn chưa nhập thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE TheLoai SET TheLoai=N'" +
                txtTheLoai.Text.ToString() +
                "' WHERE MaLoai=N'" + txtMaLoai.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();

            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (TheLoai.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLoai.Text == "") 
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TheLoai WHERE MaLoai=N'" + txtMaLoai.Text + "'";
                Class.Functions.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaLoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
