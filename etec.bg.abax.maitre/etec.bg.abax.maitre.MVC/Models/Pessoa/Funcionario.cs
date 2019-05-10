using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa
{
    public class Cliente : Models.ClasseAbstrata.AUsuarioRestaurante
    {
        public int idFunc { get; set; }
        public string cargo { get; set; }
    }
}
