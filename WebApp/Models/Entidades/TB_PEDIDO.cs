namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_PEDIDO()
        {
            TB_CONTAS_RECEBER = new HashSet<TB_CONTAS_RECEBER>();
            TB_ITEM_PEDIDO = new HashSet<TB_ITEM_PEDIDO>();
            TB_ORDEM_SERVICO = new HashSet<TB_ORDEM_SERVICO>();
            TB_ORDEM_SERVICO1 = new HashSet<TB_ORDEM_SERVICO>();
        }

        [Key]
        public int ID_PEDIDO { get; set; }

        public int TIPO_PEDIDO { get; set; }

        public DateTime? DATA_PEDIDO { get; set; }

        public int STATUS_PEDIDO { get; set; }

        public int ID_CLIENTE { get; set; }

        public decimal VALOR_PEDIDO { get; set; }

        [StringLength(1000)]
        public string OBS_PEDIDO { get; set; }

        public int? ID_APLICADOR_INDICACAO { get; set; }

        public int? ID_CLIENTE_INDICACAAO { get; set; }

        public virtual TB_CLIENTE TB_CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CONTAS_RECEBER> TB_CONTAS_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEM_PEDIDO> TB_ITEM_PEDIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ORDEM_SERVICO> TB_ORDEM_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ORDEM_SERVICO> TB_ORDEM_SERVICO1 { get; set; }
    }
}
