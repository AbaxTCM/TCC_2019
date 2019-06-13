using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class SobremesaData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Sobremesa> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from sobremesa", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Sobremesa> lista = new List<Sobremesa>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Sobremesa sobremesa = new Sobremesa();
                sobremesa.idSobremesa = int.Parse(dr["id"].ToString());
                sobremesa.nome = dr["nome"].ToString();
                sobremesa.imagem = dr["imagem"].ToString();
                sobremesa.valor = decimal.Parse(dr["valor"].ToString());

                lista.Add(sobremesa);
            }
            return lista;
        }

        public Sobremesa GetSobremesa(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("sp_select_sobremesa", conn.RetornarConexao());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Sobremesa sobremesa = new Sobremesa();
            if (ds.Tables[0].Rows.Count > 0)
            {
                sobremesa.idSobremesa = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                sobremesa.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                sobremesa.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                sobremesa.valor = decimal.Parse(ds.Tables[0].Rows[0]["valor"].ToString());
            }
            return sobremesa;
        }

        public void PostSobremesa(Sobremesa sobremesa)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_insert_sobremesa", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", sobremesa.nome);
            cmd.Parameters.AddWithValue("@p_imagem", sobremesa.imagem);
            cmd.Parameters.AddWithValue("@p_valor", sobremesa.valor);
            cmd.Parameters.AddWithValue("@p_idRest", Session.Instance.UserID);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void DeleteSobremesa(Sobremesa sobremesa, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_delete_sobremesa", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void EditSobremesa(Sobremesa sobremesa, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_update_sobremesa", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", sobremesa.nome);
            cmd.Parameters.AddWithValue("@p_imagem", sobremesa.imagem);
            cmd.Parameters.AddWithValue("@p_valor", sobremesa.valor);
            cmd.Parameters.AddWithValue("@p_id", sobremesa.idSobremesa);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }
    }
}
