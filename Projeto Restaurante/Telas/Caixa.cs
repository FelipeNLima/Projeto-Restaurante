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
    public partial class Caixa : Form
    {
        bool statuscaixa;
        private StatusCaixa aberto;

        // ABRIR CAIXA
        public Caixa()
        {
            InitializeComponent();
            statuscaixa = true;
            
        }

        // FECHAR CAIXA
        public Caixa(StatusCaixa aberto)
        {
            InitializeComponent();
            this.aberto = aberto;
            this.Text = "Fechar Caixa";
            
        }

        public bool AbrirCaixa()
        {
            Modelos.ClasseCaixa caixa = new Modelos.ClasseCaixa();

            caixa.data_abertura = DateTime.Now;
            caixa.valor_inicial = float.Parse(TBvalor.Text);
            caixa.StatusCaixa = StatusCaixa.Aberto;

            bool certo = caixa.AbrirCaixa();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Caixa Aberto!");
                    Close();

                }
                else
                {
                    MessageBox.Show("Erro ao Abrir Caixa!");
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
            return certo;
        }

        public bool FecharCaixa()
        {
            Modelos.ClasseCaixa caixa = new Modelos.ClasseCaixa();
            caixa.CarregarCaixa();
            caixa.id_caixa = caixa.id_caixa;
            caixa.valor_final = float.Parse(TBvalor.Text);
            caixa.data_fechamento = DateTime.Now;
            caixa.diferença = CalcularDiferenca();
            caixa.StatusCaixa = StatusCaixa.Fechado;

            bool certo = caixa.FecharCaixa();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Caixa Fechado!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Fechar Caixa!");
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
            return certo;
        }

        public float CalcularDiferenca()
        {
            float quebra, valor1;
            Modelos.ClasseCaixa caixa = new Modelos.ClasseCaixa();
            caixa.CarregarCaixa();
            valor1 = float.Parse(TBvalor.Text);
            quebra = valor1 - caixa.valor_inicial;

            return quebra;

        }

        // BOTOES 
        private void TSBsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datahora = System.DateTime.Now;
            data.Text = "Data: " + datahora.ToShortDateString();
            
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            timer1_Tick_1(e, e);
        }

        private void TSBcaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);

                if (statuscaixa)
                {
                    AbrirCaixa();
                }
                else
                {
                    FecharCaixa();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
        }

    }
}
