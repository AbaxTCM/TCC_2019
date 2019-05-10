using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa.PessoaData
{
    public class ClienteData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Cliente> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from cliente", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Cliente> lista = new List<Cliente>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = int.Parse(dr["id_cliente"].ToString());
                cliente.nome = dr["nome_cliente"].ToString();
                cliente.fone = dr["fone_cliente"].ToString();
                cliente.eMail = dr["email_cliente"].ToString();
                cliente.cpf = dr["cpf"].ToString();

                lista.Add(cliente);
            }
            return lista;
        }

        public Cliente GetCliente(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from cliente where id_cliente = @id", conn.RetornarConexao());
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Cliente cliente = new Cliente();
            if (ds.Tables[0].Rows.Count > 0)
            {
                cliente.idCliente = int.Parse(ds.Tables[0].Rows[0]["id_cliente"].ToString());
                cliente.nome = ds.Tables[0].Rows[0]["nome_cliente"].ToString();
                cliente.fone = ds.Tables[0].Rows[0]["fone_cliente"].ToString();
                cliente.eMail = ds.Tables[0].Rows[0]["email_cliente"].ToString();
                cliente.cpf = ds.Tables[0].Rows[0]["cpf"].ToString();
            }
            return cliente;
        }

        public void PostCliente(Cliente cliente)
        {

        }

        public void DeleteCliente(Cliente cliente, int id)
        {

        }

        public void EditCliente(Cliente cliente, int id)
        {

        }
    }
}
