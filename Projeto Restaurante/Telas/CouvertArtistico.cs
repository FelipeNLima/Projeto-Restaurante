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
        Modelos.ClasseVenda venda = new Modelos.ClasseVenda();
        public CouvertArtistico(Modelos.ClasseVenda venda)
        {
            InitializeComponent();
            this.venda = venda;
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTsalvar_Click(object sender, EventArgs e)
        {
            venda.Couvert_artistico = float.Parse(TBvalor.Text);
            venda.AtualizarVenda();
            Close();
        }
    }
}
