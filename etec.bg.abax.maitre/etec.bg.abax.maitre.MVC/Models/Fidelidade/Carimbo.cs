using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Fidelidade
{
    public class Carimbo
    {
        public int id_carimbo { get; set; }
        public int numero { get; set; }
        public Cliente cliente { get; set; }
    }
}
