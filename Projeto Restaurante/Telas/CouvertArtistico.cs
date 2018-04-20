using Projeto_Restaurante.Modelos;
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
    public partial class CouvertArtistico : Form
    {
        ClasseVenda venda = new ClasseVenda();
        ClasseConfiguracaoCouvert configuracao = new ClasseConfiguracaoCouvert();
        public CouvertArtistico()
        {
            InitializeComponent();
            configuracao.CarregarCouvert();
            TBvalor.Text = configuracao.Valor.ToString();
           
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTsalvar_Click(object sender, EventArgs e)
        {
            configuracao.Valor = float.Parse(TBvalor.Text);
            configuracao.ativo = 1;
            configuracao.FixarCouvert();
            Close();
        }
    }
}
