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
        public bool apagado { get; set; } = false;
        public ClasseFormaPagamento formapagamento { get; set; }


        public bool CadastrarBandeira()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = " INSERT INTO BANDEIRA_CARTAO (nome_bandeira, apagado, id_formaPagamento) VALUES (@NOMEBANDEIRA, @APAGADO, @IDFORMAPAGAMENTO)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql ,obj.objCon);

                obj.cmd.Parameters.AddWithValue("@NOMEBANDEIRA", nome_bandeira);
                obj.cmd.Parameters.AddWithValue("@APAGADO", apagado);
                obj.cmd.Parameters.AddWithValue("@IDFORMAPAGAMENTO", formapagamento.id_formaPagamento);

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

                string sql = "UPDATE BANDEIRA_CARTAO SET  nome_bandeira = @NOMEBANDEIRA, apagado = @APAGADO, id_formaPagamento=@IDFORMAPAGAMENTO WHERE id_bandeira = @IDBANDEIRA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                
                obj.cmd.Parameters.AddWithValue("@NOMEBANDEIRA", nome_bandeira);
                obj.cmd.Parameters.AddWithValue("@APAGADO",apagado);
                obj.cmd.Parameters.AddWithValue("@IDBANDEIRA",id_bandeira);
                obj.cmd.Parameters.AddWithValue("@IDFORMAPAGAMENTO", formapagamento.id_formaPagamento);

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
                SqlCommand cmd = new SqlCommand("SELECT nome_bandeira, id_formaPagamento FROM BANDEIRA_CARTAO WHERE id_bandeira = @ID", obj.objCon);

				cmd.Parameters.AddWithValue("@ID", id);

				Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
					this.id_bandeira = id;
					nome_bandeira = (Leitor["nome_bandeira"].ToString());
                    formapagamento = new ClasseFormaPagamento();
                    formapagamento.id_formaPagamento = int.Parse(Leitor["id_formaPagamento"].ToString());
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
                SqlCommand cmd = new SqlCommand("SELECT  COUNT (*) FROM BANDEIRA_CARTAO WHERE id_bandeira != '" + id_bandeira + "' AND nome_bandeira = '" + nome + "' AND apagado = 0", obj.objCon);
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
                    SqlCommand cmd = new SqlCommand("SELECT id_bandeira,nome_bandeira,apagado,id_formaPagamento FROM BANDEIRA_CARTAO WHERE apagado = 0", obj.objCon);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        ClasseBandeira bandeira = new ClasseBandeira();
                        bandeira.id_bandeira = int.Parse(Leitor["id_bandeira"].ToString());
                        bandeira.nome_bandeira = Leitor["nome_bandeira"].ToString();
                        bandeira.apagado = bool.Parse(Leitor["apagado"].ToString());
                        bandeira.formapagamento.id_formaPagamento = int.Parse(Leitor["id_formaPagamento"].ToString());

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
