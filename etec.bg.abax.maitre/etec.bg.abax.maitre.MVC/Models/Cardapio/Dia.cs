using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Dia
    {
        [DisplayName("Id Dia")]
        public int idDia { get; set; }
        [DisplayName("Dia da Semana")]
        public string nome { get; set; }
    }
}
