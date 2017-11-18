using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Restaurante.Telas
{
    public partial class Pagamento : Form
    {
        ClasseVenda venda = new ClasseVenda();
        ClasseMesa mesa = new ClasseMesa();
        List<ClasseFormaPagamento> listaformapagamento = new List<ClasseFormaPagamento>();
        public Pagamento(float valortotal, int id_mesa)
        {
            InitializeComponent();
            TBvalortotal.Text = valortotal.ToString("N2");
            venda.CarregarVendaPorMesa(id_mesa);
            mesa.CarregarMesaPorID(id_mesa);
        }

        public void EfetuarPagamento()
        {
            Modelos.ClassePagamento pagamento = new Modelos.ClassePagamento();

            pagamento.Valor = float.Parse(TBvalortotal.Text);
            pagamento.data = DateTime.Now;
            pagamento.troco = float.Parse(TBtroco.Text);
            pagamento.apagado = false;
            pagamento.venda = venda;
            pagamento.formaPagamento = listaformapagamento[CBformapagamento.SelectedIndex];
            ClasseBandeira bandeira = new ClasseBandeira();
            bandeira.CarregarPorID(int.Parse(TBopcao.Text));
            pagamento.bandeiras = bandeira;
            ClasseCaixa caixa = new ClasseCaixa();
            caixa.CarregarCaixa();
            pagamento.caixa = caixa;

            bool certo = pagamento.CadastrarPagamento();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Bandeira do Cartão Cadastrada com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Bandeira do Cartão! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
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
            mesa.status = StatusMesa.Disponivel;
            mesa.AtualizarMesa();
            venda.Status_Venda = StatusVenda.Disponivel;
            venda.AtualizarVenda();
            EfetuarPagamento();
        }

        public void preencherLabel()
        {
            TBsubtotal.Text = calcularSubTotal().ToString("N2");
            TBtroco.Text = CalcularTroco().ToString("N2");
        }
        public float calcularSubTotal()
        {
            float valortotal =0;
            valortotal += valortotal;
            valortotal = float.Parse(TBvalorRecebido.Text);
            return valortotal;
        }

        public float CalcularTroco()
        {
            float valor1 = 0, valor2 = 0, troco = 0;
            valor1 = float.Parse(TBsubtotal.Text);
            valor2 = float.Parse(TBvalortotal.Text);
            if(valor1 > valor2)
                troco = (valor1 - valor2);
            return troco; 
        }

        public void calcularSeAbateuValor()
        {
            float valor1 = 0, valor2 = 0;
            valor1 = float.Parse(TBvalortotal.Text);
            valor2 = float.Parse(TBsubtotal.Text);
            if (valor1 <= valor2)
            {
                TBvalorRecebido.Text = (" ");
                TBopcao.Text = (" ");
            }
        }

        private void TBvalorRecebido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularSubTotal();
                preencherLabel();
                calcularSeAbateuValor();
                preencherLabel();
            }
        }
    }
}
