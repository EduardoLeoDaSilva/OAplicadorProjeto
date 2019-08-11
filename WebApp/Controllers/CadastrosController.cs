using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models.Entidades;
using WebApp.Models.ViewModels;
using WebApp.Repositories;

namespace WebApp.Controllers
{
    public class CadastrosController : Controller
    {
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
        public ActionResult CadastroAplicador(AplicadorViewModel aplicador)
        {
            if (ModelState.IsValid)
            {
                var aplcadorEntidade = AutoMapper.Mapper.Map<AplicadorViewModel, TB_APLICADOR> (aplicador);
                _aplicadorRepository.Salvar(aplcadorEntidade);
            return View("cadastro-aplicador");
            }
            return new HttpNotFoundResult();
        }
    }
}