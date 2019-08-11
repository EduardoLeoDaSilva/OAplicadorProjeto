using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Entidades;
using WebApp.Repositories;

namespace WebApp.Controllers
{
    public class CadastrosController : Controller
    {

        // GET: Cadastros

        private readonly IAplicadorRepository _aplicadorRepository;
        public CadastrosController(IAplicadorRepository aplicadorRepository)
        {
            _aplicadorRepository = aplicadorRepository;
        }

        [HttpGet]
        public ActionResult CadastroAplicador()
        {
            return View("cadastro-aplicador");
        }
        [HttpPost]
        public ActionResult CadastroAplicador(TB_APLICADOR aplicador)
        {
            if (ModelState.IsValid)
            {
                _aplicadorRepository.Salvar(aplicador);
            return View("cadastro-aplicador");
            }
            return new HttpNotFoundResult();
        }
    }
}