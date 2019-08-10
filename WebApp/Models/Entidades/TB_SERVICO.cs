namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SERVICO()
        {
            TB_ITEM_ORDEM_SERVICO = new HashSet<TB_ITEM_ORDEM_SERVICO>();
            TB_ITEM_PEDIDO = new HashSet<TB_ITEM_PEDIDO>();
            TB_PRECO_SERVICO = new HashSet<TB_PRECO_SERVICO>();
            TB_APLICADOR = new HashSet<TB_APLICADOR>();
        }

        [Key]
        public int ID_SERVICO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_SERVICO { get; set; }

        [StringLength(2)]
        public string UNIDADE_MEDIDA { get; set; }

        public DateTime? DATA_CADASTRO { get; set; }

        [StringLength(3)]
        public string GRUPO_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEM_ORDEM_SERVICO> TB_ITEM_ORDEM_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ITEM_PEDIDO> TB_ITEM_PEDIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PRECO_SERVICO> TB_PRECO_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_APLICADOR> TB_APLICADOR { get; set; }
    }
}
