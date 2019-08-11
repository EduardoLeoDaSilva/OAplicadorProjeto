using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models.ViewModels
{
    public class AplicadorViewModel
    {
        public AplicadorViewModel()
        {
        }

        [Key]
        public int ID_APLICADOR { get; set; }

        public int ID_USUARIO { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string NOME_APLICADOR { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]

        public string ENDERECO_APLICADOR { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]

        public string NR_CASA_APLICADOR { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]

        public string COMPLEMENTO_CASA_APLICADOR { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]

        public string BAIRRO_APLICADOR { get; set; }


        [Required(ErrorMessage = "Campo Requerido")]

        public string CIDADE_APLICADOR { get; set; }

        public decimal? LATITUDE_APLICADOR { get; set; }

        public decimal? LONGITUDE_APLICADOR { get; set; }


        public string TELEFONE_APLICADOR { get; set; }

        public string CELULAR_APLICADOR { get; set; }

        public string EMAIL_APLICADOR { get; set; }


        public string UF_APLICADOR { get; set; }

        public string TIPO_PESSOA_APLICADOR { get; set; }

        public string RG_APLICADOR { get; set; }

        public string UF_RG_APLICADOR { get; set; }

        public string CPF_CNPJ_APLICADOR { get; set; }

        public int? NR_BANCO_APLICADOR { get; set; }

        public string NR_AGENCIA_APLICADOR { get; set; }


        public string TIPO_CONTA_APLICADOR { get; set; }


        public string TIPO_OPERACAO_BANCARIA { get; set; }

        public DateTime? DATA_CADASTRO_APLICADOR { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase FOTO_APLICADOR { get; set; }

    }
}