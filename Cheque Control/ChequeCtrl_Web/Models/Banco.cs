using System.Collections.Generic;

namespace ChequeCtrl_Web.Models
{
    public class Banco
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public virtual IEnumerable<Cheque> Cheques { get; set; }
    }
}
