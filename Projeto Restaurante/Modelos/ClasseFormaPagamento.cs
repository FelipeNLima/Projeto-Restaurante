﻿using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    class ClasseFormaPagamento
    {
        public int id_formaPagamento { get; set; }
        public string tipo_pagamento { get; set; }
        public bool apagado { get; set; } = false;


        public bool CadastrarFormaPagamento()
        {
            Conexao obj = new Conexao();
            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO FORMA_PAGAMENTO (tipo_pagamento, apagado)   VALUES (@TIPOPAGAMENTO, @APAGADO)";
                obj.cmd = new System.Data.SqlClient.SqlCommand (sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@TIPOPAGAMENTO",tipo_pagamento);
                obj.cmd.Parameters.AddWithValue("@APAGADO",apagado);

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

        public bool AtualizarFormaPagamento()
        {
            Conexao obj = new Conexao();
            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE FORMA_PAGAMENTO SET tipo_pagamento = @TIPOPAGAMENTO, apagado=@APAGADO WHERE id_formaPagamento = @IDFORMAPAGAMENTO";
                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("TIPOPAGAMENTO", tipo_pagamento);
                obj.cmd.Parameters.AddWithValue("APAGADO", apagado);
                obj.cmd.Parameters.AddWithValue("IDFORMAPAGAMENTO", id_formaPagamento);

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

        public void DeletarFormaPagamento()
        {
            this.apagado = true;
            AtualizarFormaPagamento();
        }

        public void CarregarPorID(int id)
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT tipo_pagamento FROM FORMA_PAGAMENTO WHERE id_formaPagamento = '" +id+ "'", obj.objCon );

                Leitor = cmd.ExecuteReader();

                if(Leitor.Read())
                {
                    this.id_formaPagamento = id;
                    tipo_pagamento = (Leitor["tipo_pagamento"].ToString());
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        public bool TemFormaPagamento(string nome, int id_formaPagamento)
        {
            bool existe = false;
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();

                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT  COUNT (*) FROM FORMA_PAGAMENTO WHERE id_formaPagamento != '" + id_formaPagamento + "' AND tipo_pagamento = '" + nome + "' AND apagado = 0", obj.objCon);
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
    }
}
