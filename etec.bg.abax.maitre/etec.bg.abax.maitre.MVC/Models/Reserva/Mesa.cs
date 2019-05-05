using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Mesa
    {
        public int id_mesa { get; set; }
        public string numero { get; set; }
        public int qtdePessoas { get; set; }
        public Finalidade finalidade { get; set; }
        public string ocupacao { get; set; }
    }
}
