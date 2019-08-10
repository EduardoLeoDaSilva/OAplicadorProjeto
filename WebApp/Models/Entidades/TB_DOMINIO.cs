namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_DOMINIO
    {
        [Key]
        [Column(Order = 0)]
        public int ID_DOMINIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NOME_DOMINIO { get; set; }
    }
}
