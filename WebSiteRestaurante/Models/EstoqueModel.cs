using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebSiteRestaurante.Models
{
    public class EstoqueModel
    {
        public int id_estoque { get; set; }
        public DateTime Data_entrada { get; set; }
        public int quantidade_entrada { get; set; }
        public ProdutoModel id_produto { get; set; }

        public static List<EstoqueModel> RelatorioEstoqueEntrada(DateTime datainicial, DateTime datafinal)
        {

            {
                Conexao obj = new Conexao();
                List<EstoqueModel> lista = new List<EstoqueModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT	Data_entrada,
		                                                        PRODUTO.nome_produto AS 'Produto',
		                                                        quantidade_entrada
                                                    FROM ESTOQUE
                                                    INNER JOIN PRODUTO ON PRODUTO.id_produto = ESTOQUE.id_produto
                                                    WHERE Data_entrada BETWEEN @DATA_INICIO AND @DATA_FIM
                                                    GROUP BY Data_entrada, PRODUTO.nome_produto, quantidade_entrada", obj.objCon);
                    cmd.Parameters.AddWithValue("@DATA_INICIO", datainicial);
                    cmd.Parameters.AddWithValue("@DATA_FIM", datafinal);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        EstoqueModel estoque = new EstoqueModel();
                        estoque.id_produto = new ProdutoModel();

                        estoque.Data_entrada = DateTime.Parse(Leitor["Data_entrada"].ToString());
                        estoque.id_produto.nome_produto = Leitor["Produto"].ToString();
                        estoque.quantidade_entrada = int.Parse(Leitor["quantidade_entrada"].ToString());

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
