using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Restaurante.Telas
{
    public partial class TransferirMesa : Form
    {
        Modelos.ClasseMesa mesa = new Modelos.ClasseMesa();
        Modelos.ClasseVenda venda = new Modelos.ClasseVenda();
        Modelos.ClasseConsumo consumo = new Modelos.ClasseConsumo();
        public TransferirMesa()
        {
            InitializeComponent();
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);

                mesa.CarregarMesaPorID(int.Parse(TBmesaatual.Text));
                mesa.status = Modelos.StatusMesa.Disponivel;
                mesa.AtualizarMesa();

                mesa.CarregarMesaPorID(int.Parse(TBmesanova.Text));
                mesa.status = Modelos.StatusMesa.Ocupado;
                mesa.AtualizarMesa();

                venda.CarregarVendaPorMesa(int.Parse(TBmesaatual.Text));
                venda.mesa.id_mesa = int.Parse(TBmesanova.Text);

                venda.Data_saida = DateTime.Now;
                venda.AtualizarVenda();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
