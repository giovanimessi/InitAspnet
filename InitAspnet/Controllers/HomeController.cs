using System;
using InitAspnet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InitAspnet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa()
            {
                Id = 1,
                Nome = "Giovani",
                tipo = "Administrador"
            };
            ViewData["Id"] = pessoa. Id;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["tipo"] = pessoa.tipo;

            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}