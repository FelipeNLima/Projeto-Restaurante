using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
    public class ClasseCouvert_Artistico
    {
        public int id_couvert { get; set; }
        public DateTime data { get; set; }
        public float valor { get; set; }
        public ClasseVenda venda { get; set; }

        public bool InserirCouvert()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO COUVERT_ARTISTICO (data, valor, id_venda)  VALUES (@DATA, @VALOR, @IDVENDA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@DATA", data);
                obj.cmd.Parameters.AddWithValue("@VALOR", valor);
                obj.cmd.Parameters.AddWithValue("@IDVENDA", venda.id_venda);

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
