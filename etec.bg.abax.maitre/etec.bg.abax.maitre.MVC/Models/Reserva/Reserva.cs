using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Reserva
    {
        [DisplayName("Número da Reserva")]
        public int idReserva { get; set; }

        [DisplayName("Número da Mesa")]
        public Mesa mesa { get; set; }

        [DisplayName("Finalidade")]
        public Finalidade finalidade { get; set; }

        [DisplayName("Dia e Hora")]
        public Agenda agenda { get; set; }

        [DisplayName("Desejo atendimento imediato!")]
        public bool atendimento { get; set; }
    }
}
