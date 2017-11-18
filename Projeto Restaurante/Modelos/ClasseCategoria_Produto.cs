using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    using Conexão;
   public class ClasseCategoria_Produto
    {
        public int id_categoriaproduto { get; set; }
        public string descricao { get; set; }
        public bool apagado { get; set; }

		public bool CadastrarCategoriaProduto()
		{
			Conexao obj = new Conexao();

			bool correto = false;

			try
			{
				obj.conectar();

				string sql = " INSERT INTO CATEGORIAPRODUTO (descricao, apagado) VALUES (@DESCRICAO, @APAGADO)";

				obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

				obj.cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
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

		public bool AtualizarCategoriaProduto()
		{
			Conexao obj = new Conexao();

			bool correto = false;

			try
			{
				obj.conectar();

				string sql = "UPDATE CATEGORIAPRODUTO SET  descricao = @DESCRICAO, apagado = @APAGADO WHERE id_categoriaproduto = @IDCATEGORIAPRODUTO";

				obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


				obj.cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
				obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
				obj.cmd.Parameters.AddWithValue("@IDCATEGORIAPRODUTO", id_categoriaproduto);

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

		public void DeletarCategoriaProduto()
		{
			this.apagado = true;
			AtualizarCategoriaProduto();
		}

		public void CarregarProdutoID(int ID)
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
                int Codigo = ID;
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT descricao FROM CATEGORIAPRODUTO WHERE id_categoriaproduto = @CODIGO", obj.objCon);
                cmd.Parameters.AddWithValue("@CODIGO", ID);
                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    this.id_categoriaproduto = ID;
                    descricao = (Leitor["descricao"].ToString());
               
                }
            }
            catch (Exception ex)
            {
				System.Windows.Forms.MessageBox.Show(ex.ToString());
				throw;
            }
            finally { obj.desconectar(); }
        }

		public static List<ClasseCategoria_Produto> CarregarCategoriaProduto()
		{

			{
				Conexao obj = new Conexao();
				List<ClasseCategoria_Produto> lista = new List<ClasseCategoria_Produto>();

				try
				{
					obj.conectar();

					SqlDataReader Leitor = null;
					SqlCommand cmd = new SqlCommand("SELECT  id_categoriaproduto, descricao  FROM CATEGORIAPRODUTO WHERE apagado = 0", obj.objCon);
					Leitor = cmd.ExecuteReader();

					while (Leitor.Read())
					{
						ClasseCategoria_Produto c = new ClasseCategoria_Produto();
						c.id_categoriaproduto = int.Parse(Leitor["id_categoriaproduto"].ToString());
						c.descricao = (Leitor["descricao"].ToString());

						lista.Add(c);
					}

				}
				catch (Exception)
				{

					throw;
				}
				finally { obj.desconectar(); }
				return lista;
			}
		}
	}
}
