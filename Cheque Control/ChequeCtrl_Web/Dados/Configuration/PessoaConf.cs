using ChequeCtrl_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChequeCtrl_Web.Dados.Configuration
{
    public class PessoaConf : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> etb)
        {
            etb.ToTable("PESSOAS");
            etb.HasKey(p => p.Id).HasName("PK_Pessoas");
            etb.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            etb.Property(p => p.Nome).HasColumnName("Nome").HasColumnType("varchar").HasMaxLength(100);
            etb.Property(p => p.CPF).HasColumnName("CPF").HasColumnType("varchar").HasMaxLength(11); //01321302118
            etb.Property(p => p.CNPJ).HasColumnName("CNPJ").HasColumnType("varchar").HasMaxLength(14); //01748192000188
            etb.Property(p => p.Telefone).HasColumnName("Telefone").HasColumnType("varchar").HasMaxLength(25);
            etb.Property(p => p.Endereco).HasColumnName("Endereco").HasColumnType("varchar").HasMaxLength(200);            
        }
    }
}
