using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebSiteRestaurante.Models
{
    public class UsuarioModel
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public bool apagado { get; set; } = false;
        public ClasseCargo cargo { get; set; }

        public static List<UsuarioModel> CarregarGarcom()
        {

            {
                Conexao obj = new Conexao();
                List<UsuarioModel> lista = new List<UsuarioModel>();

                try
                {
                    obj.conectar();

                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand("SELECT id_usuario, nome FROM USUARIO WHERE id_cargo = 4", obj.objCon);
                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        UsuarioModel usuario = new UsuarioModel();

                        usuario.id_usuario = int.Parse(Leitor["id_usuario"].ToString());
                        usuario.nome = Leitor["nome"].ToString();

                        lista.Add(usuario);
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