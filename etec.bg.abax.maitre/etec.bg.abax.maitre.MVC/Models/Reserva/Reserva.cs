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
        [DisplayName("ID Cliente")]
        public int idRestaurante { get; set; }
        [DisplayName("ID Restaurante")]
        public int idCliente { get; set; }
        [DisplayName("Número da Mesa")]
        public string mesa { get; set; }
        [DisplayName("Finalidade")]
        public string finalidade { get; set; }
        [DisplayName("Dia e Hora")]
        public DateTime agenda { get; set; }
        [DisplayName("Desejo atendimento imediato!")]
        public string atendimento { get; set; }
        [DisplayName("Itens")]
        public string itens { get; set; }
        [DisplayName("Nome Cliente")]
        public string nomeCliente { get; set; }
        [DisplayName("Nome Restaurante")]
        public string nomeRestaurante { get; set; }
    }
}
