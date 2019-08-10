namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ITEM_DOMINIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_ITEM_DOMINIO { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_DOMINIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
