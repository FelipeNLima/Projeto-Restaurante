using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class TaxaCouvertArtisticoModel
    {
        public int id_couvert { get; set; }
        public DateTime data { get; set; }
        public float valor { get; set; }
        public ClasseVenda venda { get; set; }

        public static List<TaxaCouvertArtisticoModel> RelatorioPorDataCouvert(DateTime datainicial, DateTime datafinal)
        {

            {
                Conexao obj = new Conexao();
                List<TaxaCouvertArtisticoModel> lista = new List<TaxaCouvertArtisticoModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT	data,
                                                                SUM(valor) AS 'Total'
                                                    FROM COUVERT_ARTISTICO
                                                    WHERE DATA BETWEEN @DATA_INICIO AND @DATA_FIM
                                                    GROUP BY data", obj.objCon);
                    cmd.Parameters.AddWithValue("@DATA_INICIO", datainicial);
                    cmd.Parameters.AddWithValue("@DATA_FIM", datafinal);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        TaxaCouvertArtisticoModel couvert = new TaxaCouvertArtisticoModel();
                       
                        couvert.data = DateTime.Parse(Leitor["data"].ToString());
                        couvert.valor = float.Parse(Leitor["Total"].ToString());
                        lista.Add(couvert);
                    }

                }
                catch (Exception)
                {

                }
                finally { obj.desconectar(); }
                return lista;
            }
        }
    }
}