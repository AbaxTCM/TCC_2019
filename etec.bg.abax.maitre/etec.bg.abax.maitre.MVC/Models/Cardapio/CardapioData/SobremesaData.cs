using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace etec.bg.abax.maitre.MVC.Models.Cardapio.CardapioData
{
    public class SobremesaData
    {
        Conexao.Conexao conn = new Conexao.Conexao();

        public List<Sobremesa> GetLista()
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from sobremesas", conn.RetornarConexao());
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Desconectar();

            List<Sobremesa> lista = new List<Sobremesa>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Sobremesa sobremesa = new Sobremesa();
                sobremesa.idSobremesa = int.Parse(dr["id_sobremesa"].ToString());
                sobremesa.nome = dr["nome"].ToString();
                //bebida.imagem = byte.Parse(dr["imagem"].ToString());
                sobremesa.valor = decimal.Parse(dr["valor"].ToString());

                lista.Add(sobremesa);
            }
            return lista;
        }

        public Sobremesa GetSobremesa(int id)
        {
            conn.Conectar();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from sobremesas where id_sobremesa = @id", conn.RetornarConexao());
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Desconectar();

            Sobremesa sobremesa = new Sobremesa();
            if (ds.Tables[0].Rows.Count > 0)
            {
                sobremesa.idSobremesa = int.Parse(ds.Tables[0].Rows[0]["id_sobremesa"].ToString());
                sobremesa.nome = ds.Tables[0].Rows[0]["nome"].ToString();
                //cliente.imagem = ds.Tables[0].Rows[0]["imagem"].ToString();
                sobremesa.valor = decimal.Parse(ds.Tables[0].Rows[0]["valor"].ToString());
            }
            return sobremesa;
        }

        public void PostSobremesa(Sobremesa sobremesa)
        {

        }

        public void DeleteSobremesa(Sobremesa sobremesa, int id)
        {

        }

        public void EditSobremesa(Sobremesa sobremesa, int id)
        {

        }
    }
}
