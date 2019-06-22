using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Agenda
    {
        [DisplayName("ID Agenda")]
        public int idAgenda { get; set; }
        [DisplayName("Data e Hora")]
        [Required(ErrorMessage = "Informe a data e a hora ")]
        public DateTime dataHora { get; set; }
    }
}
