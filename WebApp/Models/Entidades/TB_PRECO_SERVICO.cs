namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PRECO_SERVICO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SERVICO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_INICIO_VIGENCIA { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATA_FIM_VIGENCIA { get; set; }

        public decimal VALOR_SERVICO { get; set; }

        public virtual TB_SERVICO TB_SERVICO { get; set; }
    }
}
