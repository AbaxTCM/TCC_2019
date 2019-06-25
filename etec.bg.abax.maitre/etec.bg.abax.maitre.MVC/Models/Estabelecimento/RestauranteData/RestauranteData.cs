using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Models.Estabelecimento.RestauranteData
{
    public class RestauranteData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Restaurante> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from restaurante", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Restaurante> lista = new List<Restaurante>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Restaurante restaurante = new Restaurante();
                restaurante.idRestaurante = int.Parse(dr["id_rest"].ToString());
                restaurante.nome = dr["nome"].ToString();
                restaurante.fone = dr["fone"].ToString();
                restaurante.eMail = dr["email"].ToString();
                restaurante.endereco = dr["endereco"].ToString();
                restaurante.cnpj = dr["cnpj"].ToString();
                restaurante.imagem = dr["imagem"].ToString();
                restaurante.senha = dr["senha"].ToString();

                lista.Add(restaurante);
            }
            return lista;
        }

        public Restaurante GetRestaurante(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("sp_select_restaurante", conn.RetornarConexao());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_id_rest", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Restaurante restaurante = new Restaurante();
            if (ds.Tables[0].Rows.Count > 0)
            {
                restaurante.idRestaurante = int.Parse(ds.Tables[0].Rows[0]["id_rest"].ToString());
                restaurante.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                restaurante.fone = ds.Tables[0].Rows[0]["fone"].ToString();
                restaurante.eMail = ds.Tables[0].Rows[0]["email"].ToString();
                restaurante.endereco = ds.Tables[0].Rows[0]["endereco"].ToString();
                restaurante.cnpj = ds.Tables[0].Rows[0]["cnpj"].ToString();
                restaurante.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                restaurante.funcao = ds.Tables[0].Rows[0]["funcao"].ToString();
            }
            return restaurante;
        }

        public Restaurante GetRestaurante(string email, string senha)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from restaurante where email = @email and senha = @senha", conn.RetornarConexao());
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@email", email);
            da.SelectCommand.Parameters.AddWithValue("@senha", senha);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Restaurante restaurante = new Restaurante();
            if (ds.Tables[0].Rows.Count > 0)
            {
                restaurante.idRestaurante = int.Parse(ds.Tables[0].Rows[0]["id_rest"].ToString());
                restaurante.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                restaurante.fone = ds.Tables[0].Rows[0]["fone"].ToString();
                restaurante.eMail = ds.Tables[0].Rows[0]["email"].ToString();
                restaurante.endereco = ds.Tables[0].Rows[0]["endereco"].ToString();
                restaurante.cnpj = ds.Tables[0].Rows[0]["cnpj"].ToString();
                restaurante.senha = ds.Tables[0].Rows[0]["senha"].ToString();
                restaurante.funcao = ds.Tables[0].Rows[0]["funcao"].ToString();

                Session.Instance.UserID = restaurante.idRestaurante;
                Session.Instance.RestID = restaurante.idRestaurante;
                Session.Instance.Funcao = restaurante.funcao;
                Session.Instance.Nome = restaurante.nome.Split(" ").FirstOrDefault();
            }
            return restaurante;
        }

        public void PostRestaurante(Restaurante restaurante)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_insert_restaurante", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_imagem", "restaurante.jpg");
            cmd.Parameters.AddWithValue("@p_nome", restaurante.nome);
            cmd.Parameters.AddWithValue("@p_fone", restaurante.fone);
            cmd.Parameters.AddWithValue("@p_email", restaurante.eMail);
            cmd.Parameters.AddWithValue("@p_endereco", restaurante.endereco);
            cmd.Parameters.AddWithValue("@p_cnpj", restaurante.cnpj);
            cmd.Parameters.AddWithValue("@p_senha", restaurante.senha);
            cmd.Parameters.AddWithValue("@p_funcao", restaurante.funcao);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void DeleteRestaurante(Restaurante restaurante, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_delete_restaurante", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void EditRestaurante(Restaurante restaurante, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_update_restaurante", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", restaurante.nome);
            cmd.Parameters.AddWithValue("@p_fone", restaurante.fone);
            cmd.Parameters.AddWithValue("@p_email", restaurante.eMail);
            cmd.Parameters.AddWithValue("@p_endereco", restaurante.endereco);
            cmd.Parameters.AddWithValue("@p_cnpj", restaurante.cnpj);
            cmd.Parameters.AddWithValue("@p_id_rest", id);
            cmd.Parameters.AddWithValue("@p_senha", restaurante.senha);
            cmd.Parameters.AddWithValue("@p_imagem", restaurante.imagem);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }
    }
}
