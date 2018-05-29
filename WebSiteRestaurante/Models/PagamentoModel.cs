using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class PagamentoModel
    {
        public int id_pagamento { get; set; }
        public float Valor_total { get; set; }
        public float Valor_recebido { get; set; }
        public string data { get; set; }

        public static List<PagamentoModel> faturamentoPorMes()
        {

            {
                Conexao obj = new Conexao();
                List<PagamentoModel> lista = new List<PagamentoModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT  DATENAME(MONTH, data) as 'mes',
		                                                      SUM(Valor_total) as 'Valor'
                                                        FROM PAGAMENTO
                                                        group by DATENAME(MONTH, data), MONTH(data)
                                                        ORDER BY MONTH(data)", obj.objCon);
                    Leitor = cmd.ExecuteReader();
                    while (Leitor.Read())
                    {
                        PagamentoModel faturamento = new PagamentoModel();
                        faturamento.data = Leitor["mes"].ToString();
                        faturamento.Valor_total = float.Parse(Leitor["Valor"].ToString());

                        lista.Add(faturamento);
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