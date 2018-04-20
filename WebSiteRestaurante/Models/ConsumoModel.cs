using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class ConsumoModel
    {
        public int id_consumo { get; set; }
        public int quantidade { get; set; }
        public float Valor_total { get; set; }
        public bool apagado { get; set; } = false;
        public CardapioModel Cardapio { get; set; }
        public ClasseVenda Venda { get; set; }


        public static List<ConsumoModel> RelatorioEstoqueSaida(DateTime datainicial, DateTime datafinal)
        {

            {
                Conexao obj = new Conexao();
                List<ConsumoModel> lista = new List<ConsumoModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT	CARDAPIO.nome_item AS 'Produto',
		                                                        SUM(quantidade) AS 'Quantidade'
                                                    from CONSUMO
                                                    INNER JOIN CARDAPIO ON CARDAPIO.id_cardapio = CONSUMO.id_cardapio
                                                    WHERE Data_entrada BETWEEN @DATA_INICIO AND @DATA_FIM
                                                    GROUP BY CARDAPIO.nome_item, quantidade", obj.objCon);
                    cmd.Parameters.AddWithValue("@DATA_INICIO", datainicial);
                    cmd.Parameters.AddWithValue("@DATA_FIM", datafinal);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        ConsumoModel estoque = new ConsumoModel();
                        estoque.Cardapio = new CardapioModel();

                        estoque.Cardapio.nome_item = Leitor["Produto"].ToString();
                        estoque.quantidade = int.Parse(Leitor["Quantidade"].ToString());

                        lista.Add(estoque);
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