using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Bebida : ClasseAbstrata.ACardapio
    {
        public int idBebida { get; set; }
        public string tipo { get; set; }
    }
}
