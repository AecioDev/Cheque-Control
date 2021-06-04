using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChequeCtrl_Web.Models
{
    public class Cheque
    {
        public int Id { get; set; }
        public int? BancoId { get; set; }
        public int? PessoaId { get; set; }
        public int? Numero { get; set; }
        public int? Folha { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? Emissao { get; set; }
        public DateTime? Vencimento { get; set; }
        public string Tipo { get; set; } //Cruzado Sim/Não
        public string Situacao { get; set; } //Pago / Aberto / Negociado
        public int? Passou_Para { get; set; } //Passou pra Quem?

        public virtual Banco Bancos { get; set; }
        public virtual Pessoa PessoaDono { get; set; }
        public virtual Pessoa PessoaPegou { get; set; }
    }
}
