using System;
using System.Windows.Forms;


namespace Projeto_Restaurante
{
    public partial class carregando : Form
    {
        bool certo = false;
        public carregando(int cargo)
        {
            if(cargo != 1)
            {
                certo = true;
            }
            InitializeComponent();

            timer1.Interval = 2000; //Definir o intervalo em 2 segundos
            timer1.Tick += timer_Tick;
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false; // Parar o timer, porque isso só é necessário uma vez
            Hide();
            Principal mudar = new Principal();
            if (certo)
            {
                mudar.TSBusuario.Enabled = false;
            }
            mudar.ShowDialog();
            Close();
        }

        private void carregando_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Iniciar o timer quando o form for carregado
           
        }
    }


}
