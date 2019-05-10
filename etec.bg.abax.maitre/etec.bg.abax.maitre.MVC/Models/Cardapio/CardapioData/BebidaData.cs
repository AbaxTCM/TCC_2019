using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class BebidaData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Bebida> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from bebidas", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Bebida> lista = new List<Bebida>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Bebida bebida = new Bebida();
                bebida.idBebida = int.Parse(dr["id_cliente"].ToString());
                bebida.nome = dr["nome"].ToString();
                bebida.tipo = dr["tipo"].ToString();
                //bebida.imagem = byte.Parse(dr["imagem"].ToString());
                bebida.valor = decimal.Parse(dr["valor"].ToString());

                lista.Add(bebida);
            }
            return lista;
        }

        public Bebida GetBebida(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from bebidas where id_bebida = @id", conn.RetornarConexao());
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Bebida cliente = new Bebida();
            if (ds.Tables[0].Rows.Count > 0)
            {
                cliente.idBebida = int.Parse(ds.Tables[0].Rows[0]["id_bebida"].ToString());
                cliente.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                cliente.tipo = ds.Tables[0].Rows[0]["tipo"].ToString();
                //cliente.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                cliente.valor = decimal.Parse(ds.Tables[0].Rows[0]["valor"].ToString());
            }
            return cliente;
        }

        public void PostBebida(Bebida bebida)
        {

        }

        public void DeleteBebida(Bebida bebida, int id)
        {

        }

        public void EditBebida(Bebida bebida, int id)
        {

        }
    }
}
