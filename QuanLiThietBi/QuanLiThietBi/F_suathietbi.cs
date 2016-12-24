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
    public partial class F_suathietbi : Form
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        bus_suathietbi mybus = new bus_suathietbi();
        public F_suathietbi(int id)
        {
            InitializeComponent();
            THIETBI tb = mybus.timkiemtb(id);
            txtma.Text = id.ToString();
            txtten.Text = tb.TEN;
            cbloai.Text = tb.LOAITHIETBI.Ten;
            txtnguyengia.Text = tb.DonGia.ToString();
            cbdonvi.Text = tb.DonViTinh;
            dtngaynhap.Text = tb.NgayCapNhat.ToString();
            dtnamsx.Text = tb.NgaySanXuat.ToString();
            dtnamsudung.Text = tb.NgaySD.ToString();
            cbtinhtrang.Text = tb.TINHTRANG.Ten;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F_suathietbi_Load(object sender, EventArgs e)
        {
            // load combo loại thết bị
            List<LOAITHIETBI> listloai = mybus.dsloaithietbi();
            cbloai.DisplayMember = "Ten";
            cbloai.ValueMember = "ID";
            cbloai.DataSource = listloai;
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

        private void dtnamsx_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt32(txtma.Text);
                string tentb = txtten.Text;
                int loai = Convert.ToInt32(cbloai.SelectedValue);
                int nguyengia = Convert.ToInt32(txtnguyengia.Text);
                string donvi = cbdonvi.Text;
                DateTime ngaynhap = Convert.ToDateTime(dtngaynhap.Text);
                DateTime namsx = Convert.ToDateTime(dtnamsx.Text);
                DateTime namsudung = Convert.ToDateTime(dtnamsudung.Text);
                int tinhtrang = Convert.ToInt32(cbtinhtrang.SelectedValue);
                THIETBI tb = new THIETBI();
                tb.ID = ma;
                tb.TEN = tentb;
                tb.ID_Loai = loai;
                tb.SoLuong = 0;
                tb.DonGia = nguyengia;
                tb.DonViTinh = donvi;
                tb.NgayCapNhat = ngaynhap;
                tb.NgaySanXuat = namsx;
                tb.NgaySD = namsudung;
                tb.ID_TinhTrang = tinhtrang;
                bool ketqua = mybus.suathietbi(tb);
                if(ketqua==true)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi cập nhật");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_quanlithietbi f = new F_quanlithietbi();
            f.Show();
            Hide();
        }
    }
}
