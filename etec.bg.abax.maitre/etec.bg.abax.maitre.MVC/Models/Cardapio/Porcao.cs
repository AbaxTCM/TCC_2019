using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Porcao : ClasseAbstrata.ACardapio
    {
        [DisplayName("ID")]
        public int idPorcao { get; set; }
        [DisplayName("Descrição")]
        public string descricao { get; set; }
    }
}
