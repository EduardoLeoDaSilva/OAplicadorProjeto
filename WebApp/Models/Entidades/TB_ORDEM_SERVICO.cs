namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ORDEM_SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_ORDEM_SERVICO()
        {
            TB_CONTAS_PAGAR = new HashSet<TB_CONTAS_PAGAR>();
            TB_ITEM_ORDEM_SERVICO = new HashSet<TB_ITEM_ORDEM_SERVICO>();
        }

        [Key]
        public int ID_ORDEM_SERVICO { get; set; }

        public int ID_PEDIDO { get; set; }

        public int ID_CLIENTE { get; set; }

        public int ID_APLICADOR { get; set; }

        public int TIPO_ORDEM_SERVICO { get; set; }

        public DateTime? DATA_ORDEM_SERVICO { get; set; }

        public DateTime? DATA_PREVISTA { get; set; }

        public DateTime? DATA_EFETIVADA { get; set; }

        [Required]
        [StringLength(3)]
        public string STATUS_ORDEM_SERVICO { get; set; }

        public decimal VALOR_ORDEM_SERVICO { get; set; }

        public decimal PERCENTUAL_REPASSADO { get; set; }

        [Required]
        [StringLength(1000)]
        public string OBS_ORDEM_SERVICO { get; set; }

        public virtual TB_CLIENTE TB_CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CONTAS_PAGAR> TB_CONTAS_PAGAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEM_ORDEM_SERVICO> TB_ITEM_ORDEM_SERVICO { get; set; }

        public virtual TB_PEDIDO TB_PEDIDO { get; set; }

        public virtual TB_PEDIDO TB_PEDIDO1 { get; set; }

        public virtual TB_OS_AVALIACAO TB_OS_AVALIACAO { get; set; }
    }
}
