using shiny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shiny.Controllers
{
    public class EinkaufskorbController : Controller
    {
        DBContext db = new DBContext();
        // GET: Einkaufskorb
        public ActionResult Index()
        {

            var flag = db.Items.ToList();
            List<SessonModel> produkte = Session["products"] as List<SessonModel>;
            List<Item> items = new List<Item>();
            foreach (var item in produkte)
            {
                 items.Add(db.Items.Find(item));
            }

            return View(items);
        }
    }
}
