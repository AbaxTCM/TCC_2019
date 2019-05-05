using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models
{
    public class Restaurante : AUsuarioRestaurante
    {
        public int id_rest { get; set; }
        public string endereco { get; set; }
        public string cnpj { get; set; }
    }
}
