using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa.PessoaData
{
    public class FuncionarioData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Funcionario> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcionario",conn.RetornarConexao());
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
            cmd.Parameters.AddWithValue("@p_id", funcionario.idFunc);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }
    }
}
