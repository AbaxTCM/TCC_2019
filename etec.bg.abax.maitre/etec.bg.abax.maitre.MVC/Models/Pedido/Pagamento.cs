using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Pagamento
    {
        [DisplayName("ID Pagamento")]
        public int idPagamento { get; set; }
        [DisplayName("Tipo")]
        public string tipo { get; set; }
    }
}
