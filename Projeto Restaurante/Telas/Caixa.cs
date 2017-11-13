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
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
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
    }
}
