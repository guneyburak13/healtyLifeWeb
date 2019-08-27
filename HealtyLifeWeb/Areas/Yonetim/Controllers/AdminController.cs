using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ENT;

namespace HealtyLifeWeb.Areas.Yonetim.Controllers
{
    public class AdminController : Controller
    {
        // GET: Yonetim/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminList()
        {
            BLL_ADMIN admin = new BLL_ADMIN();

            List<ent_ADMIN> adminList = admin.ListAdmin();

            return View("AdminList", adminList);

        }
        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAdmin(ent_ADMIN adm)
        {
            BLL_ADMIN admin = new BLL_ADMIN();
            admin.SaveAdmin(adm);
            return RedirectToAction("AdminList", "Admin");
        }
        public ActionResult AdminForm(int adm_id = 0)
        {

            ent_ADMIN result = new BLL_ADMIN().SelectAdmin(adm_id);
            return View("AdminForm", result);
        }
    }
}