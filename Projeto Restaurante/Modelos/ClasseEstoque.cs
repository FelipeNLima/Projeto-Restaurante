using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Projeto_Restaurante.Modelos
{
    class ClasseEstoque
    {
        public int id_estoque { get; set; }
        public DateTime Data_entrada { get; set; }
        public int quantidade_entrada { get; set; }
        public ClasseProduto id_produto { get; set; }

        public bool CadastrarEstoque()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = " INSERT INTO ESTOQUE (Data_entrada, quantidade_entrada, id_produto) VALUES (@DATAENTRADA, @QUANTIDADEENTRADA, @IDPRODUTO)";

                obj.cmd = new SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@DATAENTRADA", Data_entrada);
                obj.cmd.Parameters.AddWithValue("@QUANTIDADEENTRADA", quantidade_entrada);
                obj.cmd.Parameters.AddWithValue("@IDPRODUTO", id_produto.id_produto);

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

        public static List<ClasseEstoque> CarregarEstoque()
        {

            {
                Conexao obj = new Conexao();
                List<ClasseEstoque> lista = new List<ClasseEstoque>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand("SELECT id_estoque, Data_entrada, quantidade_entrada, id_produto FROM ESTOQUE", obj.objCon);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        ClasseEstoque estoque = new ClasseEstoque();
                        estoque.id_estoque = int.Parse(Leitor["id_estoque"].ToString());
                        estoque.Data_entrada = DateTime.Parse(Leitor["Data_entrada"].ToString());
                        estoque.quantidade_entrada = int.Parse(Leitor["quantidade_entrada"].ToString());
                        estoque.id_produto.id_produto = int.Parse(Leitor["id_produto"].ToString());

                        lista.Add(estoque);
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
