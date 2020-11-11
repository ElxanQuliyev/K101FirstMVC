using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K101FirstMVC.Controllers
{
    public class AllUserController : Controller
    {
        // GET: AllUser
        public ActionResult Index()
        {
            return View();
        }
    }
}