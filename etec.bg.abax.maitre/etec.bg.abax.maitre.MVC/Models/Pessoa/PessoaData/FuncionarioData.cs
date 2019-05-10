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
                funcionario.idFunc = int.Parse(dr["id_func"].ToString());
                funcionario.nome = dr["nome_func"].ToString();
                funcionario.cargo = dr["cargo"].ToString();
                funcionario.fone = dr["fone_func"].ToString();
                funcionario.eMail = dr["email_func"].ToString();

                lista.Add(funcionario);
            }
            return lista;
        }

        public Funcionario GetFuncionario(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from funcionario where id_func = @id",conn.RetornarConexao());
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Funcionario funcionario = new Funcionario();
            if (ds.Tables[0].Rows.Count > 0)
            {
                funcionario.idFunc = int.Parse(ds.Tables[0].Rows[0]["id_func"].ToString());
                funcionario.nome = ds.Tables[0].Rows[0]["nome_func"].ToString();
                funcionario.cargo = ds.Tables[0].Rows[0]["cargo"].ToString();
                funcionario.fone = ds.Tables[0].Rows[0]["fone_func"].ToString();
                funcionario.eMail = ds.Tables[0].Rows[0]["email_func"].ToString();
            }
            return funcionario;
        }

        public void PostFuncionario(Funcionario funcionario)
        {
            
        }

        public void DeleteFuncionario(Funcionario funcionario, int id)
        {

        }

        public void EditFuncionario(Funcionario funcionario, int id)
        {

        }
    }
}
