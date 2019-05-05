using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Prato : ACardapio
    {
        public int id_prato { get; set; }
        public Dia diaSemana { get; set; }
    }
}
