using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa.PessoaData
{
    public class FuncionarioData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Funcionario> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcionario where id_rest = @p_idRest",conn.RetornarConexao());
            da.SelectCommand.Parameters.AddWithValue("@p_idRest", Session.Instance.RestID);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Funcionario> lista = new List<Funcionario>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Funcionario funcionario = new Funcionario();
                funcionario.idFunc = int.Parse(dr["id"].ToString());
                funcionario.nome = dr["nome"].ToString();
                funcionario.cargo = dr["cargo"].ToString();
                funcionario.fone = dr["fone"].ToString();
                funcionario.eMail = dr["email"].ToString();
                funcionario.funcao = dr["funcao"].ToString();

                lista.Add(funcionario);
            }
            return lista;
        }

        public Funcionario GetFuncionario(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("sp_select_funcionario",conn.RetornarConexao());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Funcionario funcionario = new Funcionario();
            if (ds.Tables[0].Rows.Count > 0)
            {
                funcionario.idFunc = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                funcionario.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                funcionario.cargo = ds.Tables[0].Rows[0]["cargo"].ToString();
                funcionario.fone = ds.Tables[0].Rows[0]["fone"].ToString();
                funcionario.eMail = ds.Tables[0].Rows[0]["email"].ToString();
                funcionario.senha = ds.Tables[0].Rows[0]["senha"].ToString();
                funcionario.funcao = ds.Tables[0].Rows[0]["funcao"].ToString();
            }
            return funcionario;
        }

        public Funcionario GetFuncionario(string email, string senha)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcionario where email = @email and senha = @senha", conn.RetornarConexao());
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@email", email);
            da.SelectCommand.Parameters.AddWithValue("@senha", senha);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Funcionario funcionario = new Funcionario();
            if (ds.Tables[0].Rows.Count > 0)
            {
                funcionario.idFunc = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                funcionario.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                funcionario.cargo = ds.Tables[0].Rows[0]["cargo"].ToString();
                funcionario.fone = ds.Tables[0].Rows[0]["fone"].ToString();
                funcionario.eMail = ds.Tables[0].Rows[0]["email"].ToString();
                funcionario.senha = ds.Tables[0].Rows[0]["senha"].ToString();
                funcionario.funcao = ds.Tables[0].Rows[0]["funcao"].ToString();

                Session.Instance.UserID = funcionario.idFunc;
                Session.Instance.Funcao = funcionario.funcao;
                Session.Instance.Nome = funcionario.nome.Split(" ").FirstOrDefault();
            }
            return funcionario;
        }

        public void PostFuncionario(Funcionario funcionario)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_insert_funcionario",conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@p_cargo", funcionario.cargo);
            cmd.Parameters.AddWithValue("@p_fone", funcionario.fone);
            cmd.Parameters.AddWithValue("@p_email", funcionario.eMail);
            cmd.Parameters.AddWithValue("@p_senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@p_funcao", funcionario.funcao);
            cmd.Parameters.AddWithValue("@p_idRest", Session.Instance.RestID);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void DeleteFuncionario(Funcionario funcionario, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_delete_funcionario", conn.RetornarConexao());
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void EditFuncionario(Funcionario funcionario, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_update_funcionario", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@p_cargo", funcionario.cargo);
            cmd.Parameters.AddWithValue("@p_fone", funcionario.fone);
            cmd.Parameters.AddWithValue("@p_email", funcionario.eMail);
            cmd.Parameters.AddWithValue("@p_senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@p_funcao", funcionario.funcao);
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }
    }
}
