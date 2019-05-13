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

//DESKTOP-88NIE12
namespace DeSo3
{
    public partial class F_DangNhap : Form
    {
        public F_DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=" + txttenmay.Text + ";Database=" + txttencsdl.Text + ";Integrated Security=True"))
                {
                    
                    if(txttencsdl.Text == "" && txttenmay.Text == "")
                    {
                        MessageBox.Show("Tên CSDL và tên máy không được để trống!!!","Thông Báo");
                        txttenmay.Focus();
                    }else if(txttencsdl.Text=="")
                    {
                        MessageBox.Show("Tên csdl không được để trống!!!","Thông Báo");
                        txttencsdl.Focus();
                    }else if(txttenmay.Text=="")
                    {
                        MessageBox.Show("Tên máy không được để trống!!!","Thông Báo");
                        txttenmay.Focus();
                    }
                    else
                    {
                        conn.Open();
                        DialogResult thanhcong = MessageBox.Show("Kết nối thành công!!!","Thông Báo");
                        if(thanhcong==DialogResult.OK)
                        {
                            F_QLSach form2 = new F_QLSach();
                            this.Hide();
                            form2.Show();
                        }  
                    }
                    
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại!!!", ex.Message);
                txttenmay.Clear();
                txttencsdl.Clear();
                txttenmay.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Error)==DialogResult.Yes)
           {
                Application.Exit();
           }
           else
           {
                txttenmay.Focus();
           }
            
        }
    }
}
