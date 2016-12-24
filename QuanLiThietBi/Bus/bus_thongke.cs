using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Bus
{
   public class bus_thongke
    {
        QuanLiThietBiEntities3  db = new QuanLiThietBiEntities3();
        public  List<THIETBI> dsthietbikho(DateTime thoidiem)
        {
            List<THIETBI> dstb = new List<THIETBI>();
         
                var query = from s in db.THIETBIs
                            select s;
                foreach (var row in query)
                {
                    THIETBI tb = new THIETBI();
                    tb.ID = row.ID;
                    tb.TEN = row.TEN;
                     tb.ID_Loai = row.ID_Loai;

                    //tính số lượng tồn
                    int soluongnhap = 0;
                    try
                    {
                        soluongnhap = (int)db.CHITIETPHIEUNHAPs.Where(x => x.ID_ThietBi == tb.ID && x.PHIEUNHAP.NgayNhap <= thoidiem).Sum(x => x.soluong);
                    }
                    catch { }
                    int soluongxuat = 0;
                    try
                    {
                        soluongxuat = (int)db.CHITIETPHIEUGIAOs.Where(x => x.ID_ThietBi == tb.ID && x.PHIEUGIAO.NgayGiao <= thoidiem).Sum(x => x.SoLuong);
                    }
                    catch { }
                    //tính số lượng xong
                    tb.SoLuong = soluongnhap - soluongxuat;
                    dstb.Add(tb);
                }
                return dstb;
            }
        public List<THIETBI> timkiemkho(string ten, DateTime thoidiem)
        {
            List<THIETBI> dstb = new List<THIETBI>();

            var query = from s in db.THIETBIs
                        select s;
            foreach (var row in query)
            {
                THIETBI tb = new THIETBI();
                tb.ID = row.ID;
                tb.TEN = row.TEN;
                tb.ID_Loai = row.ID_Loai;
                //tính số lượng tồn
                int soluongnhap = 0;
                try
                {
                    soluongnhap = (int)db.CHITIETPHIEUNHAPs.Where(x => x.ID_ThietBi == tb.ID && x.PHIEUNHAP.NgayNhap <= thoidiem).Sum(x => x.soluong);
                }
                catch { }
                int soluongxuat = 0;
                try
                {
                    soluongxuat = (int)db.CHITIETPHIEUGIAOs.Where(x => x.ID_ThietBi == tb.ID && x.PHIEUGIAO.NgayGiao <= thoidiem).Sum(x => x.SoLuong);
                }
                catch { }
                //tính số lượng xong
                tb.SoLuong = soluongnhap - soluongxuat;
                dstb.Add(tb);
            }
            var model = (from n in dstb
                         where n.TEN.Contains(ten)
                         select n).ToList();
            return model;
        }
        public  List<THIETBI> timtt(string ten, DateTime thoidiem)
        {
            List<THIETBI> dstb = new List<THIETBI>();
                var query = (from s in db.THIETBIs
                            where s.TEN == ten  && s.NgayCapNhat <= thoidiem
                            select s);
                foreach (var row in query)
                {
                    THIETBI tb = new THIETBI();
                    tb.ID = row.ID;
                    tb.TEN = row.TEN;
                    tb.DonGia = row.DonGia;
                    tb.ThongSo = row.ThongSo;
                    tb.NgaySanXuat = row.NgaySanXuat;
                    tb.NgaySD = row.NgaySD;
                    tb.NgayCapNhat = row.NgayCapNhat;
                    tb.SoLuong = row.SoLuong;
                    tb.DonViTinh = row.DonViTinh;
                    tb.ID_Loai = row.ID_Loai;
                    tb.ID_TinhTrang = row.ID_TinhTrang;
                    dstb.Add(tb);
                }
            
            return dstb;

        }
        public List<THIETBI> dsthietbitt(DateTime thoidiem)
        {
            List<THIETBI> dstb = new List<THIETBI>();
            var query = (from s in db.THIETBIs
                         where s.NgayCapNhat <= thoidiem
                         select s);
            foreach (var row in query)
            {
                THIETBI tb = new THIETBI();
                tb.ID = row.ID;
                tb.TEN = row.TEN;
                tb.DonGia = row.DonGia;
                tb.ThongSo = row.ThongSo;
                tb.NgaySanXuat = row.NgaySanXuat;
                tb.NgaySD = row.NgaySD;
                tb.NgayCapNhat = row.NgayCapNhat;
                tb.SoLuong = row.SoLuong;
                tb.DonViTinh = row.DonViTinh;
                tb.ID_Loai = row.ID_Loai;
                tb.ID_TinhTrang = row.ID_TinhTrang;
                dstb.Add(tb);
            }

            return dstb;
        }
      
    }
}
