using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class PratoData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Prato> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from prato", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Prato> lista = new List<Prato>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Prato prato = new Prato();
                prato.idPrato = int.Parse(dr["id"].ToString());
                prato.nome = dr["nome"].ToString();
                prato.diaSemana.idDia = int.Parse(dr["id"].ToString());
                //prato.imagem = byte.Parse(dr["imagem"].ToString());
                prato.valor = decimal.Parse(dr["valor"].ToString());

                lista.Add(prato);
            }
            return lista;
        }

        public Prato GetPrato(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("sp_select_pratos", conn.RetornarConexao());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Prato prato = new Prato();
            if (ds.Tables[0].Rows.Count > 0)
            {
                prato.idPrato = int.Parse(ds.Tables[0].Rows[0]["id_prato"].ToString());
                prato.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                prato.diaSemana.idDia = int.Parse(ds.Tables[0].Rows[0]["id_dia"].ToString());
                //cliente.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                prato.valor = decimal.Parse(ds.Tables[0].Rows[0]["valor"].ToString());
            }
            return prato;
        }

        public void PostPrato(Prato prato)
        {
            conn.Conectar();

            MySqlCommand cmd = new MySqlCommand("sp_insert_Pratos", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_dia", prato.diaSemana.idDia);
            cmd.Parameters.AddWithValue("@p_nome", prato.nome);
            cmd.Parameters.AddWithValue("@p_imagem", prato.imagem);
            cmd.Parameters.AddWithValue("@p_valor", prato.valor);
            cmd.ExecuteNonQuery();

            conn.Desconectar();
        }

        public void DeletePrato(Prato prato, int id)
        {
            conn.Conectar();

            MySqlCommand cmd = new MySqlCommand("sp_delete_pratos", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();

            conn.Desconectar();
        }

        public void EditPrato(Prato prato, int id)
        {
            conn.Conectar();

            MySqlCommand cmd = new MySqlCommand("sp_update_pratos", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.Parameters.AddWithValue("@p_nome", prato.nome);
            cmd.Parameters.AddWithValue("@p_imagem", prato.imagem);
            cmd.Parameters.AddWithValue("@p_valor", prato.valor);
            cmd.Parameters.AddWithValue("@p_dia", prato.diaSemana.idDia);
            cmd.ExecuteNonQuery();

            conn.Desconectar();
        }
    }
}
