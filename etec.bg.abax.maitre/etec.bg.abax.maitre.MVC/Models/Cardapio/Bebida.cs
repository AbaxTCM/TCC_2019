using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio
{
    public class Bebida : ClasseAbstrata.ACardapio
    {
        [DisplayName("ID")]
        public int idBebida { get; set; }
        [Required(ErrorMessage = "Informe o Tipo da Bebida")]
        //[RegularExpression(@"\d{2}/\d{2}/\d{4}", ErrorMessage = "Por favor digite os valores neste padrão (00/00/0000)")]
        [DisplayName("Tipo")]
        public string tipo { get; set; }
    }
}
