using ChequeCtrl_Web.Dados.Configuration;
using ChequeCtrl_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ChequeCtrl_Web.Dados.Context
{
    public class ChequeContext : DbContext
    {
        public ChequeContext(DbContextOptions<ChequeContext> options) 
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.HasDefaultSchema("chq");
            
            mb.ApplyConfiguration(new BancoConf());
            mb.ApplyConfiguration(new ChequeConf());
            mb.ApplyConfiguration(new PessoaConf());
        }

        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
