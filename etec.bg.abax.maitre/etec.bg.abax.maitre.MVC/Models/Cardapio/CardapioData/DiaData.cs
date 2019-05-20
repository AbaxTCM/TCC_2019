using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class DiaData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Dia> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from dia", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Dia> lista = new List<Dia>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Dia dia = new Dia();
                dia.idDia = int.Parse(dr["id_dia"].ToString());
                dia.nome = dr["nome"].ToString();

                lista.Add(dia);
            }
            return lista;
        }
    }
}
