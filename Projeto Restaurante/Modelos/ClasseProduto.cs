using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Projeto_Restaurante.Modelos
{
    class ClasseProduto
    {
        public int id_produto { get; set; }
        public float preco_custo { get; set; }
        public string nome_produto { get; set; }
        public int estoque_atual { get; set; }
        public int estoque_minimo { get; set; }      
        public ClasseCategoria_Produto categoria { get; set; }
        public bool apagado { get; set; } = false;
        
        public bool Cadastrarproduto()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO PRODUTO ( nome_produto,preco_custo, estoque_atual, estoque_minimo, id_categoriaproduto, apagado)  VALUES ( @NOMEPRODUTO,@PRECOCUSTO,@ESTOQUEATUAL, @ESTOQUEMIN, @ID_CATEGORIAPRODUTO, @APAGADO)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                
                obj.cmd.Parameters.AddWithValue("@NOMEPRODUTO", nome_produto);
                obj.cmd.Parameters.AddWithValue("@PRECOCUSTO", preco_custo);
                obj.cmd.Parameters.AddWithValue("@ESTOQUEATUAL", estoque_atual);
                obj.cmd.Parameters.AddWithValue("@ESTOQUEMIN", estoque_minimo);
                obj.cmd.Parameters.AddWithValue("@ID_CATEGORIAPRODUTO", categoria.id_categoriaproduto);
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

        public bool Atualizarproduto()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE PRODUTO SET nome_produto=@NOMEPRODUTO, preco_custo=@PRECOCUSTO, estoque_atual=@ESTOQUEATUAL, estoque_minimo=@ESTOQUEMIN, id_categoriaproduto=@ID_CATEGORIAPRODUTO, apagado=@APAGADO  WHERE id_produto=@ID_PRODUTO";
                
                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@NOMEPRODUTO", nome_produto);
                obj.cmd.Parameters.AddWithValue("@PRECOCUSTO", preco_custo);
                obj.cmd.Parameters.AddWithValue("@ESTOQUEATUAL", estoque_atual);
                obj.cmd.Parameters.AddWithValue("@ESTOQUEMIN", estoque_minimo);
                obj.cmd.Parameters.AddWithValue("@ID_CATEGORIAPRODUTO", categoria.id_categoriaproduto);
                obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
                obj.cmd.Parameters.AddWithValue("@ID_PRODUTO", id_produto);


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

        public void Deletarproduto()
        {
            this.apagado = true;
            Atualizarproduto();
        }

        public void CarregarPorId(int ID)
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
                int Codigo = ID;
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT  nome_produto, preco_custo, estoque_atual, estoque_minimo, id_categoriaproduto  FROM PRODUTO WHERE id_produto = @ID", obj.objCon);
                cmd.Parameters.AddWithValue("@ID", ID);
                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    this.id_produto = ID;
                    nome_produto = (Leitor["nome_produto"].ToString());
                    preco_custo = float.Parse(Leitor["preco_custo"].ToString());
                    categoria = new ClasseCategoria_Produto();
                    categoria.CarregarProdutoID(int.Parse(Leitor["id_categoriaproduto"].ToString()));
                    estoque_atual = int.Parse(Leitor["estoque_atual"].ToString());
                    estoque_minimo = int.Parse(Leitor["estoque_minimo"].ToString());
                    estoque_minimo = int.Parse(Leitor["estoque_minimo"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { obj.desconectar(); }
        }

        public static List<ClasseProduto> CarregarProduto()
        {

            {
                Conexao obj = new Conexao();
                List<ClasseProduto> lista = new List<ClasseProduto>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand("SELECT id_produto, nome_produto, preco_custo, estoque_atual, estoque_minimo, id_categoriaproduto  FROM PRODUTO", obj.objCon);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        ClasseProduto produto = new ClasseProduto();
                        produto.id_produto = int.Parse(Leitor["id_produto"].ToString());
                        produto.nome_produto = (Leitor["nome_produto"].ToString());
                        produto.preco_custo = float.Parse(Leitor["preco_custo"].ToString());
                        produto.categoria = new ClasseCategoria_Produto();
                        produto.categoria.CarregarProdutoID(int.Parse(Leitor["id_categoriaproduto"].ToString()));
                        produto.estoque_atual = int.Parse(Leitor["estoque_atual"].ToString());
                        produto.estoque_minimo = int.Parse(Leitor["estoque_minimo"].ToString());
                       
                        lista.Add(produto);
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
