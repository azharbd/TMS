using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JvascriptTest.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JTest()
        {
            return View();
        }
        public ActionResult ajax()
        {
            return View();
        }
        public JsonResult info()
        {
            

            return Json(new { id = 1, name = "azhar" },JsonRequestBehavior.AllowGet);
        }
    }
}