using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Caixa
    {
        public int id_conta { get; set; }
        public Reserva.Mesa mesa { get; set; }
        public Cozinha cozinhaPedido { get; set; }
        public decimal total { get; set; }
        public Pagamento pagamento { get; set; }
    }
}
