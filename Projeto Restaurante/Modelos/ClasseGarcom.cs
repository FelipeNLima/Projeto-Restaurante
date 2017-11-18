using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Restaurante.Modelos
{
    public class ClasseGarcom
    {
        public int id_garcom { get; set; }
        public float taxa_serviço { get; set; }
        public string nome_garcom { get; set; }
        public int codigo { get; set; }
        public bool apagado { get; set; } = false;

        public bool Cadastrargarcom()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO GARCOM (nome_garcom, codigo, taxa_servico, apagado)  VALUES (@NOME, @CODIGO, @TAXASERVICO, @APAGADO)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@NOME", nome_garcom);
                obj.cmd.Parameters.AddWithValue("@CODIGO", codigo);
                obj.cmd.Parameters.AddWithValue("@TAXASERVICO", taxa_serviço);
                obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);

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

        public bool Atualizargarcom()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE GARCOM SET nome_garcom=@NOME_GARCOM, codigo=@CODIGO, apagado=@APAGADO  WHERE id_garcom = @ID_GARCOM";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@NOME_GARCOM", nome_garcom);
                obj.cmd.Parameters.AddWithValue("@CODIGO", codigo);
                obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
                obj.cmd.Parameters.AddWithValue("@ID_GARCOM", id_garcom);


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

        public void Deletargarcom()
        {
            this.apagado = true;
            Atualizargarcom();
        }

        public void CarregarPorId(int ID)
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
                int Codigo = ID;
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT nome_garcom, codigo FROM GARCOM WHERE id_garcom = @CODIGO", obj.objCon);
                cmd.Parameters.AddWithValue("@CODIGO", ID);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    this.id_garcom = ID;
                    nome_garcom = (Leitor["nome_garcom"].ToString());
                    codigo = int.Parse(Leitor["codigo"].ToString());
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        public bool TemGarcom(int codigo, int id_garcom)
        {
            bool existe = false;
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();

                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT  COUNT (*) FROM GARCOM WHERE id_garcom != @ID AND Codigo= @CODIGO AND apagado = 0", obj.objCon);
                cmd.Parameters.AddWithValue("@ID", id_garcom);
                cmd.Parameters.AddWithValue("@CODIGO", codigo);
                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    existe = int.Parse(Leitor[0].ToString()) > 0;

                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
            return existe;

        }

        public void CarregarGarcom(int codgarcom)
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT id_garcom, codigo, nome_garcom FROM GARCOM WHERE codigo = @CODIGO", obj.objCon);
                cmd.Parameters.AddWithValue("@CODIGO", codgarcom);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_garcom = int.Parse((Leitor["id_garcom"]).ToString()); ;
                    codigo = int.Parse((Leitor["codigo"]).ToString());
                    nome_garcom = (Leitor["nome_garcom"]).ToString();
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
