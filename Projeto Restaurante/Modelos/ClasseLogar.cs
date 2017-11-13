using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Verificações;

namespace Projeto_Restaurante.Modelos
{
    class ClasseLogar
    {
        public int codigo { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        public bool logar()
        {
            Conexao obj = new Conexao();
            
            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "SELECT id_login FROM LOGIN WHERE Usuario = @USUARIO AND Senha = @SENHA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql,obj.objCon);

                obj.cmd.Parameters.AddWithValue("@USUARIO",usuario);
                obj.cmd.Parameters.AddWithValue("@SENHA",criptografia.GerarHashMd5(senha));


                obj.leitor = obj.cmd.ExecuteReader();

                correto = obj.leitor.Read();
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
