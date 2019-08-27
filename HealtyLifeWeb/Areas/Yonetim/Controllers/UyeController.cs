using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ENT;

namespace HealtyLifeWeb.Areas.Yonetim.Controllers
{
    public class UyeController : Controller
    {
        // GET: Yonetim/Uye
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UyeList()
        {
            BLL_UYELER uye = new BLL_UYELER();

            List<ent_UYELER> uyeList = uye.ListUyeler();

            return View("UyeList", uyeList);

        }

        [HttpGet]
        public ActionResult CreateUye()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUye(ent_UYELER uye)
        {
            BLL_UYELER uyeler = new BLL_UYELER();
            uyeler.SaveUyeler(uye);
            return RedirectToAction("UyeList", "Uye");
        }
        public ActionResult UyeForm(int uye_id = 0)
        {
            ent_UYELER result = new BLL_UYELER().SelectUye(uye_id);
            return View("UyeForm", result);
        }
    }
}