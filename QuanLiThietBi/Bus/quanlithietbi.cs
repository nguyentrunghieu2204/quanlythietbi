using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Bus
{
   public  class quanlithietbi
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        public List<THIETBI> dsthietbi()
        {
            var model = db.THIETBIs.ToList();
            return model;
        }
        public List<THIETBI> timkiemthietbi(string name)
        {
            var model = (from n in db.THIETBIs
                         where n.TEN.Contains(name)
                         select n).ToList();
            return model;
        }


    }
}
