using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoProdutosNaoPereciveis.Models;

namespace ProjetoProdutosNaoPereciveis.Controllers
{
    public class HomeController : Controller
    {
        // GET: ProdutoNaoPerecivel
        public ActionResult Index()
        {
            var naoPerecivel = new NaoPereciveis();
            return View(naoPerecivel);
        }
        [HttpPost]
        public ActionResult Index(NaoPereciveis naoPerecivel)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", naoPerecivel);
            }
            return View(naoPerecivel);
        }
        public ActionResult Resultado(NaoPereciveis naoPerecivel)
        {
            return View(naoPerecivel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}