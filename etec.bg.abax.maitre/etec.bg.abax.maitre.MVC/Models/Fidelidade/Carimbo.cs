using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Fidelidade
{
    public class Carimbo
    {
        public int idCarimbo { get; set; }
        public int numero { get; set; }
        public Models.Pessoa.Cliente cliente { get; set; }
    }
}
