using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Prato : Models.ClasseAbstrata.ACardapio
    {
        public int idPrato { get; set; }
        public Dia diaSemana { get; set; }
    }
}
