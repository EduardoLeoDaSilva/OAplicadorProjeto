namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_OS_AVALIACAO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_AVALIACAO { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ORDEM_SERVICO { get; set; }

        public decimal NOTA_SERVICO { get; set; }

        [StringLength(500)]
        public string OBS_SERVICO { get; set; }

        public decimal NOTA_APLICADOR { get; set; }

        [StringLength(500)]
        public string OBS_APLICADOR { get; set; }

        public decimal NOTA_PLATAFORMA { get; set; }

        [StringLength(500)]
        public string OBS_PLATAFORMA { get; set; }

        public virtual TB_ORDEM_SERVICO TB_ORDEM_SERVICO { get; set; }
    }
}
