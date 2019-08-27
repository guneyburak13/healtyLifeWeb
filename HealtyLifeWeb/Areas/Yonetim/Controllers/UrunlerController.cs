using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ENT;

namespace HealtyLifeWeb.Areas.Yonetim.Controllers
{
    public class UrunlerController : Controller
    {

        // GET: Yonetim/Urunler
        public ActionResult Index()
        {
            ViewBag.kategoriler = new BLL_URUNLER().ListUrun();
            return View();
        }
        public ActionResult UrunlerList()
        {

            BLL_URUNLER urun = new BLL_URUNLER();

            List<ent_URUNLER> urunList = urun.ListUrun();

            return View("UrunlerList", urunList);

        }

        [HttpGet]
        public ActionResult CreateUrun()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUrun(ent_URUNLER urun)
        {
            BLL_URUNLER kaydet = new BLL_URUNLER();
            kaydet.SaveUrun(urun);
            return RedirectToAction("UrunlerList", "Urunler");
        }
        public ActionResult UrunForm(int urun_ID = 0)
        {

            ent_URUNLER result = new BLL_URUNLER().SelectUrun(urun_ID);
            return View("UrunForm", result);
        }

    }
}