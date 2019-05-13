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
    public partial class F_QLSach : Form
    {
        //string sql = @"Data Source=DESKTOP-88NIE12;Initial Catalog=QLTV;Integrated Security=True";
        public F_QLSach()
        {
            InitializeComponent();
        }

        public class nhaxb
        {
            static public string MaNXB;
        }

        private void loadtv()
        {
            try
            {
                DataTable tacgia = new DataTable();
                DataTable sach = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmdtg = new SqlCommand("Select TACGIA.MaTG,TACGIA.TenTG from TACGIA", conn))
                using (SqlCommand cmdsach = new SqlCommand("select SACH.Ten,SACH.MaTG from SACH inner join TACGIA on TACGIA.MaTG = SACH.MaTG", conn))
                using (SqlDataAdapter datg = new SqlDataAdapter(cmdtg))
                using (SqlDataAdapter dasach = new SqlDataAdapter(cmdsach))
                {
                    datg.Fill(tacgia);
                    dasach.Fill(sach);
                    tvdstacgia.Nodes.Clear();
                    foreach (DataRow tg in tacgia.Rows)
                    {
                        string mtg = tg["MaTG"].ToString();
                        TreeNode nodecha = new TreeNode();
                        nodecha.Text = tg["TenTG"].ToString();
                        foreach(DataRow s in sach.Rows)
                        {
                            string mtgs = s["MaTG"].ToString();
                            if(mtgs== mtg)
                            {
                                TreeNode nodecon = new TreeNode();
                                nodecon.Text = s["Ten"].ToString();
                                nodecha.Nodes.Add(nodecon);
                            }
                        }
                        tvdstacgia.Nodes.Add(nodecha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!!!", ex.Message);
            }
        }

        private void Loadcmb()
        {
            try
            {
                DataTable nhaxb = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmdnhaxb = new SqlCommand("select NhaXB.TenNXB from NhaXB", conn))
                using (SqlDataAdapter danhaxb = new SqlDataAdapter(cmdnhaxb))
                {
                    danhaxb.Fill(nhaxb);
                    cmbnhaxb.Items.Clear();
                    foreach(DataRow nxb in nhaxb.Rows)
                    {
                        cmbnhaxb.Items.Add(nxb["TenNXB"].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!!!", ex.Message);
            }
        }
        private void F_QLSach_Load(object sender, EventArgs e)
        {
            loadtv();
            Loadcmb();
            lvsach.View = View.Details;
            lvsach.Columns.Add("Mã Sách",70);
            lvsach.Columns.Add("Tên Sách",150);
            lvsach.Columns.Add("Số Lượng",70);
            lvsach.Columns.Add("Đơn Giá",100);
            lvsach.Columns.Add("Thành Tiền",100);
            lvsach.Columns.Add("Nhà Xuất Bản",150);

            txtmasach.ReadOnly = true;
            txttensach.ReadOnly = true;
            txtsoluong.ReadOnly = true;
            txtdongia.ReadOnly = true;
            cmbnhaxb.Enabled = false;
        }

        private void tvdstacgia_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                DataTable tacgia = new DataTable();
                DataTable sach = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmdsach = new SqlCommand("select SACH.MaSach,SACH.Ten,SACH.SoLuong,SACH.DonGia,(SACH.SoLuong * SACH.DonGia) as ThanhTien,SACH.MaNXB from SACH where SACH.Ten = '" + tvdstacgia.SelectedNode.Text + "'", conn))
                using (SqlCommand cmdtg = new SqlCommand("select SACH.MaSach,SACH.Ten,SACH.SoLuong,SACH.DonGia,SACH.SoLuong*SACH.DonGia as ThanhTien,SACH.MaNXB from TACGIA inner join SACH on TACGIA.MaTG = SACH.MaTG where TACGIA.TenTG = '" + tvdstacgia.SelectedNode.Text + "'", conn))
                using (SqlDataAdapter dasach = new SqlDataAdapter(cmdsach))
                using (SqlDataAdapter datg = new SqlDataAdapter(cmdtg))
                {
                    dasach.Fill(sach);
                    datg.Fill(tacgia);
                    lvsach.Items.Clear();
                    foreach (DataRow s in sach.Rows)
                    {
                        txttongtiensach.Clear();

                        txtmasach.ReadOnly = true;
                        txttensach.ReadOnly = true;
                        txtsoluong.ReadOnly = true;
                        txtdongia.ReadOnly = true;

                        txtmasach.Text = s["MaSach"].ToString();
                        txttensach.Text = s["Ten"].ToString();
                        txtsoluong.Text = s["SoLuong"].ToString();
                        txtdongia.Text = s["DonGia"].ToString();
                    }
                    foreach (DataRow tg in tacgia.Rows)
                    {
                        ListViewItem items = new ListViewItem();
                        items.Text = tg["MaSach"].ToString();
                        items.SubItems.Add(tg["Ten"].ToString());
                        items.SubItems.Add(tg["SoLuong"].ToString());
                        items.SubItems.Add(tg["DonGia"].ToString());
                        items.SubItems.Add(tg["ThanhTien"].ToString());
                        items.SubItems.Add(tg["MaNXB"].ToString());

                        lvsach.Items.Add(items);

                        int sum = 0;
                        for (int i = 0; i < lvsach.Items.Count; i++)
                        {
                            sum += Convert.ToInt32(lvsach.Items[i].SubItems[4].Text);
                        }
                        txttongtiensach.Text = sum.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!!!", ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txttongtiensach_VisibleChanged(object sender, EventArgs e)
        {
            txttongtiensach.ReadOnly = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txttongtiensach.Clear();

            txtmasach.ReadOnly = false;
            txttensach.ReadOnly = false;
            txtsoluong.ReadOnly = false;
            txtdongia.ReadOnly = false;
            cmbnhaxb.Enabled = true;

            if (txtmasach.ReadOnly == false && txttensach.ReadOnly == false && txtsoluong.ReadOnly == false && txtdongia.ReadOnly == false && cmbnhaxb.Enabled == true)
            {
                MessageBox.Show("Đã mở khóa." + "\nLưu ý:" + "\nChọn tác giả trước khi Lưu.","Thông Báo");
            }

            txtmasach.Clear();
            txttensach.Clear();
            txtsoluong.Clear();
            txtdongia.Clear();

            txtmasach.Focus();
        }

        private bool ktratrung()
        {
            
            bool kiemtra = false;
            string mas = txtmasach.Text;
            try
            {
                DataTable trung = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select SACH.MaSach from SACH where SACH.MaSach='" + mas + "'", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(trung);
                    if(trung.Rows.Count>0)
                    {
                        kiemtra = true;
                    }
                    da.Dispose();
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!", ex.Message);
            }
            return kiemtra;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataTable luutt = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select SACH.MaSach,SACH.Ten,SACH.SoLuong,SACH.DonGia,SACH.MaNXB,SACH.MaTG from SACH", conn))
                using (SqlDataAdapter daluutt = new SqlDataAdapter(cmd))
                using (SqlCommandBuilder builder = new SqlCommandBuilder(daluutt))
                {
                    daluutt.FillSchema(luutt, SchemaType.Source);
                    daluutt.Fill(luutt);

                    DataRow them = luutt.NewRow();


                    string manxb = "select NhaXB.MaNXB from NhaXB inner join SACH on SACH.MaNXB = NhaXB.MaNXB";
                    string matg = "select TACGIA.MaTG from TACGIA inner join SACH on SACH.MaTG = TACGIA.MaTG";


                    if (txtmasach.Text == "" && txttensach.Text == "" && txtsoluong.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Vui lòng điền thông tin!!!","Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txttensach.Text == "" && txtsoluong.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhâp:" + "\n Tên Sách" + "\n Số Lượng" + "\n Đơn Giá" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txtmasach.Text == "" && txtsoluong.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhâp:" + "\n Mã Sách" + "\n Số Lượng" + "\n Đơn Giá" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txtmasach.Text == "" && txttensach.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhâp:" + "\n Mã Sách" + "\n Tên Sách" + "\n Đơn Giá" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txtmasach.Text == "" && txttensach.Text == "" && txtsoluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhâp:" + "\n Mã Sách" + "\n Tên Sách" + "\n Số Lượng" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txtsoluong.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Số Lượng" + "\n Đơn Giá" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtsoluong.Focus();
                    }
                    else if (txtmasach.Text == "" && txttensach.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Mã Sách" + "\n Tên Sách" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txttensach.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Tên Sách" + "\n Đơn Giá" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txtmasach.Text == "" && txtsoluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Mã Sách" + "\n Số Lượng" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txttensach.Text == "" && txtsoluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Tên Sách" + "\n Số Lượng" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txtmasach.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Mã Sách" + "\n Đơn Giá" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txtmasach.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Mã Sách!!!" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtmasach.Focus();
                    }
                    else if (txttensach.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Tên Sách!!!" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txtsoluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Số Lượng!!!" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtsoluong.Focus();
                    }
                    else if (txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Đơn Giá!!!" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtdongia.Focus();
                    }
                    else if (cmbnhaxb.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn tên nhà xuất bản!!!" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                    }
                    else
                    {
                       if(ktratrung())
                       {
                            MessageBox.Show("[Sách : " + txtmasach.Text + "] đã có" + "\n\nVui lòng chọn lại Tác Giả", "Thông Báo");
                            txtmasach.Clear();
                            txtmasach.Focus();
                       }
                       else
                        {
                            them["MaSach"] = txtmasach.Text;
                            them["Ten"] = txttensach.Text;

                            int sl = Int32.Parse(txtsoluong.Text);
                            if (sl <= 4)
                            {
                                MessageBox.Show("Phải nhập số lượng lớn hơn hoặc bằng 5!!!" + "\n\nVui lòng chọn lại Tác Giả", "Thông Báo");
                                txtsoluong.Clear();
                                txtsoluong.Focus();
                            }
                            else
                            {
                                them["SoLuong"] = txtsoluong.Text;
                                them["DonGia"] = txtdongia.Text;

                                switch (cmbnhaxb.SelectedItem)
                                {
                                    case "Thanh Huy":
                                        manxb = "NXB1";
                                        break;
                                    case "Huu Hiep":
                                        manxb = "NXB2";
                                        break;
                                    case "Quoc Cuong":
                                        manxb = "NXB3";
                                        break;
                                    default:
                                        manxb = "";
                                        break;
                                }
                                them["MaNXB"] = manxb;

                                switch (tvdstacgia.SelectedNode.Text)
                                {
                                    case "Tac Gia 1":
                                        matg = "TG1";
                                        break;
                                    case "Tac Gia 2":
                                        matg = "TG2";
                                        break;
                                    case "Tac Gia 3":
                                        matg = "TG3";
                                        break;
                                    default:
                                        matg = "";
                                        break;
                                }
                                them["MaTG"] = matg;

                                DialogResult thanhcong = MessageBox.Show("Thêm [ Sách : " + txttensach.Text + " ] thành công!!!", "Thông Báo");

                                if (thanhcong == DialogResult.OK)
                                {
                                    txtmasach.ReadOnly = true;
                                    txttensach.ReadOnly = true;
                                    txtsoluong.ReadOnly = true;
                                    txtdongia.ReadOnly = true;
                                    cmbnhaxb.Enabled = false;

                                    txtmasach.Clear();
                                    txttensach.Clear();
                                    txtsoluong.Clear();
                                    txtdongia.Clear();
                                    cmbnhaxb.ResetText();
                                }
                            }
                        
                        }

                        luutt.Rows.Add(them);
                        daluutt.Update(luutt);
                    }
                    
                }
                loadtv();
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Lỗi Kết Nối!!!");
            }
        }

        private void txtmasach_Click(object sender, EventArgs e)
        {
            if (txtmasach.ReadOnly == true)
            {
                MessageBox.Show("Đang Khóa!!!" + "\nClick nút Thêm để mở khóa", "Thông Báo");
            }
        }

        private void txttensach_Click(object sender, EventArgs e)
        {
            if (txttensach.ReadOnly == true)
            {
                MessageBox.Show("Đang Khóa!!!" + "\nClick nút Thêm or Cập Nhật để mở khóa", "Thông Báo");
            }
        }

        private void txtsoluong_Click(object sender, EventArgs e)
        {
            if (txtsoluong.ReadOnly == true)
            {
                MessageBox.Show("Đang Khóa!!!" + "\nClick nút Thêm or Cập Nhật để mở khóa", "Thông Báo");
            }            
        }

        private void txtdongia_Click(object sender, EventArgs e)
        {
            if (txtdongia.ReadOnly == true)
            {
                MessageBox.Show("Đang Khóa!!!" + "\nClick nút Thêm or Cập Nhật để mở khóa", "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sach = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select * from SACH", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                using (SqlCommandBuilder builder = new SqlCommandBuilder(da))
                {
                    da.FillSchema(sach, SchemaType.Source);
                    da.Fill(sach);

                    DataRow[] dr = sach.Select("MaSach='" + txtmasach.Text + "'");

                    

                    if (txtmasach.Text == "")
                    {
                        MessageBox.Show("Hãy chọn Sách cần xóa.", "Thông Báo");
                    }
                    else 
                    {
                        DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa [ Sách : " + txttensach.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (rs == DialogResult.OK)
                        {
                            dr[0].Delete();
                            da.Update(dr);
                            MessageBox.Show("Xóa [ Sách : " + txttensach.Text + " ] thành công!!!", "Thông Báo");
                        }
                           
                    }
                    
                    txtmasach.Clear();
                    txttensach.Clear();
                    txtsoluong.Clear();
                    txtdongia.Clear();
                    cmbnhaxb.ResetText();
                }
                loadtv();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!!!",ex.Message);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            txttongtiensach.Clear();

            if (txtmasach.Text == "")
            {
                MessageBox.Show("Hãy chọn Sách cần cập nhật.", "Thông Báo");
            }
            else
            {
                txttensach.ReadOnly = false;
                txtsoluong.ReadOnly = false;
                txtdongia.ReadOnly = false;

                MessageBox.Show("Đã mở khóa.", "Thông Báo");
            }
        }
        private void btnluucapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable sach = new DataTable();
                string connect = ConfigurationManager.ConnectionStrings["QLTV"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connect))
                using (SqlCommand cmd = new SqlCommand("select * from SACH", conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                using (SqlCommandBuilder builder = new SqlCommandBuilder(da))
                {
                    da.FillSchema(sach, SchemaType.Source);
                    da.Fill(sach);

                    DataRow[] dr = sach.Select("MaSach='" + txtmasach.Text + "'");

                    if (txttensach.Text == "" && txtsoluong.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhâp:" + "\n Tên Sách" + "\n Số Lượng" + "\n Đơn Giá", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txtsoluong.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Số Lượng" + "\n Đơn Giá", "Thông Báo");
                        txtsoluong.Focus();
                    }
                    else if (txttensach.Text == "" && txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Tên Sách" + "\n Đơn Giá", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txttensach.Text == "" && txtsoluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập:" + "\n Tên Sách" + "\n Số Lượng", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txttensach.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Tên Sách!!!", "Thông Báo");
                        txttensach.Focus();
                    }
                    else if (txtsoluong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Số Lượng!!!", "Thông Báo");
                        txtsoluong.Focus();
                    }
                    else if (txtdongia.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập Đơn Giá!!!" + "\nVui lòng chọn lại Tác Giả", "Thông Báo");
                        txtdongia.Focus();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Bạn muốn cập nhật [ Sách : " + txttensach.Text + "] ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            dr[0]["Ten"] = txttensach.Text;
                            int sl = Int32.Parse(txtsoluong.Text);
                            if (sl <= 4)
                            {
                                MessageBox.Show("Phải nhập số lượng lớn hơn hoặc bằng 5!!!" + "\n\nVui lòng chọn lại Tác Giả", "Thông Báo");
                                txtsoluong.Clear();
                                txtsoluong.Focus();
                            }
                            else
                            {
                                dr[0]["SoLuong"] = txtsoluong.Text;
                                dr[0]["DonGia"] = txtdongia.Text;
                                MessageBox.Show("Cập nhật thành công.", "Thông Báo");

                                txtmasach.Clear();
                                txttensach.Clear();
                                txtsoluong.Clear();
                                txtdongia.Clear();
                                cmbnhaxb.ResetText();

                                txttensach.ReadOnly = true;
                                txtsoluong.ReadOnly = true;
                                txtdongia.ReadOnly = true;
                            }
                            
                        }
                    }
                    da.Update(dr);
                    loadtv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!", ex.Message);
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lvsach_DoubleClick(object sender, EventArgs e)
        {
            nhaxb.MaNXB = lvsach.SelectedItems[0].SubItems[5].Text;
            F_TTChiTiet form3 = new F_TTChiTiet();
            form3.Show();
        }
    }
}
