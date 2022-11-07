using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgendEsport.Models;

namespace AgendEsport.Controllers
{
    public class FuncionariosController : Controller
    {
        private static IList<Funcionarios> funcionarios = new List<Funcionarios>()
        {
            new Funcionarios () { FuncionarioId = 1, Nome = "Flávio"},
        };

        // GET: Funcionarios
        public ActionResult Index()
        {
            return View(funcionarios);
        }
        // GET: Funcionarios
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionarios funcionarios)
        {
            funcionarios.Add(funcionarios);
            funcionarios.FuncionarioId = funcionarios.Select(m => m.FuncionarioId).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(funcionarios.Where(m => m.FuncionarioId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Funcionarios funcionarios)
        {
            funcionarios.Remove(
            funcionarios.Where(c => c.FuncionarioId == funcionarios.FuncionarioId).First());
            funcionarios.Add(Funcionarios);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(funcionarios.Where(m => m.FuncionarioId == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(funcionarios.Where(m => m.FuncionarioId == id).First());
        }
    }
}


