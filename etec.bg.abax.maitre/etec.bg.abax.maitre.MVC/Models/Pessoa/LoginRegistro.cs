using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa
{
    public class LoginRegistro : Models.ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("CPF")]
        public string cpf { get; set; }
        [DisplayName("Cargo")]
        public string cargo { get; set; }
        [DisplayName("Senha")]
        public string senha { get; set; }
        public string telefone { get; set; }
    }
}
