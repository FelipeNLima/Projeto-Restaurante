using Projeto_Restaurante.Conexão;
using System;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    class ClasseConfiguracaoCouvert
    {
        public int id_configuracao { get; set; }

        public float Valor { get; set; }

        public int ativo { get; set; }

        public bool FixarCouvert()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE CONFIGURACAO_COUVERT SET Valor=@VALOR, ativo=@ATIVO";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@VALOR", Valor);
                obj.cmd.Parameters.AddWithValue("@ATIVO", ativo);


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

        public void CarregarCouvert()
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT top 1 Valor, ativo FROM CONFIGURACAO_COUVERT", obj.objCon);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    Valor = float.Parse(Leitor["Valor"].ToString());
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
