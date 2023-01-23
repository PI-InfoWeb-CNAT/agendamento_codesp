using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AgendEsport_PI.Models;

namespace AgendEsport_PI.Controllers
{
    public class EspaçosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Espaços
        public ActionResult Index()
        {
            return View(db.Espaços.ToList());
        }

        // GET: Espaços/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Espaços espaços = db.Espaços.Find(id);
            if (espaços == null)
            {
                return HttpNotFound();
            }
            return View(espaços);
        }

        // GET: Espaços/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Espaços/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Nome")] Espaços espaços)
        {
            if (ModelState.IsValid)
            {
                db.Espaços.Add(espaços);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(espaços);
        }

        // GET: Espaços/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Espaços espaços = db.Espaços.Find(id);
            if (espaços == null)
            {
                return HttpNotFound();
            }
            return View(espaços);
        }

        // POST: Espaços/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Nome")] Espaços espaços)
        {
            if (ModelState.IsValid)
            {
                db.Entry(espaços).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(espaços);
        }

        // GET: Espaços/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Espaços espaços = db.Espaços.Find(id);
            if (espaços == null)
            {
                return HttpNotFound();
            }
            return View(espaços);
        }

        // POST: Espaços/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Espaços espaços = db.Espaços.Find(id);
            db.Espaços.Remove(espaços);
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
