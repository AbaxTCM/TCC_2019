using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Caixa
    {
        [DisplayName("ID Conta")]
        public int idConta { get; set; }
        [DisplayName("Mesa")]
        public Reserva.Mesa mesa { get; set; }
        [DisplayName("Pedido")]
        public Cozinha pedido { get; set; }
        [DisplayName("Total")]
        public decimal total { get; set; }
        [DisplayName("Tipo de Pagamento")]
        public Pagamento tipoPagamento { get; set; }
    }
}
