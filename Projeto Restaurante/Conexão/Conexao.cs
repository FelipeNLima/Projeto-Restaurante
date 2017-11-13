using System.Data;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Conexão
{
    public class Conexao
    {
        public string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=BD_RESTAURANTE;Integrated Security=True";

        public SqlConnection objCon = null;
        public SqlCommand cmd;
        public SqlDataReader leitor;

        ///ASDSA
        //    ASD
        //    ASD


        public Conexao()
        {
            objCon = new SqlConnection(stringConexao); 
        }

        #region "Métodos de conexão com o banco"
        public bool conectar()
        {
            objCon = new SqlConnection(stringConexao);

            try
            {
                if (objCon.State != ConnectionState.Closed)
                    objCon.Close();

                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }
        #endregion

       
    }
}
