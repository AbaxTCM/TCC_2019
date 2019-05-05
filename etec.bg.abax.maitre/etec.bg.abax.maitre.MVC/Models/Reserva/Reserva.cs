using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public Mesa mesa { get; set; }
        public Finalidade finalidade { get; set; }
        public Agenda agenda { get; set; }
        public string atendimento { get; set; }
    }
}
