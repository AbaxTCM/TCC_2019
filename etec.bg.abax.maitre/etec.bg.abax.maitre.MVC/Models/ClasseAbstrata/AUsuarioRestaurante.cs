using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.ClasseAbstrata
{
    public abstract class AUsuarioRestaurante
    {
        [Required(ErrorMessage = "Preencha o campo nome")]
        [DisplayName("Nome")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo telefone")]
        [DisplayName("Telefone")]
        public string fone { get; set; }
        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [DisplayName("E-mail")]
        public string eMail { get; set; }
        [Required(ErrorMessage = "Preencha o campo função")]
        [DisplayName("Função")]
        public string funcao { get; set; }
    }
}
