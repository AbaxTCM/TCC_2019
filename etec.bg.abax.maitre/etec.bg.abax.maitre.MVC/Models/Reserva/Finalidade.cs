using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Finalidade
    {
        [DisplayName("ID Finalidade")]
        public int idFinalidade { get; set; }
        [DisplayName("Finalidade")]
        public string nome { get; set; }
    }
}
