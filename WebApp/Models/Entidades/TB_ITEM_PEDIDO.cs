namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ITEM_PEDIDO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PEDIDO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SERVICO { get; set; }

        [Required]
        [StringLength(2)]
        public string UN_MEDIDA { get; set; }

        public decimal QUANTIDADE_SERVICO { get; set; }

        public decimal VALOR_ITEM_PEDIDO { get; set; }

        public decimal? LARGURA_CM { get; set; }

        public decimal? ALTURA_CM { get; set; }

        public int? COD_MARCA { get; set; }

        public int? COD_MODELO { get; set; }

        public int? ANO_AUTO { get; set; }

        public int? QTDE_ESCADA_4M { get; set; }

        public int? QTDE_ADAIME_NR35 { get; set; }

        public int? QTDE_RAPEL_NR18 { get; set; }

        public bool? BAU_CORRUGADO { get; set; }

        public bool? BAU_REBITADO { get; set; }

        public virtual TB_PEDIDO TB_PEDIDO { get; set; }

        public virtual TB_SERVICO TB_SERVICO { get; set; }
    }
}
