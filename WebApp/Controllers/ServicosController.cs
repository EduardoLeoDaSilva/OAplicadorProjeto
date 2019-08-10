using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ServicosController : Controller
    {
        // GET: Servicos
        public ActionResult ServicoBau()
        {
            return View("servico-bau");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}