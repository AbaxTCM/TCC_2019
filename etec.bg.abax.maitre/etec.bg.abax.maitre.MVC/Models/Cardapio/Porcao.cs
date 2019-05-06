using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Porcao : Models.ClasseAbstrata.ACardapio
    {
        public int idPorcao { get; set; }
        public string descricao { get; set; }
    }
}
