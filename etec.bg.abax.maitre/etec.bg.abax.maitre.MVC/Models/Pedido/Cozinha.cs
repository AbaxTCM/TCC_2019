using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Cozinha
    {
        public int id_pedido { get; set; }
        public Reserva.Mesa mesa { get; set; }
        public Cardapio.Prato prato { get; set; }
        public Cardapio.Bebida bebida { get; set; }
        public Cardapio.Sobremesa sobremesa { get; set; }
    }
}
