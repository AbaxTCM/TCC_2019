using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Cozinha
    {
        public int idPedido { get; set; }
        public Models.Reserva.Mesa mesa { get; set; }
        public Models.Cardapio.Prato prato { get; set; }
        public Models.Cardapio.Bebida bebida { get; set; }
        public Models.Cardapio.Sobremesa sobremesa { get; set; }
    }
}
