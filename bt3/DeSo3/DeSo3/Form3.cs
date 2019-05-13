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
using System.Configuration;

namespace DeSo3
{
    public partial class F_TTChiTiet : Form
    {
        //string sql = @"Data Source=DESKTOP-88NIE12;Initial Catalog=QLTV;Integrated Security=True";
        public F_TTChiTiet()
        {
            InitializeComponent();
        }

        private void loadnhaxb()
        {
            try
            {
                DataTable nxb = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select NhaXB.TenNXB, NhaXB.DiaChi from NhaXB where MaNXB ='" + txtmanxb.Text + "'", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(nxb);
                    foreach(DataRow r in nxb.Rows)
                    {
                        txttennxb.Text = r["TenNXB"].ToString();
                        txtdiachi.Text = r["DiaChi"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }
        }
        private bool ktratrungnxb()
        {

            bool kiemtra = false;
            string manxb = txtmanxb.Text;
            try
            {
                DataTable trung = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select NhaXB.MaNXB from NhaXB where NhaXB.MaNXB='" + manxb + "'", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(trung);
                    if (trung.Rows.Count > 0)
                    {
                        kiemtra = true;
                    }
                    da.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!", ex.Message);
            }
            return kiemtra;
        }
        private void F_TTChiTiet_Load(object sender, EventArgs e)
        {
            txtmanxb.Text = F_QLSach.nhaxb.MaNXB;
            loadnhaxb();

            txtmanxb.ReadOnly = true;
            txttennxb.ReadOnly = true;
            txtdiachi.ReadOnly = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txttennxb.ReadOnly = false;
            txtmanxb.ReadOnly = false;
            txtdiachi.ReadOnly = false;

            txtmanxb.Clear();
            txttennxb.Clear();
            txtdiachi.Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable nxb = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select * from NhaXB", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                using (SqlCommandBuilder builder = new SqlCommandBuilder(da))
                {
                    da.FillSchema(nxb, SchemaType.Source);
                    da.Fill(nxb);

                    DataRow them = nxb.NewRow();

                    if (txtmanxb.Text == "" && txttennxb.Text == "" && txtdiachi.Text == "")
                    {
                        MessageBox.Show("Hãy điền thông tin.", "Thông Báo");
                        txtmanxb.Focus();
                    }
                    else if (txttennxb.Text == "" && txtdiachi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Tên NXB" + "\n Địa Chỉ", "Thông Báo");
                        txttennxb.Focus();
                    }
                    else if (txtmanxb.Text == "" && txtdiachi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Mã NXB" + "\n Địa Chỉ", "Thông Báo");
                        txtmanxb.Focus();
                    }
                    else if (txtmanxb.Text == "" && txttennxb.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Mã NXB" + "\n Tên NXB", "Thông Báo");
                        txtmanxb.Focus();
                    }
                    else if (txtmanxb.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Mã NXB", "Thông Báo");
                        txtmanxb.Focus();
                    }
                    else if (txttennxb.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Tên NXB", "Thông Báo");
                        txttennxb.Focus();
                    }
                    else if (txtdiachi.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Địa Chỉ", "Thông Báo");
                        txtdiachi.Focus();
                    }
                    else if(ktratrungnxb())
                    {
                        MessageBox.Show("[Mã NXB : " + txtmanxb.Text + " ] đã có.");
                    }
                    else
                    {
                        them["MaNXB"] = txtmanxb.Text;
                        them["TenNXB"] = txttennxb.Text;
                        them["DiaChi"] = txtdiachi.Text;
                        DialogResult thanhcong = MessageBox.Show("Thêm [ Mã NXB : " + txtmanxb.Text + " ] thành công!!!", "Thông Báo");

                        if (thanhcong == DialogResult.OK)
                        {
                            txtmanxb.ReadOnly = true;
                            txttennxb.ReadOnly = true;
                            txtdiachi.ReadOnly = true;

                            txtmanxb.Clear();
                            txttennxb.Clear();
                            txtdiachi.Clear();
                        }
                    }
                    nxb.Rows.Add(them);
                    da.Update(nxb);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Lỗi",ex.Message);
            }
        }

        private void F_TTChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
