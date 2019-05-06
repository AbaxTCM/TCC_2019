using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.ClasseAbstrata
{
    public abstract class AUsuarioRestaurante
    {
        public string nome { get; set; }
        public string fone { get; set; }
        public string eMail { get; set; }
    }
}
