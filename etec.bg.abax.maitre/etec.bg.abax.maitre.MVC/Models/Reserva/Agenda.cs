using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Agenda
    {
        [DisplayName("ID Agenda")]
        public int idAgenda { get; set; }
        [DisplayName("Data e Hora")]
        public DateTime dataHora { get; set; }
    }
}
