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
    public class FuncionariosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Funcionarios
        public ActionResult Index()
        {
            return View(db.Funcionarios.ToList());
        }

        // GET: Funcionarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionarios funcionarios = db.Funcionarios.Find(id);
            if (funcionarios == null)
            {
                return HttpNotFound();
            }
            return View(funcionarios);
        }

        // GET: Funcionarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionarios/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Registro,Nome,Email")] Funcionarios funcionarios)
        {
            if (ModelState.IsValid)
            {
                db.Funcionarios.Add(funcionarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcionarios);
        }

        // GET: Funcionarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionarios funcionarios = db.Funcionarios.Find(id);
            if (funcionarios == null)
            {
                return HttpNotFound();
            }
            return View(funcionarios);
        }

        // POST: Funcionarios/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Registro,Nome,Email")] Funcionarios funcionarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionarios);
        }

        // GET: Funcionarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funcionarios funcionarios = db.Funcionarios.Find(id);
            if (funcionarios == null)
            {
                return HttpNotFound();
            }
            return View(funcionarios);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionarios funcionarios = db.Funcionarios.Find(id);
            db.Funcionarios.Remove(funcionarios);
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
