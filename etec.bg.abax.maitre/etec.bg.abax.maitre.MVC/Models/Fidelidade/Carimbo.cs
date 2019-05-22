using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Fidelidade
{
    public class Carimbo
    {
        [DisplayName("ID Carimbo")]
        public int idCarimbo { get; set; }
        [DisplayName("Número")]
        public int numero { get; set; }
        [DisplayName("Cliente")]
        public Pessoa.Cliente cliente { get; set; }
    }
}
