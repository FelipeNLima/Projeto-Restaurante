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
    public partial class Pagamento : Form
    {
        List<Modelos.ClasseBandeira> listabandeira = new List<Modelos.ClasseBandeira>();
        public Pagamento(float valortotal)
        {
            InitializeComponent();
            TBvalortotal.Text = valortotal.ToString();
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            listabandeira = Modelos.ClasseBandeira.CarregarBandeira();

            foreach (var item in listabandeira)
            {
                CBformapagamento.Items.Add(item.nome_bandeira);
            }
        }
    }
}
