using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Prato : Models.ClasseAbstrata.ACardapio
    {
        [DisplayName("ID Prato")]
        public int idPrato { get; set; }
        [DisplayName("Dia da Semana")]
        public string diaSemana { get; set; }
    }
}
