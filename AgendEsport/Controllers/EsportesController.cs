    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendEsport.Models;

namespace AgendEsport.Controllers
{
    public class EsportesController : Controller
    {
        private static IList<Esportes> esportes = new List<Esportes>()
        {
            new Esportes() { EsporteId = 1, Nome = "Futsal"},
        };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(esportes);
        }

        // GET: Categorias
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Esportes esporte)
        {
            esportes.Add(esporte);
            esporte.EsporteId = esportes.Select(m => m.EsporteId).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(esportes.Where(m => m.EsporteId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Esportes esporte)
        {
            esportes.Remove(
            esportes.Where(c => c.EsporteId == esporte.EsporteId).First());
            esportes.Add(esporte);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(esportes.Where(m => m.EsporteId == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(esportes.Where(m => m.EsporteId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Esportes esporte)
        {
            esportes.Remove(
            esportes.Where(c => c.EsporteId == esporte.EsporteId).First());
            return RedirectToAction("Index");
        }

    }
}