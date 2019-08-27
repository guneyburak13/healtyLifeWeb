using BLL;
using ENT;
using HealtyLifeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace HealtyLifeWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.urunler = new BLL_URUNLER().ListUrun();
            ViewBag.sonBitkisel = new BLL_URUNLER().SonBitkiselUrun();
            ViewBag.sonZayıflama = new BLL_URUNLER().SonZayıflamaUrun();
            ViewBag.sonSpor = new BLL_URUNLER().SonSporUrun();
            return View();
        }

        public ActionResult UrunListele_By_Ktg(int ktg_id)
        {
            BLL_URUNLER urun = new BLL_URUNLER();

            List<ent_URUNLER> urunlerList = urun.UrunListele_By_Ktgid(ktg_id);

            return View("UrunListele_By_Ktg", urunlerList);
        }

        public ActionResult UrunGoruntule(int urun_id)
        {
            BLL_URUNLER urun = new BLL_URUNLER();
            ent_URUNLER urungoster = urun.UrunGoruntule(urun_id);

            return View("UrunGoruntule", urungoster);
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }
     
    }
}