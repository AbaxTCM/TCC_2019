using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Cardapio
    {
        public int id_menu { get; set; }
        public Prato prato { get; set; }
        public Bebida bebida { get; set; }
        public Porcao porcao { get; set; }
        public Sobremesa sobremesa { get; set; }
    }
}
