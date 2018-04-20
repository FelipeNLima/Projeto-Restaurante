using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
    public class ClasseCaixa
    {
        public int id_caixa { get; set; }
        public DateTime data_fechamento { get; set; }
        public float valor_inicial { get; set; }
        public float valor_final { get; set; }
        public DateTime data_abertura { get; set; }
        public float diferença { get; set; }
        public StatusCaixa StatusCaixa { get; set; } = StatusCaixa.Fechado;

        public bool AbrirCaixa()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO CAIXA (valor_inicial,  data_abertura, StatusCaixa)  VALUES (@VALORINICIAL, @DATAABERTURA, @STATUSCAIXA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@VALORINICIAL", valor_inicial);
                obj.cmd.Parameters.AddWithValue("@DATAABERTURA", data_abertura);
                obj.cmd.Parameters.AddWithValue("@STATUSCAIXA", StatusCaixa);

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

                string sql = "UPDATE CAIXA SET data_fechamento=@DATAFECHAMENTO, valor_final=@VALORFINAL, diferença=@DIFERENCA, StatusCaixa=@STATUSCAIXA  WHERE id_caixa=@IDCAIXA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@DATAFECHAMENTO", data_fechamento);
                obj.cmd.Parameters.AddWithValue("@VALORFINAL", valor_final);
                obj.cmd.Parameters.AddWithValue("@DIFERENCA", diferença);
                obj.cmd.Parameters.AddWithValue("@IDCAIXA", id_caixa);
                obj.cmd.Parameters.AddWithValue("@STATUSCAIXA", StatusCaixa);


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
        
        public void CarregarCaixa()
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT top 1 id_caixa,valor_inicial,data_abertura, StatusCaixa FROM CAIXA ORDER BY id_caixa DESC", obj.objCon);

               

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_caixa = int.Parse(Leitor["id_caixa"].ToString()); 
                    valor_inicial = float.Parse(Leitor["valor_inicial"].ToString());
                    StatusCaixa = (StatusCaixa)Enum.Parse(typeof(StatusCaixa), Leitor["StatusCaixa"].ToString());
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
