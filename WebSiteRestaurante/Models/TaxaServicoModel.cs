using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebSiteRestaurante.Models
{
    public class TaxaServicoModel
    {
        public int id_taxaservico { get; set; }
        public float valor { get; set; }
        public DateTime data { get; set; }
        public UsuarioModel usuario { get; set; }
        public ClasseVenda venda { get; set; }


        public static List<TaxaServicoModel> RelatorioPorData(DateTime datainicial, DateTime datafinal)
        {

            {
                Conexao obj = new Conexao();
                List<TaxaServicoModel> lista = new List<TaxaServicoModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT	USUARIO.nome,
		                                                        SUM(valor) AS 'Total'
                                                        FROM  dbo.TAXA_SERVICO
                                                        INNER JOIN USUARIO ON USUARIO.id_usuario = TAXA_SERVICO.id_usuario
                                                        WHERE data BETWEEN @DATA_INICIO AND @DATA_FIM
                                                        GROUP BY USUARIO.nome", obj.objCon);
                    cmd.Parameters.AddWithValue("@DATA_INICIO", datainicial);
                    cmd.Parameters.AddWithValue("@DATA_FIM", datafinal);

                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        TaxaServicoModel taxa = new TaxaServicoModel();
                        taxa.usuario = new UsuarioModel();
                        taxa.usuario.nome = Leitor["nome"].ToString();
                        taxa.valor = float.Parse(Leitor["Total"].ToString());
                        lista.Add(taxa);
                    }

                }
                catch (Exception)
                {

                }
                finally { obj.desconectar(); }
                return lista;
            }
        }

        public static List<TaxaServicoModel> RelatorioPorDataUsuario(DateTime datainicial, DateTime datafinal, int id_usuario, bool todos)
        {

            {
                Conexao obj = new Conexao();
                List<TaxaServicoModel> lista = new List<TaxaServicoModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand(@"SELECT	USUARIO.nome,
		                                                        data,
		                                                        valor
                                                        FROM  dbo.TAXA_SERVICO
                                                        INNER JOIN USUARIO ON USUARIO.id_usuario = TAXA_SERVICO.id_usuario
                                                        WHERE DATA BETWEEN @DATA_INICIO AND @DATA_FIM
                                                        AND (1 = @TODOS OR USUARIO.ID_USUARIO = @ID_USUARIO)", obj.objCon);
                    cmd.Parameters.AddWithValue("@DATA_INICIO", datainicial);
                    cmd.Parameters.AddWithValue("@DATA_FIM", datafinal);
                    cmd.Parameters.AddWithValue("@TODOS", todos == true ? 1:0);
                    cmd.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        TaxaServicoModel taxa = new TaxaServicoModel();
                        taxa.usuario = new UsuarioModel();
                        taxa.usuario.nome = Leitor["nome"].ToString();
                        taxa.data = DateTime.Parse(Leitor["data"].ToString());
                        taxa.valor = float.Parse(Leitor["valor"].ToString());
                        lista.Add(taxa);
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