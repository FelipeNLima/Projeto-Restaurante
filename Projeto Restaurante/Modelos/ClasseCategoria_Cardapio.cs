using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
	using Conexão;
	class ClasseCategoria_Cardapio
	{
		public int id_categoriacardapio { get; set; }
		public string descricao { get; set; }
		public bool apagado { get; set; }

		public bool CadastrarCategoriaCardapio()
		{
			Conexao obj = new Conexao();

			bool correto = false;

			try
			{
				obj.conectar();

				string sql = " INSERT INTO CATEGORIACARDAPIO (descricao, apagado) VALUES (@DESCRICAO, @APAGADO)";

				obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

				obj.cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
				obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);

				obj.cmd.ExecuteNonQuery();

				correto = true;

			}
			catch (Exception)
			{

				throw;
			}
			finally { obj.desconectar(); }
			return correto;


		}

		public bool AtualizarCategoriaCardapio()
		{
			Conexao obj = new Conexao();

			bool correto = false;

			try
			{
				obj.conectar();

				string sql = "UPDATE CATEGORIACARDAPIO SET  descricao = @DESCRICAO, apagado = @APAGADO WHERE id_categoriacardapio = @IDCATEGORIACARDAPIO";

				obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


				obj.cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
				obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
				obj.cmd.Parameters.AddWithValue("@IDCATEGORIACARDAPIO", id_categoriacardapio);

				obj.cmd.ExecuteNonQuery();
				correto = true;
			}
			catch (Exception)
			{

				throw;
			}
			finally { obj.desconectar(); }
			return correto;
		}

		public void DeletarCategoriaCardapio()
		{
			this.apagado = true;
			AtualizarCategoriaCardapio();
		}

		public void CarregarCardapioID(int ID)
		{
			Conexao obj = new Conexao();
			try
			{
				obj.conectar();
				int Codigo = ID;
				SqlDataReader Leitor = null;
				SqlCommand cmd = new SqlCommand("SELECT descricao FROM CATEGORIACARDAPIO WHERE id_categoriacardapio = @CODIGO", obj.objCon);
                cmd.Parameters.AddWithValue("@CODIGO", ID);
                Leitor = cmd.ExecuteReader();

				if (Leitor.Read())
				{
					this.id_categoriacardapio = ID;
					descricao = (Leitor["descricao"].ToString());

				}
			}
			catch (Exception)
			{

				throw;
			}
			finally { obj.desconectar(); }
		}

		public static List<ClasseCategoria_Cardapio> CarregarCategoriaCardapio()
		{

			
				Conexao obj = new Conexao();
				List<ClasseCategoria_Cardapio> lista = new List<ClasseCategoria_Cardapio>();

				try
				{
					obj.conectar();

					SqlDataReader Leitor = null;
					SqlCommand cmd = new SqlCommand("SELECT  id_categoriacardapio, descricao  FROM CATEGORIACARDAPIO WHERE apagado = 0", obj.objCon);
					Leitor = cmd.ExecuteReader();

					while (Leitor.Read())
					{
						ClasseCategoria_Cardapio c = new ClasseCategoria_Cardapio();
						c.id_categoriacardapio = int.Parse(Leitor["id_categoriacardapio"].ToString());
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
