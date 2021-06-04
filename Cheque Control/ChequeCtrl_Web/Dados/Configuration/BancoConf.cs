using ChequeCtrl_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChequeCtrl_Web.Dados.Configuration
{
    public class BancoConf : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> etb)
        {
            etb.ToTable("BANCOS");
            etb.HasKey(b => b.Id).HasName("PK_Bancos");
            etb.Property(b => b.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            etb.Property(b => b.Codigo).HasColumnName("Codigo").HasColumnType("varchar").HasMaxLength(3);
            etb.Property(p => p.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
