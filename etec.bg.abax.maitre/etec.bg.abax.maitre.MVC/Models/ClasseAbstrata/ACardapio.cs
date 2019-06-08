using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.ClasseAbstrata
{
    public abstract class ACardapio
    {
        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Imagem")]
        public string imagem { get; set; }
        [DisplayName("Valor")]
        public decimal valor { get; set; }
    }
}
