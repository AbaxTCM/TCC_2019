using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Reserva.ReservaData
{
    public class ReservaRestData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

                    public List<Reserva> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from cliente", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Reserva> lista = new List<Reserva>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Reserva reservaRest = new Reserva();
                reservaRest.idReserva = int.Parse(dr["id"].ToString());
                reservaRest.mesa = dr["mesa"].ToString();
                reservaRest.finalidade = dr["finalidade"].ToString();
                reservaRest.agenda = DateTime.Parse(dr["agenda"].ToString());
                reservaRest.atendimento = bool.Parse(dr["atendimento"].ToString());

                lista.Add(reservaRest);
            }
            return lista;
        }
    }
}
