using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Cozinha
    {
        [DisplayName("ID Pedido")]
        public int idPedido { get; set; }
        [DisplayName("Mesa")]
        public Reserva.Mesa mesa { get; set; }
        [DisplayName("Prato")]
        public Cardapio.Prato prato { get; set; }
        [DisplayName("Bebida")]
        public Cardapio.Bebida bebida { get; set; }
        [DisplayName("Sobremesa")]
        public Cardapio.Sobremesa sobremesa { get; set; }
    }
}
