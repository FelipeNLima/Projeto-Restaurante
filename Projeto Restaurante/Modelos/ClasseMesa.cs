﻿using System;
using System.Collections.Generic;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Modelos
{
    public class ClasseMesa
    {
        public int id_mesa { get; set; }
        public int numero { get; set; }
        public StatusMesa status { get; set; }

        public static List<ClasseMesa> CarregarMesa()
        {
            Conexao obj = new Conexao();

            List<ClasseMesa> lista = new List<ClasseMesa>();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT id_mesa, Numero_mesas, Status FROM MESA", obj.objCon);

                Leitor = cmd.ExecuteReader();
                while (Leitor.Read())
                {
                    ClasseMesa mesa = new ClasseMesa();
                    mesa.id_mesa = int.Parse(Leitor["id_mesa"].ToString());
                    mesa.numero = int.Parse(Leitor["Numero_mesas"].ToString());
                    mesa.status = (StatusMesa)Enum.Parse(typeof(StatusMesa), Leitor["Status"].ToString());

                    lista.Add(mesa);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }
            return lista;
        }

        public bool AtualizarMesa()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE MESA SET  Numero_mesas = @NUMERO, Status = @STATUS WHERE id_mesa = @IDMESA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


                obj.cmd.Parameters.AddWithValue("@NUMERO", numero);
                obj.cmd.Parameters.AddWithValue("@STATUS", status);
                obj.cmd.Parameters.AddWithValue("@IDMESA", id_mesa);

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

        public void CarregarMesaPorID(int id)
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT	id_mesa, Numero_mesas, Status FROM MESA WHERE Numero_mesas = @ID", obj.objCon);

                cmd.Parameters.AddWithValue("@ID", id);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_mesa = int.Parse(Leitor["id_mesa"].ToString());
                    status = (StatusMesa)Enum.Parse(typeof(StatusMesa), Leitor["Status"].ToString());
                    numero = int.Parse((Leitor["Numero_mesas"].ToString()));
                   
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        public void MudarParaOcupado()
        {
            status = StatusMesa.Ocupado;
            AtualizarMesa();
        }






    }
}
