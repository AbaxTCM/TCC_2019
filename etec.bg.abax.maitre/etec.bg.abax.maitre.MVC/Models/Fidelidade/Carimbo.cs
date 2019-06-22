using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Fidelidade
{
    public class Carimbo
    {
        [DisplayName("ID Carimbo")]
        public int idCarimbo { get; set; }
        [Required(ErrorMessage = "Preencha o campo número")]
        [DisplayName("Número")]
        public int numero { get; set; }
        [Required(ErrorMessage = "Preencha o campo cliente")]
        [DisplayName("Cliente")]
        public Pessoa.Cliente cliente { get; set; }
    }
}
