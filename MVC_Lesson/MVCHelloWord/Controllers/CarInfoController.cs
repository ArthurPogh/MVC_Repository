using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWord.Controllers
{
    public class CarInfoController : Controller
    {
        // GET: CarInfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cars()
        {
            return View();
        }
    }
}