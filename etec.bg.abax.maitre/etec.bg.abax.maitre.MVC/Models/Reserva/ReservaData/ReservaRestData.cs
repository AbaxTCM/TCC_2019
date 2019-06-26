using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Models.Reserva.ReservaData
{
    public class ReservaRestData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Reserva> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from reserva where idRestaurante = " + Session.Instance.RestID, conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Reserva> lista = new List<Reserva>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Reserva reservaRest = new Reserva();
                reservaRest.idReserva = int.Parse(dr["idReserva"].ToString());
                reservaRest.mesa = dr["mesa"].ToString();
                reservaRest.finalidade = dr["finalidade"].ToString();
                reservaRest.agenda = DateTime.Parse(dr["agenda"].ToString());
                reservaRest.atendimento = dr["atendimento"].ToString();
                reservaRest.itens = dr["itens"].ToString();
                reservaRest.idCliente = int.Parse(dr["idCliente"].ToString());
                reservaRest.idRestaurante = int.Parse(dr["idRestaurante"].ToString());
                reservaRest.nomeCliente = dr["nomeCliente"].ToString();
                reservaRest.nomeRestaurante = dr["nomeRestaurante"].ToString();

                lista.Add(reservaRest);
            }
            return lista;
        }

        public Reserva GetReserva()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from reserva where idRestaurante = " + Session.Instance.RestID, conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Reserva reservaRest = new Reserva();
            if (ds.Tables[0].Rows.Count > 0)
            {
                reservaRest.idCliente = int.Parse(ds.Tables[0].Rows[0]["idReserva"].ToString());
                reservaRest.mesa = ds.Tables[0].Rows[0]["mesa"].ToString();
                reservaRest.finalidade = ds.Tables[0].Rows[0]["finalidade"].ToString();
                reservaRest.agenda = DateTime.Parse(ds.Tables[0].Rows[0]["agenda"].ToString());
                reservaRest.atendimento = ds.Tables[0].Rows[0]["atendimento"].ToString();
                reservaRest.itens = ds.Tables[0].Rows[0]["itens"].ToString().Replace("-", " | ");
                reservaRest.idCliente = int.Parse(ds.Tables[0].Rows[0]["idCliente"].ToString());
                reservaRest.idRestaurante = int.Parse(ds.Tables[0].Rows[0]["idRestaurante"].ToString());
                reservaRest.nomeCliente = ds.Tables[0].Rows[0]["nomeCliente"].ToString();
                reservaRest.nomeRestaurante = ds.Tables[0].Rows[0]["nomeRestaurante"].ToString();
            }
            return reservaRest;
        }
    }
}
