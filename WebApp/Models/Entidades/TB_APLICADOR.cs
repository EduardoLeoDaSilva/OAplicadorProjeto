namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_APLICADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_APLICADOR()
        {
            TB_APLICADOR_CURSO = new HashSet<TB_APLICADOR_CURSO>();
            TB_APLICADOR_DOCUMENTO = new HashSet<TB_APLICADOR_DOCUMENTO>();
            TB_USUARIO = new HashSet<TB_USUARIO>();
            TB_SERVICO = new HashSet<TB_SERVICO>();
        }

        [Key]
        public int ID_APLICADOR { get; set; }

        public int ID_USUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_APLICADOR { get; set; }

        [StringLength(50)]
        public string ENDERECO_APLICADOR { get; set; }

        [StringLength(10)]
        public string NR_CASA_APLICADOR { get; set; }

        [StringLength(50)]
        public string COMPLEMENTO_CASA_APLICADOR { get; set; }

        [StringLength(50)]
        public string BAIRRO_APLICADOR { get; set; }

        [StringLength(50)]
        public string CIDADE_APLICADOR { get; set; }

        public decimal? LATITUDE_APLICADOR { get; set; }

        public decimal? LONGITUDE_APLICADOR { get; set; }

        [StringLength(20)]
        public string TELEFONE_APLICADOR { get; set; }

        [StringLength(20)]
        public string CELULAR_APLICADOR { get; set; }

        [StringLength(100)]
        public string EMAIL_APLICADOR { get; set; }

        [StringLength(2)]
        public string UF_APLICADOR { get; set; }

        [StringLength(2)]
        public string TIPO_PESSOA_APLICADOR { get; set; }

        [StringLength(20)]
        public string RG_APLICADOR { get; set; }

        [StringLength(2)]
        public string UF_RG_APLICADOR { get; set; }

        [StringLength(20)]
        public string CPF_CNPJ_APLICADOR { get; set; }

        public int? NR_BANCO_APLICADOR { get; set; }

        [StringLength(20)]
        public string NR_AGENCIA_APLICADOR { get; set; }

        [StringLength(2)]
        public string TIPO_CONTA_APLICADOR { get; set; }

        [StringLength(10)]
        public string TIPO_OPERACAO_BANCARIA { get; set; }

        public DateTime? DATA_CADASTRO_APLICADOR { get; set; }

        [StringLength(255)]
        public string FOTO_APLICADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_APLICADOR_CURSO> TB_APLICADOR_CURSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_APLICADOR_DOCUMENTO> TB_APLICADOR_DOCUMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_SERVICO> TB_SERVICO { get; set; }
    }
}
