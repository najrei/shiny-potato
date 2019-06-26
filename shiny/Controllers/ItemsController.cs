using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using shiny.Models;

namespace shiny.Controllers
{
    public class ItemsController : Controller
    {
        private DBContext db = new DBContext();

        // GET: Items
        public ActionResult Index()
        {
            var flag = db.Items.ToList();
            var produkte = Session["products"] as List<SessonModel>;

            

            return View(flag);
        }

        // GET: Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        public ActionResult AddToSesson(int? id)
        {
            SessonModel sm = new SessonModel();
            Item item = db.Items.Find(id);
            sm.ItemId = item.ItemID;
            sm.Anzahl = 1;

            List<SessonModel> lsm = new List<SessonModel>();
            lsm.Add(sm);
            Session["products"] = lsm;
            return RedirectToAction("Index");
        }

        
    }
}
