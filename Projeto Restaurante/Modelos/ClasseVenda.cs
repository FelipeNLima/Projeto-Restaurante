using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Modelos
{
    public  class ClasseVenda
    {
        public int id_venda { get; set; }
        public int Numero_pessoa { get; set; } 
        public float Desconto { get; set; }
        public StatusVenda Status_Venda { get; set; }
        public DateTime Data_entrada { get; set; }
        public DateTime Data_saida { get; set; }
        public float Couvert_artistico { get; set; }
        public ClasseGarcom garcom { get; set; }
        public ClasseMesa mesa { get; set; }


        public bool InserirVenda()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "INSERT INTO VENDA (Numero_pessoa, Data_entrada, Data_saida, Status_venda, Desconto, Couvert_artistico, id_garcom, id_mesa)  VALUES ( @NUMEROPESSOAS, @DATAENTRADA, @DATASAIDA, @STATUSVENDA, @DESCONTO, @COUVERT, @IDGARCOM, @IDMESA)";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);


                obj.cmd.Parameters.AddWithValue("@NUMEROPESSOAS", Numero_pessoa);
                obj.cmd.Parameters.AddWithValue("@DATAENTRADA", Data_entrada);
                obj.cmd.Parameters.AddWithValue("@DATASAIDA", Data_entrada);
                obj.cmd.Parameters.AddWithValue("@STATUSVENDA", Status_Venda);
                obj.cmd.Parameters.AddWithValue("@DESCONTO", Desconto);
                obj.cmd.Parameters.AddWithValue("@COUVERT", Couvert_artistico);
                obj.cmd.Parameters.AddWithValue("@IDGARCOM", garcom.id_garcom);
                obj.cmd.Parameters.AddWithValue("@IDMESA", mesa.id_mesa);


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

        public bool AtualizarVenda()
        {
            Conexao obj = new Conexao();

            bool correto = false;

            try
            {
                obj.conectar();

                string sql = "UPDATE VENDA SET Desconto=@DESCONTO, Couvert_artistico=@COUVERT, Status_venda=@STATUSVENDA, id_mesa=@IDMESA, id_garcom=@IDGARCOM where id_venda = @IDVENDA";

                obj.cmd = new System.Data.SqlClient.SqlCommand(sql, obj.objCon);

                obj.cmd.Parameters.AddWithValue("@DESCONTO", Desconto);
                obj.cmd.Parameters.AddWithValue("@COUVERT", Couvert_artistico);
                obj.cmd.Parameters.AddWithValue("@STATUSVENDA", Status_Venda);
                obj.cmd.Parameters.AddWithValue("@IDVENDA", id_venda);
                obj.cmd.Parameters.AddWithValue("@IDMESA",mesa.id_mesa);
                obj.cmd.Parameters.AddWithValue("@IDGARCOM", garcom.id_garcom);


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

        public void CarregarVendaPorID(int id)
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT	Numero_pessoa,Data_entrada,Status_venda, id_garcom, id_mesa FROM VENDA  WHERE id_venda = @ID AND Status_venda != 3", obj.objCon);

                cmd.Parameters.AddWithValue("@ID", id);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    this.id_venda = id;
                    Numero_pessoa = int.Parse((Leitor["Numero_pessoa"].ToString()));
                    Status_Venda = (StatusVenda)Enum.Parse(typeof(StatusVenda), Leitor["Status_venda"].ToString());
                    Data_entrada = DateTime.Parse(Leitor["Data_entrada"].ToString());
                    garcom = new ClasseGarcom();
                    garcom.id_garcom = int.Parse(Leitor["id_garcom"].ToString());
                    mesa = new ClasseMesa();
                    mesa.id_mesa = int.Parse(Leitor["id_mesa"].ToString());
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        public void CarregarVendaPorMesa(int idMesa)
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT	id_venda,Numero_pessoa,Data_entrada,Status_venda, id_garcom, id_mesa FROM VENDA  WHERE id_mesa = @ID AND Status_venda != 3", obj.objCon);

                cmd.Parameters.AddWithValue("@ID", idMesa);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {
                    id_venda = int.Parse(Leitor["id_venda"].ToString());
                    Numero_pessoa = int.Parse((Leitor["Numero_pessoa"].ToString()));
                    Status_Venda = (StatusVenda)Enum.Parse(typeof(StatusVenda), Leitor["Status_venda"].ToString());
                    Data_entrada = DateTime.Parse(Leitor["Data_entrada"].ToString());
                    garcom = new ClasseGarcom();
                    garcom.id_garcom = int.Parse(Leitor["id_garcom"].ToString());
                    mesa = new ClasseMesa();
                    mesa.id_mesa = int.Parse(Leitor["id_mesa"].ToString());
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }


    }
}
