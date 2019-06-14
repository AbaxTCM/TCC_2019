using Microsoft.AspNetCore.Hosting.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class BebidaData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Bebida> GetLista()
        {
            conn.Conectar();
            DataSet ds = new DataSet();
            if (Session.Instance.Funcao == "rest")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from bebidas where id_rest = "+ Session.Instance.UserID, conn.RetornarConexao());
                da.Fill(ds);
            }
            else
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from bebidas", conn.RetornarConexao());
                da.Fill(ds);
            }

            conn.Desconectar();

            List<Bebida> lista = new List<Bebida>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Bebida bebida = new Bebida();
                bebida.idBebida = int.Parse(dr["id"].ToString());
                bebida.nome = dr["nome"].ToString();
                bebida.tipo = dr["tipo"].ToString();
                bebida.imagem = dr["imagem"].ToString();
                bebida.valor = decimal.Parse(dr["valor"].ToString());

                lista.Add(bebida);
            }
            return lista;
        }

        public Bebida GetBebida(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("sp_select_bebidas", conn.RetornarConexao());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Bebida bebida = new Bebida();
            if (ds.Tables[0].Rows.Count > 0)
            {
                bebida.idBebida = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                bebida.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                bebida.tipo = ds.Tables[0].Rows[0]["tipo"].ToString();
                bebida.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                bebida.valor = decimal.Parse(ds.Tables[0].Rows[0]["valor"].ToString());
            }
            return bebida;
        }

        public void PostBebida(Bebida bebida)
        {
            conn.Conectar();

            MySqlCommand cmd = new MySqlCommand("sp_insert_bebidas", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", bebida.nome);
            cmd.Parameters.AddWithValue("@p_tipo", bebida.tipo);
            cmd.Parameters.AddWithValue("@p_imagem", bebida.imagem);
            cmd.Parameters.AddWithValue("@p_valor", bebida.valor);
            cmd.Parameters.AddWithValue("@p_idRest", Session.Instance.RestID);
            cmd.ExecuteNonQuery();

            conn.Desconectar();
        }

        public void DeleteBebida(Bebida bebida, int id)
        {
            conn.Conectar();

            MySqlCommand cmd = new MySqlCommand("sp_delete_bebidas", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();

            conn.Desconectar();
        }

        public void EditBebida(Bebida bebida, int id)
        {
            conn.Conectar();

            MySqlCommand cmd = new MySqlCommand("sp_update_bebidas", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.Parameters.AddWithValue("@p_nome", bebida.nome);
            cmd.Parameters.AddWithValue("@p_tipo", bebida.tipo);
            cmd.Parameters.AddWithValue("@p_imagem", bebida.imagem);
            cmd.Parameters.AddWithValue("@p_valor", bebida.valor);
            cmd.ExecuteNonQuery();

            conn.Desconectar();
        }
    }
}
