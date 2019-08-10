namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ITEM_ORDEM_SERVICO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ORDEM_SERVICO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SERVICO { get; set; }

        [Required]
        [StringLength(2)]
        public string UN_MEDIDA { get; set; }

        public decimal QUANTIDADE_SERVICO { get; set; }

        public virtual TB_ORDEM_SERVICO TB_ORDEM_SERVICO { get; set; }

        public virtual TB_SERVICO TB_SERVICO { get; set; }
    }
}
