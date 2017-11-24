using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Restaurante.Telas
{
    public partial class Pagamento : Form
    {
        ClasseVenda venda = new ClasseVenda();
        ClasseMesa mesa = new ClasseMesa();
        ClassePagamento pagamento = new ClassePagamento();
        List<ClasseFormaPagamento> listaformapagamento = new List<ClasseFormaPagamento>();
        int idmesa;
        public bool alterou;

        public Pagamento(float valortotal, int id_mesa)
        {
            InitializeComponent();
            TBvalortotal.Text = valortotal.ToString("N2");
            this.idmesa = id_mesa;
        }

        public bool EfetuarPagamento()
        {
            Modelos.ClassePagamento pagamento = new Modelos.ClassePagamento();

            pagamento.Valor_total = float.Parse(TBvalortotal.Text);
            pagamento.Valor_recebido = float.Parse(TBvalorRecebido.Text);
            pagamento.data = DateTime.Now;
            if(TBtroco.Text == "")
            {
                TBtroco.Text = "0";
            } 
            pagamento.troco = float.Parse(TBtroco.Text);
            venda.CarregarVendaPorMesa(idmesa);
            pagamento.venda = venda;
            pagamento.formaPagamento = listaformapagamento[CBformapagamento.SelectedIndex];
            ClasseBandeira bandeira = new ClasseBandeira();
            bandeira.CarregarPorID(int.Parse(TBopcao.Text));
            pagamento.bandeiras = bandeira;
            ClasseCaixa caixa = new ClasseCaixa();
            caixa.CarregarCaixa();
            pagamento.caixa = caixa;

            bool certo = pagamento.CadastrarPagamento();
            return certo;

        }

        public void CarregarListViewBandeira(int opcao)
        {
            Conexao obj = new Conexao();
            LVbandeiracartao.Items.Clear();
            try
            {
                string sql = $@"SELECT 
                                id_bandeiras,
                                nome_bandeiras   
                                FROM BANDEIRA_CARTAO 
								INNER JOIN FORMA_PAGAMENTO ON FORMA_PAGAMENTO.id_formaPagamento = BANDEIRA_CARTAO.id_formaPagamento 
                                WHERE FORMA_PAGAMENTO.id_formaPagamento = '{opcao}'";
                
                obj.conectar();


                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();

                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    
                    id.SubItems.Add(nome);

                    LVbandeiracartao.Items.Add(id);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            listaformapagamento = ClasseFormaPagamento.CarregarFormadePagamento();

            foreach (var item in listaformapagamento)
            {
                CBformapagamento.Items.Add(item.tipo_pagamento);
            }

            int valor = CBformapagamento.SelectedIndex;
            CarregarListViewBandeira(valor);
        }

        private void CBformapagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarListViewBandeira(listaformapagamento[CBformapagamento.SelectedIndex].id_formaPagamento);
        }

        private void BTok_Click(object sender, EventArgs e)
        {
            ClasseMesa mesa = new ClasseMesa();
            mesa.CarregarMesaPorID(idmesa);
            mesa.status = StatusMesa.Disponivel;
            mesa.AtualizarMesa();
            venda.Status_Venda = StatusVenda.Finalizado;
            venda.AtualizarVenda();
            alterou = true;
            this.Close();
            

        }

        public void preencherLabel()
        {
            TBsubtotal.Text = SomaSubtotal().ToString("N2");
            TBtroco.Text = CalcularTroco().ToString("N2");   
        }

        public void ApagarLabel()
        {
            CBformapagamento.Text = " ";
            TBopcao.Text = " ";
            TBvalorRecebido.Text = " ";
            LVbandeiracartao.Items.Clear();
        }

        public float SomaSubtotal()
        {
            pagamento.CarregarPagamento();
            float valor = 0, valor1 = 0, valor2 = 0;
            valor1 = pagamento.Valor_recebido;
            if(TBsubtotal.Text == "")
            {
                TBsubtotal.Text = "0";
            }
            valor2 = float.Parse(TBsubtotal.Text);
            valor = valor1 + valor2;
            return valor;
            
        }

        public float CalcularTroco()
        {
            pagamento.CarregarPagamento();
            float troco=0, valor1 = 0, valor2 = 0;
            valor1 = float.Parse(TBsubtotal.Text); 
            valor2 = pagamento.Valor_total;
            troco = valor1 - valor2;
            if (troco < 0)
            {
                TBtroco.ForeColor = Color.Red;
            }
            return troco; 
        }

        public bool calcularSeAbateuValor()
        {
            float valor = 0, valorSubtotal = 0;
            pagamento.CarregarPagamento();
            valor = pagamento.Valor_total;
            if (TBsubtotal.Text == "")
            {
                TBsubtotal.Text = "0";
            }
            valorSubtotal = float.Parse(TBsubtotal.Text);
            if (valor == valorSubtotal)
                return true;
            else
                return false;
        }

        private void TBvalorRecebido_KeyDown(object sender, KeyEventArgs e)
        {
                       
                if (e.KeyCode == Keys.Enter)
                {
              
                    EfetuarPagamento();
                        preencherLabel();
                        ApagarLabel();
                    if(calcularSeAbateuValor())
                    {
                        MessageBox.Show("Pagamento Efetuado com Sucesso");
                    }

                }
     
        }

        private void Pagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void TBvalortotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verificações.Entradas usar = new Verificações.Entradas();
            usar.VerificaNumero(e);
        }

        private void TBopcao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verificações.Entradas usar = new Verificações.Entradas();
            usar.VerificaNumero(e);
        }

        private void TBvalorRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verificações.Entradas usar = new Verificações.Entradas();
            usar.VerificaNumero(e);
        }

        private void TBsubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verificações.Entradas usar = new Verificações.Entradas();
            usar.VerificaNumero(e);
        }
    }
}
