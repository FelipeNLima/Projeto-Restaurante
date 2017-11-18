using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    class ClasseRestaurante
    {
        public int id_restaurante { get; set; }
        public string Nome_restaurante { get; set; }
        public string IE { get; set; }
        public string CNPJ { get; set; }
        public string Nome_fantasia { get; set; }
        public string email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public int numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int cep { get; set; }



        public bool CadastrarRestaurante()
        {
            Conexao obj = new Conexao();
            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO RESTAURANTE (Nome_restaurante,IE,CNPJ,Nome_fantasia,email,Telefone,Endereco,numero,Cidade,Estado,cep)   VALUES (@NOME, @IE, @CNPJ, @NOMEFANTASIA, @EMAIL, @TELEFONE, @ENDERECO, @NUMERO, @CIDADE, @ESTADO, @CEP)";
                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


                obj.cmd.Parameters.AddWithValue("@NOME", Nome_restaurante);
                obj.cmd.Parameters.AddWithValue("@IE", IE);
                obj.cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                obj.cmd.Parameters.AddWithValue("@NOMEFANTASIA", Nome_fantasia);
                obj.cmd.Parameters.AddWithValue("@EMAIL", email);
                obj.cmd.Parameters.AddWithValue("@TELEFONE", Telefone);
                obj.cmd.Parameters.AddWithValue("@ENDERECO", Endereco);
                obj.cmd.Parameters.AddWithValue("@NUMERO", numero);
                obj.cmd.Parameters.AddWithValue("@CIDADE", Cidade);
                obj.cmd.Parameters.AddWithValue("@ESTADO", Estado);
                obj.cmd.Parameters.AddWithValue("@CEP", cep);

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

        public bool AtualizarRestaurante()
        {
            Conexao obj = new Conexao();
            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE RESTAURANTE SET Nome_restaurante = @NOME,IE  = @IE,CNPJ  = @CNPJ,Nome_fantasia  = @NOMEFANTASIA,email  = @EMAIL,Telefone  = @TELEFONE,Endereco  = @ENDERECO,numero  = @NUMERO,Cidade  = @CIDADE,Estado  = @ESTADO,cep  = @CEP  WHERE id_restaurante = @IDRESTAURANTE";
                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


                obj.cmd.Parameters.AddWithValue("@NOME", Nome_restaurante);
                obj.cmd.Parameters.AddWithValue("@IE", IE);
                obj.cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                obj.cmd.Parameters.AddWithValue("@NOMEFANTASIA", Nome_fantasia);
                obj.cmd.Parameters.AddWithValue("@EMAIL", email);
                obj.cmd.Parameters.AddWithValue("@TELEFONE", Telefone);
                obj.cmd.Parameters.AddWithValue("@ENDERECO", Endereco);
                obj.cmd.Parameters.AddWithValue("@NUMERO", numero);
                obj.cmd.Parameters.AddWithValue("@CIDADE", Cidade);
                obj.cmd.Parameters.AddWithValue("@ESTADO", Estado);
                obj.cmd.Parameters.AddWithValue("@CEP", cep);
                obj.cmd.Parameters.AddWithValue("@IDRESTAURANTE", id_restaurante);

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

        public bool DeletarRestaurante(int id)
        {

            Conexao obj = new Conexao();
            bool correto = false;

            string sql = "DELETE FROM RESTAURANTE WHERE id_restaurante = '" + id + "'";

            obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);
            try
            {
                obj.cmd.Parameters.AddWithValue("@IDRESTAURANTE", id_restaurante);

            }
            catch (SqlException ex)
            {
				System.Windows.Forms.MessageBox.Show(ex.ToString());
				throw;
            }
            finally
            {
                obj.desconectar();
            }

            return correto;
        }

        public void CarregarPorID(int id)
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT Nome_restaurante,IE,CNPJ,Nome_fantasia,email,Telefone,Endereco,numero,Cidade,Estado,cep  FROM RESTAURANTE WHERE id_restaurante = @ID", obj.objCon);
                cmd.Parameters.AddWithValue("@ID", id);
                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    this.id_restaurante = id;
                    Nome_restaurante = (Leitor["Nome_restaurante"].ToString());
                    IE = (Leitor["IE"].ToString());
                    CNPJ = (Leitor["CNPJ"].ToString());
                    Nome_fantasia = (Leitor["Nome_fantasia"].ToString());
                    email = (Leitor["email"].ToString());
                    Telefone = int.Parse(Leitor["Telefone"].ToString());
                    Endereco = (Leitor["Endereco"].ToString());
                    numero = int.Parse(Leitor["numero"].ToString());
                    Cidade = (Leitor["Cidade"].ToString());
                    Estado = (Leitor["Estado"].ToString());
                    cep = int.Parse(Leitor["cep"].ToString());

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
