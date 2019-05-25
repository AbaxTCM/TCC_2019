using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa
{
    public class Cliente : Models.ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("ID Cliente")]
        public int idCliente { get; set; }
        [DisplayName("CPF")]
        public string cpf { get; set; }
        [DisplayName("Senha")]
        public string senha { get; set; }
    }
}
