using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Porcao : ClasseAbstrata.ACardapio
    {
        [DisplayName("ID")]
        public int idPorcao { get; set; }
        [Required(ErrorMessage = "Entre com a discrição da porção")]
        [DisplayName("Descrição")]
        public string descricao { get; set; }
    }
}
