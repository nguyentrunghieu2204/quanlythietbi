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
    public partial class F_quanlithietbi : Form
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        quanlithietbi mybus = new quanlithietbi();
        bus_thongke bustk = new bus_thongke();

        public F_quanlithietbi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_quanlithietbi_Load(object sender, EventArgs e)
        {
            List<THIETBI> dsthietbi = new List<THIETBI>();
            dsthietbi = mybus.dsthietbi();
            for (int i = 0; i < dsthietbi.Count; i++)
            {
                dgvthietbi.Rows.Add(dsthietbi[i].ID, dsthietbi[i].TEN, dsthietbi[i].LOAITHIETBI.Ten, dsthietbi[i].DonGia, dsthietbi[i].DonViTinh, dsthietbi[i].NgayCapNhat,
                    dsthietbi[i].NgaySD);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dong = dgvthietbi.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvthietbi.Rows[dong].Cells[0].Value.ToString());
            F_suathietbi f = new F_suathietbi(id);
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemTB f = new ThemTB();
            f.ShowDialog();


        }

        private void dgvthietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttimkiem1_TextChanged(object sender, EventArgs e)
        {
            string ten = txttimkiem1.Text;
            List<THIETBI> dsthietbi = mybus.timkiemthietbi(ten);
            if (dsthietbi.Count == 0)
            {
                dgvthietbi.Rows.Clear();
            }
            for (int i = 0; i < dsthietbi.Count; i++)
            {
                dgvthietbi.Rows.Add(dsthietbi[i].ID, dsthietbi[i].TEN, dsthietbi[i].LOAITHIETBI.Ten, dsthietbi[i].DonGia, dsthietbi[i].DonViTinh, dsthietbi[i].NgayCapNhat,
                    dsthietbi[i].NgaySD);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime ngaythongke = Convert.ToDateTime(dtngaysl.Text);
            List<THIETBI> ds = bustk.dsthietbikho(ngaythongke);
            dgvsoluong.Rows.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                var loaithietbi = db.LOAITHIETBIs.Find(ds[i].ID_Loai);
                dgvsoluong.Rows.Add(ds[i].ID, ds[i].TEN, loaithietbi.Ten, ds[i].SoLuong);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ngaytt = Convert.ToDateTime(dtngaytt.Text);
            List<THIETBI> ds = bustk.dsthietbitt(ngaytt);
            int moi = 0;
            int dasudung = 0;
            int hu = 0;
            dgvtinhtrang.Rows.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                var loaithietbi = db.LOAITHIETBIs.Find(ds[i].ID_Loai);
                var tinhtrang = db.TINHTRANGs.Find(ds[i].ID_TinhTrang);
                dgvtinhtrang.Rows.Add(ds[i].ID, ds[i].TEN, loaithietbi.Ten, ds[i].NgayCapNhat, tinhtrang.Ten);
                if (tinhtrang.Ten == "Mới")
                {
                    moi = moi + 1;
                }
                if (tinhtrang.Ten == "Đã Qua Sử Dụng ")
                {
                    dasudung = dasudung + 1;
                }
                if (tinhtrang.Ten == "Hư")
                {
                    hu = hu + 1;
                }
            }
            lbhu.Text = hu.ToString();
            lbmoi.Text = moi.ToString();
            lbsd.Text = dasudung.ToString();
        }

        private void lbsd_Click(object sender, EventArgs e)
        {

        }

        private void txttimkiem2_TextChanged(object sender, EventArgs e)
        {
            DateTime ngaytt = Convert.ToDateTime(dtngaytt.Text);
            string ten = txttimkiem2.Text;
            List<THIETBI> ds = bustk.timtt(ten, ngaytt);
            dgvtinhtrang.Rows.Clear();
            for (int i = 0; i < ds.Count; i++)
            {
                var loaithietbi = db.LOAITHIETBIs.Find(ds[i].ID_Loai);
                dgvtinhtrang.Rows.Add(ds[i].ID, ds[i].TEN, loaithietbi.Ten, ds[i].NgayCapNhat, ds[i].TINHTRANG);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime ngaysl = Convert.ToDateTime(dtngaysl.Text);
            string ten = textBox1.Text;
            List<THIETBI> ds1 = bustk.timkiemkho(ten, ngaysl);
            dgvsoluong.Rows.Clear();
            for (int i = 0; i < ds1.Count; i++)
            {
                var loaithietbi = db.LOAITHIETBIs.Find(ds1[i].ID_Loai);
                dgvsoluong.Rows.Add(ds1[i].ID, ds1[i].TEN, loaithietbi.Ten, ds1[i].SoLuong);
            }

        }
    }



        //    private void button4_Click(object sender, EventArgs e)
        //    {
        //        DateTime ngaythongke = Convert.ToDateTime(dtngaysl.Text);
        //        List<THIETBI> ds = bustk.dsthietbikho(ngaythongke);
        //        dgvsoluong.Rows.Clear();
        //        for(int i=0;i<ds.Count;i++)
        //        {
        //            var loaithietbi = db.LOAITHIETBIs.Find(ds[i].ID_Loai);
        //            dgvsoluong.Rows.Add(ds[i].ID, ds[i].TEN, loaithietbi.Ten, ds[i].SoLuong);
        //        }


        //    }

        //    private void textBox1_TextChanged(object sender, EventArgs e)
        //    {
        //        DateTime ngaysl = Convert.ToDateTime(dtngaysl.Text);
        //        string ten = textBox1.Text;
        //        List<THIETBI> ds1 = bustk.timkiemkho(ten, ngaysl);
        //        dgvsoluong.Rows.Clear();
        //        for (int i = 0; i < ds1.Count; i++)
        //        {
        //            var loaithietbi = db.LOAITHIETBIs.Find(ds1[i].ID_Loai);
        //            dgvsoluong.Rows.Add(ds1[i].ID, ds1[i].TEN, loaithietbi.Ten, ds1[i].SoLuong);
        //        }

        //    }

        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        DateTime ngaytt = Convert.ToDateTime(dtngaytt.Text);
        //        List<THIETBI> ds = bustk.dsthietbitt(ngaytt);
        //        int moi = 0;
        //        int dasudung = 0;
        //        int hu = 0;
        //        dgvtinhtrang.Rows.Clear();
        //        for(int i=0;i<ds.Count;i++)
        //        {
        //            var loaithietbi = db.LOAITHIETBIs.Find(ds[i].ID_Loai);
        //            dgvtinhtrang.Rows.Add(ds[i].ID, ds[i].TEN, loaithietbi.Ten, ds[i].NgayCapNhat, ds[i].TINHTRANG.Ten);
        //            if(ds[i].TINHTRANG.Ten=="Mới")
        //            {
        //                moi = moi + 1;
        //            }
        //            if (ds[i].TINHTRANG.Ten == "Đã Qua Sử Dụng ")
        //            {
        //                dasudung = dasudung + 1;
        //            }
        //            if (ds[i].TINHTRANG.Ten == "Hư")
        //            {
        //                hu = hu + 1;
        //            }
        //        }
        //        lbhu.Text = hu.ToString();
        //        lbmoi.Text = moi.ToString();
        //        lbsd.Text = dasudung.ToString();

        //    }

        //    private void txttimkiem2_TextChanged(object sender, EventArgs e)
        //    {
        //        DateTime ngaytt = Convert.ToDateTime(dtngaytt.Text);
        //        string ten = txttimkiem2.Text;
        //        List<THIETBI> ds = bustk.timtt(ten,ngaytt);
        //        dgvtinhtrang.Rows.Clear();
        //        for (int i = 0; i < ds.Count; i++)
        //        {
        //            var loaithietbi = db.LOAITHIETBIs.Find(ds[i].ID_Loai);
        //            dgvtinhtrang.Rows.Add(ds[i].ID, ds[i].TEN, loaithietbi.Ten, ds[i].NgayCapNhat, ds[i].TINHTRANG);
        //        }

        //    }

        //    private void lbsd_Click(object sender, EventArgs e)
        //    {

        //    }
        //}
    }

