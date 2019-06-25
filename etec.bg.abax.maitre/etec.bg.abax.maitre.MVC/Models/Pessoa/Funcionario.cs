using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa
{
    public class Funcionario : Models.ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("ID Funcionário")]
        public int idFunc { get; set; }
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Preencha o campo cargo")]
        public string cargo { get; set; }
        [DisplayName("Senha")]
        [Required(ErrorMessage = "Preencha o campo senha")]
        public string senha { get; set; }
        public int idRest { get; set; }
    }
}
