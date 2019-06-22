using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa
{
    public class LoginRegistro : Models.ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("CPF")]
        [Required(ErrorMessage = "Preencha o campo CPF")]
        public string cpf { get; set; }
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Preencha o campo CARGO")]
        public string cargo { get; set; }
        [DisplayName("Senha")]
        [Required(ErrorMessage = "Preencha o campo senha")]
        public string senha { get; set; }
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Preencha o campo telefone")]
        public string telefone { get; set; }
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Preencha o campo endereço")]
        public string endereco { get; set; }
        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        public string cnpj { get; set; }
    }
}
