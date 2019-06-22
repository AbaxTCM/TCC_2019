using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.ClasseAbstrata
{
    public abstract class ACardapio
    {
        [Required(ErrorMessage = "Informe o produto")]
        [DisplayName("Nome")]
        public string nome { get; set; }
        [Required]
        [DisplayName("Imagem")]
        public string imagem { get; set; }
        [Required(ErrorMessage = "Informe o valor")]
        [DisplayName("Valor")]
        public decimal valor { get; set; }
    }
}
