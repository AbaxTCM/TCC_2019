using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Caixa
    {
        [DisplayName("ID Conta")]
        public int idConta { get; set; }
        [Required(ErrorMessage = "Informe o numero da mesa")]
        [DisplayName("Mesa")]
        public Reserva.Mesa mesa { get; set; }
        [Required(ErrorMessage = "Informe o pedido")]
        [DisplayName("Pedido")]
        public Cozinha pedido { get; set; }
        [Required(ErrorMessage = "Informe o total")]
        [DisplayName("Total")]        
        public decimal total { get; set; }
        [Required(ErrorMessage = "Informe o tipo de pagamento")]
        [DisplayName("Tipo de Pagamento")]
        public Pagamento tipoPagamento { get; set; }
    }
}
