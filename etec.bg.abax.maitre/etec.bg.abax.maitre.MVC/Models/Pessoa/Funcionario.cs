using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa
{
    public class Funcionario : Models.ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("ID Funcionário")]
        public int idFunc { get; set; }
        [DisplayName("Cargo")]
        public string cargo { get; set; }
        [DisplayName("Senha")]
        public string senha { get; set; }
    }
}
