namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CONTAS_PAGAR
    {
        [Key]
        public int ID_CONTAS_PAGAR { get; set; }

        public int ID_ORDEM_SERVICO { get; set; }

        public int ID_APLICADOR { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO_CONTA { get; set; }

        public int STATUS_TRANSACAO { get; set; }

        [StringLength(20)]
        public string CPF_CNPJ { get; set; }

        public int? NR_BANCO { get; set; }

        [StringLength(20)]
        public string NR_AGENCIA { get; set; }

        [StringLength(2)]
        public string TIPO_CONTA { get; set; }

        public DateTime? DATA_PREVISTA { get; set; }

        public DateTime? DATA_EFETIVADA { get; set; }

        public virtual TB_ORDEM_SERVICO TB_ORDEM_SERVICO { get; set; }
    }
}
