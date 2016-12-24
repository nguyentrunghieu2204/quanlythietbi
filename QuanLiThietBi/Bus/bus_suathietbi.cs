using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Bus;

namespace Bus
{
   public  class bus_suathietbi
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        public bool suathietbi(THIETBI tb)
        {
            try
            {
                var model = db.THIETBIs.Find(tb.ID);
                model.TEN = tb.TEN;
                model.ID_Loai = tb.ID_Loai;
                model.DonGia = tb.DonGia;
                model.DonViTinh = tb.DonViTinh;
                model.NgaySanXuat = tb.NgaySanXuat;
                model.NgaySD = tb.NgaySD;
                model.ID_TinhTrang = tb.ID_TinhTrang;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<NHACUNGCAP> dsnhacc()
        {
            return db.NHACUNGCAPs.ToList();
        }
        public List<LOAITHIETBI> dsloaithietbi()
        {
            return db.LOAITHIETBIs.ToList();
        }
        public List<DONVI> dsdonvi()
        {
            return db.DONVIs.ToList();
        }
        public List<TINHTRANG> dstinhtrang()
        {
            return db.TINHTRANGs.ToList();
        }
        public THIETBI timkiemtb(int id)
        {
            var model = db.THIETBIs.Find(id);
            return model;
        }
    }
}
