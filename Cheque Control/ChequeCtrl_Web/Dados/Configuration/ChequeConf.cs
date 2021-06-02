using ChequeCtrl_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChequeCtrl_Web.Dados.Configuration
{
    public class ChequeConf : IEntityTypeConfiguration<Cheque>
    {
        public void Configure(EntityTypeBuilder<Cheque> etb)
        {
            etb.ToTable("CHEQUES");
            etb.HasKey(a => a.Id).HasName("PK_Cheques");
            etb.Property(a => a.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            etb.Property(a => a.BancoId).HasColumnName("Banco");
            etb.Property(a => a.PessoaId).HasColumnName("Dono");
            etb.Property(a => a.Numero).HasColumnName("Numero");
            etb.Property(a => a.Folha).HasColumnName("Folha");
            etb.Property(a => a.Valor).HasColumnName("Valor").HasColumnType("money");
            etb.Property(a => a.Emissao).HasColumnName("Emissao").HasColumnType("date");
            etb.Property(a => a.Emissao).HasColumnName("Vencimento").HasColumnType("date");
            etb.Property(a => a.Tipo).HasColumnName("Tipo").HasColumnType("char(1)");
            etb.Property(a => a.Situacao).HasColumnName("Situacao").HasColumnType("char(1)");
            etb.Property(a => a.Passou_Para).HasColumnName("Passou_Pra_Quem");

            etb.HasOne(b => b.Bancos).WithMany(c => c.Cheques)
            .HasForeignKey(b => b.BancoId)
            .OnDelete(DeleteBehavior.NoAction);

            etb.HasOne(p1 => p1.PessoaDono).WithMany(d => d.Cheques)
            .HasForeignKey(p1 => p1.PessoaId)
            .OnDelete(DeleteBehavior.NoAction);

            etb.HasOne(p2 => p2.PessoaPegou).WithMany(d => d.ChequesRepassados)
            .HasForeignKey(p2 => p2.Passou_Para)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
