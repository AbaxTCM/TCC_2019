using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class PorcaoData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Porcao> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from porcoes", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Porcao> lista = new List<Porcao>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Porcao porcao = new Porcao();
                porcao.idPorcao = int.Parse(dr["id_porcao"].ToString());
                porcao.nome = dr["nome"].ToString();
                porcao.descricao = dr["descricao"].ToString();
                //bebida.imagem = byte.Parse(dr["imagem"].ToString());
                porcao.valor = decimal.Parse(dr["valor"].ToString());

                lista.Add(porcao);
            }
            return lista;
        }

        public Porcao GetPorcao(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from porcoes where id_porcao = @id", conn.RetornarConexao());
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Porcao porcao = new Porcao();
            if (ds.Tables[0].Rows.Count > 0)
            {
                porcao.idPorcao = int.Parse(ds.Tables[0].Rows[0]["id_porcao"].ToString());
                porcao.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                porcao.descricao = ds.Tables[0].Rows[0]["descricao"].ToString();
                //porcao.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                porcao.valor = decimal.Parse(ds.Tables[0].Rows[0]["valor"].ToString());
            }
            return porcao;
        }

        public void PostPorcao(Porcao porcao)
        {

        }

        public void DeletePorcao(Porcao porcao, int id)
        {

        }

        public void EditPorcao(Porcao porcao, int id)
        {

        }
    }
}
