using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
    public class ClasseCargo
    {
        public int id_cargo { get; set; }
        public string descricao { get; set; }

        public void CarregarCargo()
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT id_cargo, descricao FROM CARGO", obj.objCon);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_cargo = int.Parse((Leitor["id_cargo"]).ToString());
                    descricao = Leitor["descricao"].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        public void CarregarCargoPorID(int ID)
        {
            Conexao obj = new Conexao();
            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT id_cargo, descricao FROM CARGO WHERE id_cargo=@ID", obj.objCon);
                cmd.Parameters.AddWithValue("@ID", ID);
                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_cargo = int.Parse((Leitor["id_cargo"]).ToString());
                    descricao = Leitor["descricao"].ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        public static List<ClasseCargo> ListaCarregarCargo()
        {

            {
                Conexao obj = new Conexao();
                List<ClasseCargo> lista = new List<ClasseCargo>();

                try
                {
                    obj.conectar();
                    SqlDataReader Leitor = null;
                    SqlCommand cmd = new SqlCommand("SELECT id_cargo, descricao FROM CARGO", obj.objCon);

                    Leitor = cmd.ExecuteReader();

                    while (Leitor.Read())
                    {
                        ClasseCargo cargo = new ClasseCargo();
                        cargo.id_cargo = int.Parse((Leitor["id_cargo"]).ToString());
                        cargo.descricao = Leitor["descricao"].ToString();


                        lista.Add(cargo);
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
