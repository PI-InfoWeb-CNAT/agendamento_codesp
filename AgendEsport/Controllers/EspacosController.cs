using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendEsport.Models;

namespace AgendEsport.Controllers
{
    public class EspacosController : Controller
    {
        private static IList<Espacos> espacos = new List<Espacos>()
        {
            new Espacos() { EspaçoId = 1, Nome = "Ginásio"},
        };
        
        // GET: Categorias
        public ActionResult Index()
        {
            return View(espacos);
        }

        // GET: Categorias
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Espacos espaco)
        {
            espacos.Add(espaco);
            espaco.EspaçoId = espacos.Select(m => m.EspaçoId).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(espacos.Where(m => m.EspaçoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Espacos espaco)
        {
            espacos.Remove(
            espacos.Where(c => c.EspaçoId == espaco.EspaçoId).First());
            espacos.Add(espaco);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(espacos.Where(m => m.EspaçoId == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(espacos.Where(m => m.EspaçoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Espacos espaco)
        {
            espacos.Remove(
            espacos.Where(c => c.EspaçoId == espaco.EspaçoId).First());
            return RedirectToAction("Index");
        }

    }
}