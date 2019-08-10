namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MODELO_AUTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MODELO_AUTO { get; set; }

        public int ID_MARCA_AUTO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_MODELO_AUTO { get; set; }
    }
}
