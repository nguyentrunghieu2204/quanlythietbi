using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Bus
{
     public class bus_themthietbi
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        public bool themthietbi(THIETBI tb)
        {
            try
            {
                db.THIETBIs.Add(tb);
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
    }
}
