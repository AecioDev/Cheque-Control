using System.Collections.Generic;

namespace ChequeCtrl_Web.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public virtual IEnumerable<Cheque> Cheques { get; set; }

        public virtual IEnumerable<Cheque> ChequesRepassados { get; set; }
    }
}
