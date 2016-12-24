using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bus;


namespace QuanLiThietBi
{
    public partial class ThemTB : Form
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        bus_themthietbi mybus = new bus_themthietbi();
        
        public ThemTB()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtten.Text;
            int loai = Convert.ToInt32(cbloaithietbi.SelectedValue);
            int tinhtrang = Convert.ToInt32(cbloaithietbi.SelectedValue);
            int nguyengia = Convert.ToInt32(txtnguyengia.Text);
            string donvitinh = cbdonvi.Text;
            DateTime namsx = Convert.ToDateTime(dtnamsx.Text);
            DateTime namsudung = Convert.ToDateTime(dtnamsudung.Text);
            DateTime ngaynhap = Convert.ToDateTime(dtngaynhap.Text);
            THIETBI tb = new THIETBI();
            tb.TEN = ten;
            tb.ID_Loai = loai;
            tb.ID_TinhTrang = tinhtrang;
            tb.DonGia = nguyengia;
           tb.DonViTinh = donvitinh;
            tb.NgaySanXuat = namsx;
            tb.NgaySD = namsudung;
            tb.SoLuong = 0;
            tb.NgayCapNhat = ngaynhap;
            bool ketqua = mybus.themthietbi(tb);
            if(ketqua==true)
            {
                MessageBox.Show("Thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void ThemTB_Load(object sender, EventArgs e)
        {
            // load combo nhà cung cấp
            // load combo loại thết bị
            List<LOAITHIETBI> listloai = mybus.dsloaithietbi();
            cbloaithietbi.DisplayMember = "Ten";
            cbloaithietbi.ValueMember = "ID";
            cbloaithietbi.DataSource = listloai;
            // load combo tình trạng
            List<TINHTRANG> listinhtrang = mybus.dstinhtrang();
            cbtinhtrang.DisplayMember = "Ten";
            cbtinhtrang.ValueMember = "ID";
            cbtinhtrang.DataSource = listinhtrang;
            // load combo đơn vị
            
            //List<DonVi> dsdonvi = mybus.dsdonvi();
            //cbdonvi.DisplayMember = "TenDonVi";
            //cbdonvi.ValueMember = "ID";
            //cbdonvi.DataSource = dsdonvi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_quanlithietbi f = new F_quanlithietbi();
            f.Show();
            Hide();
        }
    }
}
