namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_USUARIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_USUARIO { get; set; }

        [Key]
        [StringLength(100)]
        public string EMAIL_USUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string SENHA_USUARIO { get; set; }

        [StringLength(30)]
        public string IP_ULTIMO_ACESSO { get; set; }

        public DateTime? DT_ULTIMO_ACESSO { get; set; }

        public virtual TB_APLICADOR TB_APLICADOR { get; set; }

        public virtual TB_CLIENTE TB_CLIENTE { get; set; }
    }
}
