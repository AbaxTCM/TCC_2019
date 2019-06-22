using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Estabelecimento
{
    public class Restaurante : ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("ID Restaurante")]
        public int idRestaurante { get; set; }
        [Required(ErrorMessage = "Preencha o campo endereço")]
        [DisplayName("Endereço")]
        public string endereco { get; set; }
        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [DisplayName("CNPJ")]
        public string cnpj { get; set; }
        [Required]
        [DisplayName("Imagem")]
        public string imagem { get; set; }
        [Required(ErrorMessage = "Preencha o campo senha")]
        [DisplayName("Senha")]
        public string senha { get; set; }
    }
}
