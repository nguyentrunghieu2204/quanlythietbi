using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        QuanLiThietBiEntities3 db = new QuanLiThietBiEntities3();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Nhap()
        {
            ViewData["ID_NhaCC"] = new SelectList(db.NHACUNGCAPs, "ID", "Ten");
            ViewData["ID_DonVi"] = new SelectList(db.DONVIs, "ID", "Ten");
            ViewBag.ThietBi = db.THIETBIs.ToList();
            var model = db.PHIEUNHAPs.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult phieunhap(PHIEUNHAP pn, FormCollection form)
        {
            //  try
            {
                // nhập thông tin phiếu nhập
                string luachon = form["luachon"];
                if (luachon == "trongtruong")
                {
                    pn.NHACUNGCAP = null;
                }
                else
                {
                    pn.DONVI = null;
                }

                DateTime ngay = Convert.ToDateTime(form["ngaynhap"]);
                string soluong = form["soluong"];
                string mathietbi = form["mathietbi"];
                string tenthietbi = form["tenthietbi"];
                string tinhtrang = form["tinhtrang"];
                

                string[] quantity = soluong.Split(',');
                string[] key = mathietbi.Split(',');
                string[] name = tenthietbi.Split(',');
                string[] status = tinhtrang.Split(',');
                pn.NgayNhap = ngay;
                db.PHIEUNHAPs.Add(pn);
                db.SaveChanges();
                // nhập thông tin chi tiết nhập
                for (int i = 0; i < key.Length; i++)
                {
                    CHITIETPHIEUNHAP ct = new CHITIETPHIEUNHAP();
                    ct.ID_ThietBi = Convert.ToInt32(key[i]);
                    ct.ID_PHIEUNHAN = pn.ID;
                    ct.soluong = Convert.ToInt32(quantity[i]);
                    db.CHITIETPHIEUNHAPs.Add(ct);
                    var model1 = db.THIETBIs.Find(Convert.ToInt32(key[i]));
                    if(status[i]=="moi")
                    {
                        model1.ID_TinhTrang=1;
                        model1.NgayCapNhat = ngay;
                    }
                    if (status[i] == "dasudung")
                    {
                        model1.ID_TinhTrang = 2;
                        model1.NgayCapNhat = ngay;
                    }
                    if (status[i] == "hu")
                    {
                        model1.ID_TinhTrang = 4;
                        model1.NgayCapNhat = ngay;
                    }

                    model1.SoLuong += Convert.ToInt32(quantity[i]);
                    db.SaveChanges();

                }

                //phieugiao.ngaygiao = ngay;
                //db.PHIEUGIAO.Add(phieugiao);


                ModelState.AddModelError(" ", "Nhập Thành Công!!!");
                // }
                // catch
                // {
                // ModelState.AddModelError("", "Nhập Thất Bại!!!");
                //  }

                ViewData["ID_NhaCC"] = new SelectList(db.NHACUNGCAPs, "ID", "Ten");
                ViewData["ID_DonVi"] = new SelectList(db.DONVIs, "ID", "Ten");
                ViewBag.ThietBi = db.THIETBIs.ToList();
                var model = db.PHIEUNHAPs.ToList();
                return View("Nhap", model);
            }
        }
        public ActionResult Giao()
        {
            ViewData["ID_QuanTri"] = new SelectList(db.PHONGQUANTRIs, "ID", "Ten");
            ViewBag.ThietBi = db.THIETBIs.ToList();
            var model = db.PHIEUGIAOs.ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult phieugiao(PHIEUGIAO pg, FormCollection form)
        {
            try
            {
                DateTime ngay = Convert.ToDateTime(form["ngaygiao"]);
                string soluong = form["soluong"];
                string mathietbi = form["mathietbi"];
                string tenthietbi = form["tenthietbi"];

                string[] quantity = soluong.Split(',');
                string[] key = mathietbi.Split(',');
                string[] name = tenthietbi.Split(',');

                // insert phiếu giao
                pg.NgayGiao= ngay;
                db.PHIEUGIAOs.Add(pg);
                db.SaveChanges();
                // insert chi tiết phiếu giao
                for (int i = 0; i < key.Length; i++)
                {
                    CHITIETPHIEUGIAO ct = new CHITIETPHIEUGIAO();
                    ct.ID_ThietBi = Convert.ToInt32(key[i]);
                    ct.SoLuong = Convert.ToInt32(quantity[i]);
                    ct.ID_PHieuGiao = pg.ID;
                    db.CHITIETPHIEUGIAOs.Add(ct);
                    var model1 = db.THIETBIs.Find(Convert.ToInt32(key[i]));
                    model1.SoLuong -= Convert.ToInt32(quantity[i]);
                    db.SaveChanges();

                }

                //phieugiao.ngaygiao = ngay;
                //db.PHIEUGIAO.Add(phieugiao);

             
                ModelState.AddModelError(" ", "Giao Thành Công!!!");
            }
            catch
            {
                ModelState.AddModelError("", "Giao Thất Bại!!!");
            }


            ViewData["ID_QuanTri"] = new SelectList(db.PHONGQUANTRIs, "ID", "Ten");
            ViewBag.ThietBi = db.THIETBIs.ToList();
            var model = db.PHIEUGIAOs.ToList();
            return View("Giao", model);
        }
        public ActionResult chitietphieugiao(int id)
        {
            var model = (from n in db.CHITIETPHIEUGIAOs
                         where n.ID_PHieuGiao == id
                         select n).ToList();
            return View(model);
        }
        public ActionResult chitietphieunhap(int id)
        {
            ViewBag.chitiet = (from n in db.CHITIETPHIEUNHAPs
                         where n.ID_PHIEUNHAN == id
                         select n).ToList();
            return View();
        }
    }
}