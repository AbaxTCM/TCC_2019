using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models
{
    public class Cliente : AUsuarioRestaurante
    {
        public int id_cliente { get; set; }
        public string cpf { get; set; }
    }
}
