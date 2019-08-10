namespace WebApp.Models.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CLIENTE()
        {
            TB_CONTAS_RECEBER = new HashSet<TB_CONTAS_RECEBER>();
            TB_ORDEM_SERVICO = new HashSet<TB_ORDEM_SERVICO>();
            TB_PEDIDO = new HashSet<TB_PEDIDO>();
            TB_USUARIO = new HashSet<TB_USUARIO>();
        }

        [Key]
        public int ID_CLIENTE { get; set; }

        public int ID_USUARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOME_CLIENTE { get; set; }

        [StringLength(50)]
        public string ENDERECO_CLIENTE { get; set; }

        [StringLength(10)]
        public string NR_CASA_CLIENTE { get; set; }

        [StringLength(50)]
        public string COMPLEMENTO_CASA_CLIENTE { get; set; }

        [StringLength(50)]
        public string BAIRRO_CLIENTE { get; set; }

        [StringLength(50)]
        public string CIDADE_CLIENTE { get; set; }

        public decimal? LATITUDE_CLIENTE { get; set; }

        public decimal? LONGITUDE_CLIENTE { get; set; }

        [StringLength(20)]
        public string TELEFONE_CLIENTE { get; set; }

        [StringLength(20)]
        public string CELULAR_CLIENTE { get; set; }

        [StringLength(100)]
        public string EMAIL_CLIENTE { get; set; }

        [StringLength(2)]
        public string UF_CLIENTE { get; set; }

        [StringLength(2)]
        public string TIPO_PESSOA_CLIENTE { get; set; }

        [StringLength(20)]
        public string RG_CLIENTE { get; set; }

        [StringLength(2)]
        public string UF_RG_CLIENTE { get; set; }

        [StringLength(20)]
        public string CPF_CNPJ_CLIENTE { get; set; }

        public DateTime? DATA_CADASTRO_CLIENTE { get; set; }

        [StringLength(255)]
        public string FOTO_CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_CONTAS_RECEBER> TB_CONTAS_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ORDEM_SERVICO> TB_ORDEM_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_PEDIDO> TB_PEDIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USUARIO> TB_USUARIO { get; set; }
    }
}
