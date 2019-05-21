using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.ClasseAbstrata
{
    public abstract class AUsuarioRestaurante
    {
        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Telefone")]
        public string fone { get; set; }
        [DisplayName("E-mail")]
        public string eMail { get; set; }
    }
}
