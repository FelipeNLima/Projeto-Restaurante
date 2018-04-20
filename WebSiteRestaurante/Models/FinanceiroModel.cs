using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class FinanceiroModel
    {
        public int id_pagamento { get; set; }
        public float Valor_total { get; set; }
        public float Valor_recebido { get; set; }
        public DateTime data { get; set; }
        public float troco { get; set; }
        public ClasseVenda Venda { get; set; }
        public FormaPagamentoModel FormaPagamento { get; set; }
        public ClasseBandeira Bandeiras { get; set; }
        public ClasseCaixa Caixa { get; set; }

        public static List<FinanceiroModel> RelatorioFinanceiro(DateTime datainicial, DateTime datafinal)
        {

            {
                Conexao obj = new Conexao();
                List<FinanceiroModel> lista = new List<FinanceiroModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT data,
                                                             FORMA_PAGAMENTO.tipo_pagamento AS 'Pagamento',
		                                                     SUM(Valor_recebido) AS 'Valor'         
                                                    FROM PAGAMENTO
                                                    INNER JOIN FORMA_PAGAMENTO ON FORMA_PAGAMENTO.id_formapagamento = PAGAMENTO.id_formapagamento
                                                    WHERE data BETWEEN @DATA_INICIO AND @DATA_FIM
                                                    GROUP BY data, FORMA_PAGAMENTO.tipo_pagamento, Valor_recebido", obj.objCon);
                    cmd.Parameters.AddWithValue("@DATA_INICIO", datainicial);
                    cmd.Parameters.AddWithValue("@DATA_FIM", datafinal);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        FinanceiroModel financeiro = new FinanceiroModel();
                        financeiro.FormaPagamento = new FormaPagamentoModel();
                        financeiro.data = DateTime.Parse(Leitor["data"].ToString());
                        financeiro.FormaPagamento.tipo_pagamento = Leitor["Pagamento"].ToString();
                        financeiro.Valor_recebido = float.Parse(Leitor["Valor"].ToString());

                        lista.Add(financeiro);
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