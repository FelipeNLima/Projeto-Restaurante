using Projeto_Restaurante.Conexão;
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Projeto_Restaurante.Modelos
{

    class ClassePagamento
    {
        public int id_pagamento { get; set; }
        public float Valor_total { get; set; }
        public float Valor_recebido { get; set; }
        public DateTime data { get; set; }
        public float troco { get; set; }
        public ClasseVenda venda { get; set; }
        public ClasseFormaPagamento formaPagamento { get; set; }
        public ClasseBandeira bandeiras { get; set; }
        public ClasseCaixa caixa { get; set; }


        public bool CadastrarPagamento()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO PAGAMENTO (Valor_total, Valor_recebido, data, troco, id_venda, id_formaPagamento, id_bandeira, id_caixa)  VALUES (@VALORTOTAL, @VALORRECEBIDO, @DATA, @TROCO, @IDVENDA, @IDFORMAPAGAMENTO, @IDBANDEIRA, @IDCAIXA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@VALORTOTAL", Valor_total);
                obj.cmd.Parameters.AddWithValue("@VALORRECEBIDO", Valor_recebido);
                obj.cmd.Parameters.AddWithValue("@DATA", data);
                obj.cmd.Parameters.AddWithValue("@TROCO", troco);
                obj.cmd.Parameters.AddWithValue("@IDVENDA", venda.id_venda);
                obj.cmd.Parameters.AddWithValue("@IDFORMAPAGAMENTO", formaPagamento.id_formaPagamento);
                obj.cmd.Parameters.AddWithValue("@IDBANDEIRA", bandeiras.id_bandeira == 0 ? SqlInt32.Null : bandeiras.id_bandeira);
                obj.cmd.Parameters.AddWithValue("@IDCAIXA", caixa.id_caixa);

                obj.cmd.ExecuteNonQuery();

                correto = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
            return correto;
        }

        public void CarregarPagamento()
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT top 1 id_pagamento,Valor_total,Valor_recebido,data,troco,id_venda,id_formaPagamento,id_bandeira,id_caixa  FROM PAGAMENTO ORDER BY id_pagamento DESC", obj.objCon);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_pagamento = int.Parse(Leitor["id_pagamento"].ToString());
                    Valor_total = float.Parse(Leitor["Valor_total"].ToString());
                    Valor_recebido = float.Parse(Leitor["Valor_recebido"].ToString());
                    data = DateTime.Parse(Leitor["data"].ToString());
                    troco = float.Parse(Leitor["troco"].ToString());
                    venda = new ClasseVenda();
                    venda.id_venda = int.Parse(Leitor["id_venda"].ToString());
                    formaPagamento = new ClasseFormaPagamento();
                    formaPagamento.id_formaPagamento = int.Parse(Leitor["id_formaPagamento"].ToString());
                    bandeiras = new ClasseBandeira();
                    if (Leitor["id_bandeira"] != DBNull.Value)
                    {
                        bandeiras.id_bandeira = int.Parse(Leitor["id_bandeira"].ToString());
                    }
                    caixa = new ClasseCaixa();
                    caixa.id_caixa = int.Parse(Leitor["id_caixa"].ToString());
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }


    }
}
