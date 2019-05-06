using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Caixa
    {
        public int idConta { get; set; }
        public Models.Reserva.Mesa mesa { get; set; }
        public Cozinha pedido { get; set; }
        public decimal total { get; set; }
        public Pagamento tipoPagamento { get; set; }
    }
}
