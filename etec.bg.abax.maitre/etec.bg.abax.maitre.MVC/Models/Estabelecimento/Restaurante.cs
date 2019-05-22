using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Estabelecimento
{
    public class Restaurante : ClasseAbstrata.AUsuarioRestaurante
    {
        [DisplayName("ID Restaurante")]
        public int idRestaurante { get; set; }
        [DisplayName("Endereço")]
        public string endereco { get; set; }
        [DisplayName("CNPJ")]
        public string cnpj { get; set; }
    }
}
