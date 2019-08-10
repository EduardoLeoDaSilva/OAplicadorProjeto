namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_MARCA_MOTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MARCA_MOTO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_MARCA_MOTO { get; set; }
    }
}
