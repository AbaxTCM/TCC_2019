using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pedido
{
    public class Pagamento
    {
        [DisplayName("ID Pagamento")]
        public int idPagamento { get; set; }
        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Informe o tipo de sobremesa")]
        public string tipo { get; set; }
    }
}
