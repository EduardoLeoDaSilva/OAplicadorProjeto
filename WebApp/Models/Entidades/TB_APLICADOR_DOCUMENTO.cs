namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_APLICADOR_DOCUMENTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_DOCUMENTO { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_APLICADOR { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string TIPO_DOCUMENTO { get; set; }

        public virtual TB_APLICADOR TB_APLICADOR { get; set; }
    }
}
