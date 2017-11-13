using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Projeto_Restaurante.Modelos
{
    class ClasseBandeira
    {
        public int id_bandeira { get; set; }
        public string nome_bandeira { get; set; }
        public float taxa { get; set; }
        public bool apagado { get; set; } = false;

        public bool CadastrarBandeira()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = " INSERT INTO BANDEIRA_CARTAO (nome_bandeiras, taxa, apagado) VALUES (@NOMEBANDEIRA, @TAXA, @APAGADO)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql ,obj.objCon);

                obj.cmd.Parameters.AddWithValue("@NOMEBANDEIRA", nome_bandeira);
                obj.cmd.Parameters.AddWithValue("@TAXA", taxa);
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

        public bool AtualizarBandeira()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE BANDEIRA_CARTAO SET  nome_bandeiras = @NOMEBANDEIRA, taxa = @TAXA, apagado = @APAGADO WHERE id_bandeiras = @IDBANDEIRA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                
                obj.cmd.Parameters.AddWithValue("@NOMEBANDEIRA", nome_bandeira);
                obj.cmd.Parameters.AddWithValue("@TAXA", taxa);
                obj.cmd.Parameters.AddWithValue("@APAGADO",apagado);
                obj.cmd.Parameters.AddWithValue("@IDBANDEIRA",id_bandeira);

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

        public void DeletarBandeira()
        {
            this.apagado = true;
            AtualizarBandeira();
        }

        public void CarregarPorID(int id)
        {
            Conexao obj = new Conexao();
            
            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT nome_bandeiras, taxa FROM BANDEIRA_CARTAO WHERE id_bandeiras = @ID", obj.objCon);

				cmd.Parameters.AddWithValue("@ID", id);

				Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
					this.id_bandeira = id;
					nome_bandeira = (Leitor["nome_bandeiras"].ToString());
                    taxa = float.Parse(Leitor["taxa"].ToString());
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }



        }

        public bool TemBandeira(string nome, int id_bandeira)
        {
            bool existe = false;
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();

                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT  COUNT (*) FROM BANDEIRA_CARTAO WHERE id_bandeiras != '" + id_bandeira + "' AND nome_bandeiras = '" + nome + "' AND apagado = 0", obj.objCon);
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


        public static List<ClasseBandeira> CarregarBandeira()
        {

            {
                Conexao obj = new Conexao();
                List<ClasseBandeira> lista = new List<ClasseBandeira>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand("SELECT id_bandeiras,nome_bandeiras,taxa,apagado FROM BANDEIRA_CARTAO WHERE apagado = 0", obj.objCon);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        ClasseBandeira bandeira = new ClasseBandeira();
                        bandeira.id_bandeira = int.Parse(Leitor["id_bandeiras"].ToString());
                        bandeira.nome_bandeira = Leitor["nome_bandeiras"].ToString();
                        bandeira.taxa = float.Parse(Leitor["taxa"].ToString());
                        bandeira.apagado = bool.Parse(Leitor["apagado"].ToString());

                        lista.Add(bandeira);
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
