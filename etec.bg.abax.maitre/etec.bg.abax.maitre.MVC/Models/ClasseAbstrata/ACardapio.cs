using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.ClasseAbstrata
{
    public abstract class ACardapio
    {
        public string nome { get; set; }
        public byte[] imagem { get; set; }
        public decimal valor { get; set; }
    }
}
