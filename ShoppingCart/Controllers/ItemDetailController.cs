using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class ItemDetailController : Controller
    {
        ISkillsEntities db = new ISkillsEntities();
        // GET: ItemDetail
        public ActionResult Index(int id)
        {
            var data = db.Products.SingleOrDefault(p => p.ProductID == id);
            return View(data);
        }
    }
}