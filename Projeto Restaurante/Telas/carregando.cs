using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace Projeto_Restaurante
{
    public partial class carregando : Form
    {
        public carregando()
        {
            InitializeComponent();

            timer1.Interval = 2000; //Definir o intervalo em 2 segundos
            timer1.Tick += timer_Tick;
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; // Parar o timer, porque isso só é necessário uma vez
            Hide();
            Projeto_Restaurante.Principal mudar = new Principal();
            mudar.ShowDialog();
            Close();
        }

        private void carregando_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Iniciar o timer quando o form for carregado
           
        }
    }


}
