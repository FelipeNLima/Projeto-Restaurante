using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
    class ClasseCaixa
    {
        public int id_caixa { get; set; }
        public DateTime data_fechamento { get; set; }
        public float valor_inicial { get; set; }
        public float valor_final { get; set; }
        public DateTime data_abertura { get; set; }
        public float diferença { get; set; }

        public bool AbrirCaixa()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO PAGAMENTO (id_caixa, valor_inicial,  data_abertura)  VALUES (@IDCAIXA, @VALORINICIAL, @DATAABERTURA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


                obj.cmd.Parameters.AddWithValue("@IDCAIXA", id_caixa);
                obj.cmd.Parameters.AddWithValue("@VALORINICIAL", valor_inicial);
                obj.cmd.Parameters.AddWithValue("@DATAABERTURA", data_abertura);

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

        public bool FecharCaixa()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE CAIXA SET data_fechamento=@DATAFECHAMENTO, valor_final=@VALORFINAL, diferença=@DIFERENCA  WHERE id_caixa=@IDCAIXA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@DATAFECHAMENTO", data_fechamento);
                obj.cmd.Parameters.AddWithValue("@VALORFINAL", valor_final);
                obj.cmd.Parameters.AddWithValue("@DIFERENCA", diferença);
                obj.cmd.Parameters.AddWithValue("@IDCAIXA", id_caixa);


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
        

    }
}
