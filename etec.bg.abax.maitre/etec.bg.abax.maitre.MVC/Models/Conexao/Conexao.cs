﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Conexao
{
    public class Conexao
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; uid=root; pwd=1234567; database=tcc");

        public MySqlConnection Conectar()
        {
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                throw e;
            }
            return conn;
        }

        public MySqlConnection Desconectar()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            return conn;
        }

        public MySqlConnection RetornarConexao()
        {
            return conn;
        }
    }
}
