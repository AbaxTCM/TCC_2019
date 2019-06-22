using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Finalidade
    {
        [DisplayName("ID Finalidade")]
        public int idFinalidade { get; set; }
        [DisplayName("Finalidade")]
        [Required(ErrorMessage = "Preencha o campo finalidade ")]
        public string nome { get; set; }
    }
}
