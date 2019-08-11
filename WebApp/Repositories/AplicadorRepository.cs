using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Entidades;

namespace WebApp.Repositories
{
    public class AplicadorRepository : IAplicadorRepository
    {
        private readonly Model1 _applicationContext;
        public AplicadorRepository(Model1 applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Salvar(TB_APLICADOR aplicador)
        {
            if (aplicador != null)
            {
                _applicationContext.Set<TB_APLICADOR>().Add(aplicador);
                _applicationContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException($"O parametro {nameof(aplicador)} é nulo");
            }
        }
    }
}