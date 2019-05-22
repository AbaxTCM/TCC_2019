using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva
{
    public class Mesa
    {
        [DisplayName("ID Mesa")]
        public int idMesa { get; set; }
        [DisplayName("Número da Mesa")]
        public string numero { get; set; }
        [DisplayName("Quantidade de Pessoas")]
        public int qtdePessoas { get; set; }
        [DisplayName("Finalidade")]
        public Finalidade finalidade { get; set; }
        [DisplayName("Ocupação")]
        public string ocupacao { get; set; }
    }
}