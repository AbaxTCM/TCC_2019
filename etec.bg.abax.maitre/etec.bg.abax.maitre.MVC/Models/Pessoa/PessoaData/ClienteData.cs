﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static etec.bg.abax.maitre.MVC.Program;

namespace etec.bg.abax.maitre.MVC.Models.Pessoa.PessoaData
{
    public class ClienteData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Cliente> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from cliente where funcao = 'cli'", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Cliente> lista = new List<Cliente>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Cliente cliente = new Cliente();
                cliente.idCliente = int.Parse(dr["id"].ToString());
                cliente.nome = dr["nome"].ToString();
                cliente.fone = dr["fone"].ToString();
                cliente.eMail = dr["email"].ToString();
                cliente.cpf = dr["cpf"].ToString();

                lista.Add(cliente);
            }
            return lista;
        }

        public Cliente GetCliente(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("sp_select_cliente", conn.RetornarConexao());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Cliente cliente = new Cliente();
            if (ds.Tables[0].Rows.Count > 0)
            {
                cliente.idCliente = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                cliente.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                cliente.fone = ds.Tables[0].Rows[0]["fone"].ToString();
                cliente.eMail = ds.Tables[0].Rows[0]["email"].ToString();
                cliente.cpf = ds.Tables[0].Rows[0]["cpf"].ToString();
                cliente.senha = ds.Tables[0].Rows[0]["senha"].ToString();
            }
            return cliente;
        }

        public Cliente GetCliente(string email, string senha)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from cliente where email = @email and senha = @senha", conn.RetornarConexao());
            //da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@email", email);
            da.SelectCommand.Parameters.AddWithValue("@senha", senha);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Cliente cliente = new Cliente();
            if (ds.Tables[0].Rows.Count > 0)
            {
                cliente.idCliente = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                cliente.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                cliente.fone = ds.Tables[0].Rows[0]["fone"].ToString();
                cliente.eMail = ds.Tables[0].Rows[0]["email"].ToString();
                cliente.cpf = ds.Tables[0].Rows[0]["cpf"].ToString();
                cliente.senha = ds.Tables[0].Rows[0]["senha"].ToString();
                cliente.funcao = ds.Tables[0].Rows[0]["funcao"].ToString();

                Session.Instance.UserID = cliente.idCliente;
                Session.Instance.Funcao = cliente.funcao;
                Session.Instance.Nome = cliente.nome.Split(" ").FirstOrDefault();
            }
            return cliente;
        }

        public void PostCliente(Cliente cliente)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_insert_cliente", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", cliente.nome);
            cmd.Parameters.AddWithValue("@p_fone", cliente.fone);
            cmd.Parameters.AddWithValue("@p_cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@p_email", cliente.eMail);
            cmd.Parameters.AddWithValue("@p_senha", cliente.senha);
            cmd.Parameters.AddWithValue("@p_funcao", cliente.funcao);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void DeleteCliente(Cliente cliente, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_delete_cliente", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }

        public void EditCliente(Cliente cliente, int id)
        {
            conn.Conectar();
            MySqlCommand cmd = new MySqlCommand("sp_update_cliente", conn.RetornarConexao());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_nome", cliente.nome);
            cmd.Parameters.AddWithValue("@p_fone", cliente.fone);
            cmd.Parameters.AddWithValue("@p_email", cliente.eMail);
            cmd.Parameters.AddWithValue("@p_cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.Parameters.AddWithValue("@p_senha", cliente.senha);
            cmd.ExecuteNonQuery();
            conn.Desconectar();
        }
    }
}
