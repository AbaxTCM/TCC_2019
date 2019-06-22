using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Cozinha
    {
        [DisplayName("ID Pedido")]
        public int idPedido { get; set; }
        [DisplayName("Mesa")]
        [Required(ErrorMessage = "Preencha o campo mesa")]
        public Reserva.Mesa mesa { get; set; }
        [DisplayName("Prato")]
        [Required(ErrorMessage = "Preencha o campo prato")]
        public Cardapio.Prato prato { get; set; }
        [DisplayName("Bebida")]
        [Required(ErrorMessage = "Preencha o campo bebida")]
        public Cardapio.Bebida bebida { get; set; }
        [Required(ErrorMessage = "Preencha o campo sobremesa")]
        [DisplayName("Sobremesa")]
        public Cardapio.Sobremesa sobremesa { get; set; }
    }
}
