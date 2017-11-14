using Projeto_Restaurante.Conexão;
using System;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    
    class ClassePagamento
    {
        public int id_pagamento { get; set; }
        public float Valor { get; set; }
        public DateTime data { get; set; }
        public bool apagado { get; set; } = false;          
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

                string sql = "INSERT INTO PAGAMENTO (id_pagamento, Valor, data, troco, apagado, id_venda, id_formaPagamento, id_bandeiras, id_caixa)  VALUES (@IDPAGAMENTO, @VALOR, @DATA, @TROCO, @APAGADO, @IDVENDA, @IDFORMAPAGAMENTO, @IDBANDEIRA, @IDCAIXA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


                obj.cmd.Parameters.AddWithValue("@IDPAGAMENTO", id_pagamento);
                obj.cmd.Parameters.AddWithValue("@VALOR", Valor);
                obj.cmd.Parameters.AddWithValue("@DATA", data);
                obj.cmd.Parameters.AddWithValue("@TROCO", troco);
                obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
                obj.cmd.Parameters.AddWithValue("@IDVENDA", venda.id_venda);
                obj.cmd.Parameters.AddWithValue("@IDFORMAPAGAMENTO", formaPagamento.id_formaPagamento);
                obj.cmd.Parameters.AddWithValue("@IDBANDEIRA", bandeiras.id_bandeira);
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

        //public bool AtualizarPagamento()
        //{

        //}

    }
}
