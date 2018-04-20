using System;
using Projeto_Restaurante.Conexão;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Projeto_Restaurante.Telas
{

    using Modelos;
    public partial class Venda : Form
    {
        public bool alteracao;
        private ClasseUsuario usuario = new ClasseUsuario();
        private ClasseVenda venda = new ClasseVenda();
        private ClasseConsumo consumo = new ClasseConsumo();
        private ClasseCardapio carregarcardapio = new ClasseCardapio();
        private ClasseConfiguracaoCouvert couvertartistico = new ClasseConfiguracaoCouvert();
        private ClasseMesa mesa;


        List<ClasseCardapio> listaproduto = new List<ClasseCardapio>();

        // MESA ABERTA
        public Venda(ClasseMesa mesa)
        {
            InitializeComponent();
            venda.CarregarVendaPorMesa(mesa.id_mesa);
            couvertartistico.CarregarCouvert();
            TBcouvert.Text = couvertartistico.Valor.ToString();
            TBdesconto.Text = venda.Desconto.ToString();
            Time_entrada.Text = "Horario Entrada " + venda.Data_entrada.ToLongTimeString();
            TBtelanumerovenda.Text = mesa.numero.ToString();
            TBnumeropessoas.Text = venda.Numero_pessoa.ToString();
            usuario.CarregarUsuarioGarcom();
            TBnomegarcom.Text = usuario.nome.ToString();
            this.mesa = mesa;
            CarregarCardapio();
            CarregarDataGridVenda();
        }

        // ABRIR MESA
        public Venda(ClasseMesa mesa, string index, string numeropessoas)
        {
            InitializeComponent();
            this.mesa = mesa;
            Time_entrada.Text = "Horario Entrada: " + DateTime.Now.ToLongTimeString();
            TBtelanumerovenda.Text = mesa.numero.ToString();
            TBnomegarcom.Text = index;
            TBnumeropessoas.Text = numeropessoas;
            TBdesconto.Text = "0";

            if (couvertartistico.ativo == 1)
            {
                TBcouvert.Text = couvertartistico.Valor.ToString();
            }
            else
            {
                TBcouvert.Text = "0";
            }
            CarregarCardapio();
            EfetuarVenda();
        }

        // VENDA
        public void EfetuarVenda()
        {
           ClasseVenda venda = new ClasseVenda();
            

            venda.Numero_pessoa = int.Parse(TBnumeropessoas.Text);
            venda.Data_entrada = DateTime.Now;
            venda.Data_saida = DateTime.Now;
            usuario.CarregarUsuarioGarcomPorNome(TBnomegarcom.Text);
            venda.usuario = usuario;
            venda.mesa = mesa;
            venda.Status_Venda = StatusVenda.Ocupado;
            venda.Couvert_artistico = float.Parse(TBcouvert.Text);
            venda.taxaservico = float.Parse(texttaxaservico.Text);
            venda.Desconto = float.Parse(TBdesconto.Text);

            venda.InserirVenda();
        }

        public void AtualizarVenda(int statusdamesa)
        {
            venda.id_venda = venda.id_venda;
            venda.Numero_pessoa = int.Parse(TBnumeropessoas.Text);
            venda.Desconto = float.Parse(TBdesconto.Text);
            venda.Data_saida = DateTime.Now;
            venda.Couvert_artistico = float.Parse(TBcouvert.Text);
            venda.taxaservico = float.Parse(texttaxaservico.Text);
            mesa.CarregarMesaPorID(int.Parse(TBtelanumerovenda.Text));
            venda.mesa = mesa;
            ClasseUsuario carregar = new ClasseUsuario();
            carregar.CarregarUsuarioGarcomPorNome(TBnomegarcom.Text);
            venda.usuario = carregar;

            if (statusdamesa == 1)
            {
                venda.Status_Venda = StatusVenda.Ocupado;
            }
            else
            {
                venda.Status_Venda = StatusVenda.ReceberPagamento;  
            }

            venda.AtualizarVenda();
            

        }

        public void carregarVenda(int id)
        {
            Conexao obj = new Conexao();

            try
            {
                obj.conectar();
                SqlDataReader Leitor = null;
                SqlCommand cmd = new SqlCommand("SELECT	Numero_pessoa, Usuario.nome, MESA.id_mesa FROM VENDA INNER JOIN USUARIO ON USUARIO.id_usuario = VENDA.id_usuario INNER JOIN  MESA ON MESA.id_mesa = VENDA.id_mesa WHERE MESA.id_mesa = @ID", obj.objCon);

                cmd.Parameters.AddWithValue("@ID", id);

                Leitor = cmd.ExecuteReader();

                if (Leitor.Read())
                {

                    TBnumeropessoas.Text = (Leitor["Numero_pessoa"].ToString());
                    usuario = new ClasseUsuario();
                    usuario.CarregarUsuarioGarcomPorNome(TBnomegarcom.Text);
                    TBnomegarcom.Text = usuario.nome.ToString();
                    mesa = new ClasseMesa();
                    TBtelanumerovenda.Text = (Leitor["id_mesa"].ToString());
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                throw;
            }
            finally { obj.desconectar(); }
        }

        private void Venda_Load(object sender, EventArgs e)
        {
            CBproduto.Focus();
            timer2_Tick(e, e);
        }

        // CONSUMO
        public void CadastrarConsumo()
        {
            ClasseConsumo consumo = new ClasseConsumo();
            string verifica = "^[0-9]";

            consumo.quantidade = 1; 
            if (Regex.IsMatch(CBproduto.Text, verifica))
            {
                ClasseCardapio cardapio = new ClasseCardapio();
                cardapio.CarregarPorId(int.Parse(CBproduto.Text));
                consumo.Cardapio = cardapio;
                consumo.Valor_total = cardapio.preco_item;
            }
            else
            {
                ClasseCardapio cardapio = listaproduto[CBproduto.SelectedIndex];
                consumo.Cardapio = cardapio;
                consumo.Valor_total = cardapio.preco_item;
            }
            
            venda.CarregarVendaPorMesa(int.Parse(TBtelanumerovenda.Text));
            consumo.Venda = venda;
            consumo.apagado = false;

            consumo.CadastrarConsumo();

        }

        public void AtualizarConsumo()
        {
            ClasseCardapio cardapio = listaproduto[CBproduto.SelectedIndex];

            consumo.id_consumo = consumo.id_consumo;
            consumo.quantidade = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            consumo.Valor_total = CalculaValorTotalDataGridView();
            consumo.apagado = false;
            consumo.Cardapio = cardapio;
            consumo.Venda = venda;

            consumo.AtualizarConsumo();

        }

        public void DeletarConsumo(int index)
        {
            ClasseCardapio cardapio = listaproduto[index];

            consumo.id_consumo = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            consumo.quantidade = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            consumo.Valor_total = CalculaValorTotalDataGridView();
            consumo.Cardapio = cardapio;
            consumo.Venda = venda;

            consumo.DeletarConsumo();

        }

        // CARDAPIO
        public void CarregarCardapio()
        {
            listaproduto = ClasseCardapio.CarregarTodoCardapio();
            foreach (var itemcardapio in listaproduto)
            {
                CBproduto.Items.Add(itemcardapio.nome_item);
            }
        }

        // CALCULOS DA VENDA
        public void preencher_Label()
        {
            textsubtotal.Text = CalculaValorTotalDataGridView().ToString("N2");
            textcouvert.Text = CalculaCouvert_Artistico().ToString("N2");
            texttaxaservico.Text = CalculaTaxaServiço().ToString("N2");
            textdesconto.Text = CalculaDesconto().ToString("N2");
            textvalortotal.Text = CalcularValorTotalPagar().ToString("N2");
        }

        public float CalcularValorTotalPagar()
        {
            float valor1, valor2, valor3, valor4, valortotal;

            valor1 = CalculaValorTotalDataGridView();
            valor2 = CalculaCouvert_Artistico();
            valor3 = CalculaTaxaServiço();
            valor4 = CalculaDesconto();

            valortotal = (valor1 + valor2 + valor3) - valor4;

            return valortotal;
        }

        public float CalculaDesconto()
        {
            float valor1, valor2;

            valor1 = float.Parse(TBdesconto.Text);
            valor2 = CalculaValorTotalDataGridView();

            return valor1 * valor2 / 100;
        }

        public float CalculaTaxaServiço()
        {

            float valor1 = 0, valortaxa = 0;

            valor1 = CalculaValorTotalDataGridView();
            valortaxa = valor1 * 10 / 100;

            return valortaxa;
        }

        public float CalculaCouvert_Artistico()
        {
            return venda.Numero_pessoa * venda.Couvert_artistico;
        }

        public float CalculaValorTotalDataGridView()
        {
            return ClasseConsumo.CarregerConsumoPorVenda(venda.id_venda).Sum(x => x.Valor_total);
        }

        // CARREGAR DATAGRIDVIEW
        public void CarregarDataGridVenda()
        {
            dataGridView1.Rows.Clear();
            var listaconsumo = ClasseConsumo.CarregerConsumoPorVenda(venda.id_venda);

            foreach (var consumo in listaconsumo)
            {
                int x = dataGridView1.Rows.Add();

                dataGridView1.Rows[x].Cells[0].Value = consumo.Cardapio.id_cardapio;
                dataGridView1.Rows[x].Cells[1].Value = consumo.Cardapio.nome_item;
                dataGridView1.Rows[x].Cells[2].Value = consumo.Cardapio.preco_item;
                dataGridView1.Rows[x].Cells[3].Value = consumo.quantidade;
                dataGridView1.Rows[x].Cells[4].Value = consumo.Valor_total = consumo.Cardapio.preco_item * consumo.quantidade;
                dataGridView1.Rows[x].Cells[5].Value = consumo.id_consumo;

                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].Visible = false;

                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[4].ReadOnly = true;

                dataGridView1.RowHeadersVisible = false;
            }

            preencher_Label();
        }

        // CALCULAR SUBTOTAL
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    int valor1;
                    float valor2;

                    valor1 = int.Parse(row.Cells[3].Value.ToString());
                    valor2 = float.Parse(row.Cells[2].Value.ToString());

                    row.Cells[4].Value = valor1 * valor2;
                    int idconsumo = int.Parse(row.Cells[5].Value.ToString());

                    consumo.CarregarPorID(idconsumo);
                    consumo.Valor_total = valor1 * valor2;
                    consumo.quantidade = valor1;
                    consumo.Cardapio = listaproduto[dataGridView1.CurrentRow.Index];
                    consumo.AtualizarConsumo();

                    preencher_Label();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DATA E HORA
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datahora = System.DateTime.Now;
            Data.Text = "Data: " + datahora.ToShortDateString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime datahora = System.DateTime.Now;
            Time_saida.Text = "Horario Saida:   " + datahora.ToLongTimeString();
        }

        // BOTOES DE ATALHOS
        private void Venda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F4)
            {
                Close();
            }
            else if(e.KeyCode == Keys.F5)
            {
                
                mesa.CarregarMesaPorID(int.Parse(TBtelanumerovenda.Text));
                mesa.status = StatusMesa.Ausente;
                mesa.AtualizarMesa();
                alteracao = true;
                AtualizarVenda(2);
                this.Close();
            }
            else if(e.KeyCode == Keys.F6)
            {
                if (venda.Status_Venda == StatusVenda.ReceberPagamento)
                {
                    float valor = float.Parse(textvalortotal.Text);
                    int idmesa = int.Parse(TBtelanumerovenda.Text);
                    Pagamento abrir = new Pagamento(valor,idmesa);
                    this.Close();
                    abrir.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Não foi possivel efetuar o Recebimento da Mesa");
                }
            }
                
        }

        private void CBproduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void CBproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CadastrarConsumo();
                CarregarDataGridVenda();
            }
        }

        private void BTvoltarMenu_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                Close();
            }
        }

        private void BTvoltarMenu_Click(object sender, EventArgs e)
        {
            Principal voltar = new Principal();
            voltar.Show();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DeletarConsumo(dataGridView1.CurrentRow.Index);
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    preencher_Label();
                }
            }
        }

        private void BTfecharMesa_Click_1(object sender, EventArgs e)
        {
            mesa.CarregarMesaPorID(int.Parse(TBtelanumerovenda.Text));
            mesa.status = StatusMesa.Ausente;
            mesa.AtualizarMesa();
            alteracao = true;
            AtualizarVenda(2);
            this.Close();
            
        }

        private void BTpagamento_Click(object sender, EventArgs e)
        {
            
            if (venda.Status_Venda == StatusVenda.ReceberPagamento)
            {
                float valor = float.Parse(textvalortotal.Text);
                int idmesa = int.Parse(TBtelanumerovenda.Text);
                Pagamento abrir = new Pagamento(valor, idmesa);
                abrir.ShowDialog();
                if (abrir.alterou)
                {
                    this.Close();
                }
                alteracao = abrir.alterou;
            }
            else
            {
                MessageBox.Show("Não foi possivel efetuar o Recebimento da Mesa");
            }
        }

        private void TBcouvert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarVenda(1);
                preencher_Label();

            }
        }

        private void TBdesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarVenda(1);
                preencher_Label();
            }
        }

        private void TBnumeropessoas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarVenda(1);
                preencher_Label();
            }
        }
    }
}
