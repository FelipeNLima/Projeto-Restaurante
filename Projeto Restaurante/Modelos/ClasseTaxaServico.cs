using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
    public class ClasseTaxaServico
    {
        public int id_taxaservico { get; set; }
        public float valor { get; set; }
        public DateTime data { get; set; }
        public ClasseUsuario usuario { get; set; }
        public ClasseVenda venda { get; set; }

        public bool InserirTaxaServico()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO TAXA_SERVICO (valor, data, id_usuario, id_venda)  VALUES (@VALOR, @DATA, @IDUSUARIO, @IDVENDA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@VALOR", valor);
                obj.cmd.Parameters.AddWithValue("@DATA", data);
                obj.cmd.Parameters.AddWithValue("@IDUSUARIO", usuario.id_usuario);
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
