using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CatFoodCalculator.Models;

namespace CatFoodCalculator.Controllers
{
    public class BodyInfoCategoryController : Controller
    {
        private CatFoodCalculatorContext db = new CatFoodCalculatorContext();

        // GET: BodyInfoCategory
        public ActionResult Index()
        {
            return View(db.BodyInfoCategories.ToList());
        }

        // GET: BodyInfoCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyInfoCategory bodyInfoCategory = db.BodyInfoCategories.Find(id);
            if (bodyInfoCategory == null)
            {
                return HttpNotFound();
            }
            return View(bodyInfoCategory);
        }

        // GET: BodyInfoCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BodyInfoCategory/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] BodyInfoCategory bodyInfoCategory)
        {
            if (ModelState.IsValid)
            {
                db.BodyInfoCategories.Add(bodyInfoCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bodyInfoCategory);
        }

        // GET: BodyInfoCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyInfoCategory bodyInfoCategory = db.BodyInfoCategories.Find(id);
            if (bodyInfoCategory == null)
            {
                return HttpNotFound();
            }
            return View(bodyInfoCategory);
        }

        // POST: BodyInfoCategory/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] BodyInfoCategory bodyInfoCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bodyInfoCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bodyInfoCategory);
        }

        // GET: BodyInfoCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BodyInfoCategory bodyInfoCategory = db.BodyInfoCategories.Find(id);
            if (bodyInfoCategory == null)
            {
                return HttpNotFound();
            }
            return View(bodyInfoCategory);
        }

        // POST: BodyInfoCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BodyInfoCategory bodyInfoCategory = db.BodyInfoCategories.Find(id);
            db.BodyInfoCategories.Remove(bodyInfoCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
