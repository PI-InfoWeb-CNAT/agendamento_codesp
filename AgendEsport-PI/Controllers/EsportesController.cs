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
    public class EsportesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Esportes
        public ActionResult Index()
        {
            return View(db.Esportes.ToList());
        }

        // GET: Esportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Esportes esportes = db.Esportes.Find(id);
            if (esportes == null)
            {
                return HttpNotFound();
            }
            return View(esportes);
        }

        // GET: Esportes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Esportes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Nome")] Esportes esportes)
        {
            if (ModelState.IsValid)
            {
                db.Esportes.Add(esportes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(esportes);
        }

        // GET: Esportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Esportes esportes = db.Esportes.Find(id);
            if (esportes == null)
            {
                return HttpNotFound();
            }
            return View(esportes);
        }

        // POST: Esportes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Nome")] Esportes esportes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(esportes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(esportes);
        }

        // GET: Esportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Esportes esportes = db.Esportes.Find(id);
            if (esportes == null)
            {
                return HttpNotFound();
            }
            return View(esportes);
        }

        // POST: Esportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Esportes esportes = db.Esportes.Find(id);
            db.Esportes.Remove(esportes);
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
