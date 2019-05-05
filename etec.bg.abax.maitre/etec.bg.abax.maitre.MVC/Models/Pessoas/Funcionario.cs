using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models
{
    public class Funcionario : AUsuarioRestaurante
    {
        public int id_func { get; set; }
        public string cargo { get; set; }
    }
}
