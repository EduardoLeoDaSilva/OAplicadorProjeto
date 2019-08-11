using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Entidades;
using WebApp.Models.ViewModels;

namespace WebApp.Mappers
{
    public class AutoMapperConfig
    {
        [Obsolete]
        public  static void RegistrarMappings()
        {
            var config = new MapperConfiguration(x => {
                ;
            });
            Mapper.Initialize(x => 
            {
                x.CreateMap<AplicadorViewModel, TB_APLICADOR>();
                });
        }

        

    }

}