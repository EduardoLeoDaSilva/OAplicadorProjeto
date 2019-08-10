namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CONTAS_RECEBER
    {
        [Key]
        public int ID_CONTAS_RECEBER { get; set; }

        public int ID_PEDIDO { get; set; }

        public int ID_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO_CONTA { get; set; }

        public int STATUS_TRANSACAO { get; set; }

        [StringLength(2)]
        public string FORMA_PAGAMENTO { get; set; }

        public DateTime? DATA_PREVISTA { get; set; }

        public DateTime? DATA_EFETIVADA { get; set; }

        public virtual TB_CLIENTE TB_CLIENTE { get; set; }

        public virtual TB_PEDIDO TB_PEDIDO { get; set; }
    }
}
