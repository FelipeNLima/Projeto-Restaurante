using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using Projeto_Restaurante.Verificações;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class LoginModel
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public bool apagado { get; set; } = false;
        public ClasseCargo cargo { get; set; }


        public void CarregarUsuarioPorLogin(string login)
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();

                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT id_usuario, nome, login, senha, id_cargo FROM USUARIO WHERE login = @LOGIN", obj.objCon);
                cmd.Parameters.AddWithValue("@LOGIN", login);
                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_usuario = int.Parse(Leitor["id_usuario"].ToString());
                    nome = Leitor["nome"].ToString();
                    login = Leitor["login"].ToString();
                    senha = Leitor["senha"].ToString();
                    cargo = new ClasseCargo();
                    cargo.CarregarCargoPorID(int.Parse(Leitor["id_cargo"].ToString()));
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { obj.desconectar(); }
        }

        public bool logar()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "SELECT id_usuario, login, senha, id_cargo FROM USUARIO WHERE login = @LOGIN AND senha = @SENHA";

                obj.cmd = new SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@LOGIN", login);
                obj.cmd.Parameters.AddWithValue("@SENHA", criptografia.GerarHashMd5(senha));



                obj.leitor = obj.cmd.ExecuteReader();

                correto = obj.leitor.Read();
            }
            catch (Exception)
            {
                throw;
            }
            finally { obj.desconectar(); }
            return correto;
        }
    }
}