using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
	using Conexão;
	using System.Data.SqlClient;

	class ClasseCardapio
	{
		public int id_cardapio { get; set; }
		public float preco_item { get; set; }
		public string nome_item { get; set; }
		public ClasseCategoria_Cardapio categoria { get; set; }
		public bool apagado { get; set; } = false;

		public bool CadastrarCardapio()
		{
			Conexao obj = new Conexao();

			bool correto = false;

			try
			{
				obj.conectar();

				string sql = "INSERT INTO CARDAPIO ( nome_item, preco_item, apagado, id_categoriacardapio)  VALUES ( @NOMEITEM, @PRECOITEM, @APAGADO, @ID_CATEGORIACARDAPIO)";

				obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


				obj.cmd.Parameters.AddWithValue("@NOMEITEM", nome_item);
				obj.cmd.Parameters.AddWithValue("@PRECOITEM", preco_item);
				obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
				obj.cmd.Parameters.AddWithValue("@ID_CATEGORIACARDAPIO", categoria.id_categoriacardapio);
				

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

		public bool AtualizarCardapio()
		{
			Conexao obj = new Conexao();

			bool correto = false;

			try
			{
				obj.conectar();

				string sql = "UPDATE CARDAPIO SET nome_item=@NOMEITEM, preco_item=@PRECOITEM, apagado=@APAGADO, id_categoriacardapio=@ID_CATEGORIACARDAPIO  WHERE id_cardapio=@ID_CARDAPIO";

				obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

				obj.cmd.Parameters.AddWithValue("@NOMEITEM", nome_item);
				obj.cmd.Parameters.AddWithValue("@PRECOITEM", preco_item);
				obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
				obj.cmd.Parameters.AddWithValue("@ID_CATEGORIACARDAPIO", categoria.id_categoriacardapio);
				obj.cmd.Parameters.AddWithValue("@ID_CARDAPIO", id_cardapio);


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

		public void DeletarCardapio()
		{
			this.apagado = true;
			AtualizarCardapio();
		}

		public void CarregarPorId(int ID)
		{
			Conexao obj = new Conexao();
			try
			{
				obj.conectar();
				int Codigo = ID;
				SqlDataReader Leitor = null;
				SqlCommand cmd = new SqlCommand("SELECT  nome_item, preco_item, id_categoriacardapio  FROM CARDAPIO WHERE id_cardapio = @CODIGO", obj.objCon);
                cmd.Parameters.AddWithValue("@CODIGO", ID);

                Leitor = cmd.ExecuteReader();

				if (Leitor.Read())
				{
					this.id_cardapio = ID;
					nome_item = (Leitor["nome_item"].ToString());
					preco_item = float.Parse(Leitor["preco_item"].ToString());
					categoria = new ClasseCategoria_Cardapio();
					categoria.CarregarCardapioID(int.Parse(Leitor["id_categoriacardapio"].ToString()));
				}
			}
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.ToString());
			}
			finally
			{
				obj.desconectar();
			}

		}

        public static List<ClasseCardapio> CarregarTodoCardapio()
        {
            List<ClasseCardapio> listadecardapio = new List<ClasseCardapio>();

            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
             
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT id_cardapio, nome_item, preco_item, id_categoriacardapio  FROM CARDAPIO ", obj.objCon);
                Leitor = cmd.ExecuteReader();

                while (Leitor.Read())
                {
                    ClasseCardapio cardapioitem = new ClasseCardapio();

                    cardapioitem.id_cardapio = int.Parse((Leitor["id_cardapio"].ToString()));
                    cardapioitem.nome_item = (Leitor["nome_item"].ToString());
                    cardapioitem.preco_item = float.Parse(Leitor["preco_item"].ToString());
                    cardapioitem.categoria = new ClasseCategoria_Cardapio();
                    cardapioitem.categoria.CarregarCardapioID(int.Parse(Leitor["id_categoriacardapio"].ToString()));

                    listadecardapio.Add(cardapioitem);
                }
                
            }
            
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                obj.desconectar();
            }
            return listadecardapio;
        }
        
	}
}
