namespace WebApp.Models.Entidades
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=OAplicadorModels")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TB_APLICADOR> TB_APLICADOR { get; set; }
        public virtual DbSet<TB_APLICADOR_CURSO> TB_APLICADOR_CURSO { get; set; }
        public virtual DbSet<TB_APLICADOR_DOCUMENTO> TB_APLICADOR_DOCUMENTO { get; set; }
        public virtual DbSet<TB_CLIENTE> TB_CLIENTE { get; set; }
        public virtual DbSet<TB_CONTAS_PAGAR> TB_CONTAS_PAGAR { get; set; }
        public virtual DbSet<TB_CONTAS_RECEBER> TB_CONTAS_RECEBER { get; set; }
        public virtual DbSet<TB_DOMINIO> TB_DOMINIO { get; set; }
        public virtual DbSet<TB_ITEM_DOMINIO> TB_ITEM_DOMINIO { get; set; }
        public virtual DbSet<TB_ITEM_ORDEM_SERVICO> TB_ITEM_ORDEM_SERVICO { get; set; }
        public virtual DbSet<TB_ITEM_PEDIDO> TB_ITEM_PEDIDO { get; set; }
        public virtual DbSet<TB_MARCA_AUTO> TB_MARCA_AUTO { get; set; }
        public virtual DbSet<TB_MARCA_MOTO> TB_MARCA_MOTO { get; set; }
        public virtual DbSet<TB_MODELO_AUTO> TB_MODELO_AUTO { get; set; }
        public virtual DbSet<TB_MODELO_MOTO> TB_MODELO_MOTO { get; set; }
        public virtual DbSet<TB_ORDEM_SERVICO> TB_ORDEM_SERVICO { get; set; }
        public virtual DbSet<TB_OS_AVALIACAO> TB_OS_AVALIACAO { get; set; }
        public virtual DbSet<TB_PEDIDO> TB_PEDIDO { get; set; }
        public virtual DbSet<TB_PRECO_SERVICO> TB_PRECO_SERVICO { get; set; }
        public virtual DbSet<TB_SERVICO> TB_SERVICO { get; set; }
        public virtual DbSet<TB_USUARIO> TB_USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_APLICADOR>()
                .Property(e => e.LATITUDE_APLICADOR)
                .HasPrecision(19, 8);

            modelBuilder.Entity<TB_APLICADOR>()
                .Property(e => e.LONGITUDE_APLICADOR)
                .HasPrecision(19, 8);

            modelBuilder.Entity<TB_APLICADOR>()
                .HasMany(e => e.TB_APLICADOR_CURSO)
                .WithRequired(e => e.TB_APLICADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_APLICADOR>()
                .HasMany(e => e.TB_APLICADOR_DOCUMENTO)
                .WithRequired(e => e.TB_APLICADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_APLICADOR>()
                .HasMany(e => e.TB_USUARIO)
                .WithRequired(e => e.TB_APLICADOR)
                .HasForeignKey(e => e.ID_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_APLICADOR>()
                .HasMany(e => e.TB_SERVICO)
                .WithMany(e => e.TB_APLICADOR)
                .Map(m => m.ToTable("TB_APLICADOR_SERVICO").MapLeftKey("ID_APLICADOR").MapRightKey("ID_SERVICO"));

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.LATITUDE_CLIENTE)
                .HasPrecision(19, 8);

            modelBuilder.Entity<TB_CLIENTE>()
                .Property(e => e.LONGITUDE_CLIENTE)
                .HasPrecision(19, 8);

            modelBuilder.Entity<TB_CLIENTE>()
                .HasMany(e => e.TB_CONTAS_RECEBER)
                .WithRequired(e => e.TB_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .HasMany(e => e.TB_ORDEM_SERVICO)
                .WithRequired(e => e.TB_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .HasMany(e => e.TB_PEDIDO)
                .WithRequired(e => e.TB_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_CLIENTE>()
                .HasMany(e => e.TB_USUARIO)
                .WithRequired(e => e.TB_CLIENTE)
                .HasForeignKey(e => e.ID_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_ITEM_ORDEM_SERVICO>()
                .Property(e => e.QUANTIDADE_SERVICO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<TB_ITEM_PEDIDO>()
                .Property(e => e.QUANTIDADE_SERVICO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<TB_ITEM_PEDIDO>()
                .Property(e => e.VALOR_ITEM_PEDIDO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<TB_ITEM_PEDIDO>()
                .Property(e => e.LARGURA_CM)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TB_ITEM_PEDIDO>()
                .Property(e => e.ALTURA_CM)
                .HasPrecision(11, 4);

            modelBuilder.Entity<TB_ORDEM_SERVICO>()
                .Property(e => e.VALOR_ORDEM_SERVICO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<TB_ORDEM_SERVICO>()
                .Property(e => e.PERCENTUAL_REPASSADO)
                .HasPrecision(7, 2);

            modelBuilder.Entity<TB_ORDEM_SERVICO>()
                .HasMany(e => e.TB_CONTAS_PAGAR)
                .WithRequired(e => e.TB_ORDEM_SERVICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_ORDEM_SERVICO>()
                .HasMany(e => e.TB_ITEM_ORDEM_SERVICO)
                .WithRequired(e => e.TB_ORDEM_SERVICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_ORDEM_SERVICO>()
                .HasOptional(e => e.TB_OS_AVALIACAO)
                .WithRequired(e => e.TB_ORDEM_SERVICO);

            modelBuilder.Entity<TB_OS_AVALIACAO>()
                .Property(e => e.NOTA_SERVICO)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_OS_AVALIACAO>()
                .Property(e => e.NOTA_APLICADOR)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_OS_AVALIACAO>()
                .Property(e => e.NOTA_PLATAFORMA)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TB_PEDIDO>()
                .Property(e => e.VALOR_PEDIDO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<TB_PEDIDO>()
                .HasMany(e => e.TB_CONTAS_RECEBER)
                .WithRequired(e => e.TB_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PEDIDO>()
                .HasMany(e => e.TB_ITEM_PEDIDO)
                .WithRequired(e => e.TB_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PEDIDO>()
                .HasMany(e => e.TB_ORDEM_SERVICO)
                .WithRequired(e => e.TB_PEDIDO)
                .HasForeignKey(e => e.ID_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PEDIDO>()
                .HasMany(e => e.TB_ORDEM_SERVICO1)
                .WithRequired(e => e.TB_PEDIDO1)
                .HasForeignKey(e => e.ID_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_PRECO_SERVICO>()
                .Property(e => e.VALOR_SERVICO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<TB_SERVICO>()
                .HasMany(e => e.TB_ITEM_ORDEM_SERVICO)
                .WithRequired(e => e.TB_SERVICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICO>()
                .HasMany(e => e.TB_ITEM_PEDIDO)
                .WithRequired(e => e.TB_SERVICO)
                .HasForeignKey(e => e.ID_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TB_SERVICO>()
                .HasMany(e => e.TB_PRECO_SERVICO)
                .WithRequired(e => e.TB_SERVICO)
                .WillCascadeOnDelete(false);
        }
    }
}
