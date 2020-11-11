using K101FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K101FirstMVC.Controllers
{
    public class ProductsController : Controller
    {
        ShoppingDB db = new ShoppingDB();

        // GET: Products
        public ActionResult Index()
        {
            ViewBag.k101List = db.Products.ToList();
            return View();
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Product pro= db.Products.FirstOrDefault(x => x.ID == id);
            if (pro == null)
            {
                return HttpNotFound();
            }

            ViewBag.singlePro = pro;
            return View();
        }

    }
}