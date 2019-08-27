using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ENT;

namespace HealtyLifeWeb.Areas.Yonetim.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Yonetim/Kategori
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KategoriList()
        {
            BLL_KATEGORI kategori = new BLL_KATEGORI();

            List<ent_KATEGORI> kategoriList = kategori.ListKategori();
            SelectList list = new SelectList(kategoriList);
            ViewBag.kategoriler = list;

            return View("KategoriList", kategoriList);


        }
        [HttpGet]
        public ActionResult CreateKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateKategori(ent_KATEGORI ktgr)
        {
           
            BLL_KATEGORI kategori = new BLL_KATEGORI();
            kategori.SaveKategori(ktgr);
            return RedirectToAction("KategoriList", "Kategori");
        }

        public ActionResult KategoriForm(int kategori_id = 0)
        {
           
            ent_KATEGORI result = new BLL_KATEGORI().SelectKategori(kategori_id);
            return View("KategoriForm", result);
        }
    }
}