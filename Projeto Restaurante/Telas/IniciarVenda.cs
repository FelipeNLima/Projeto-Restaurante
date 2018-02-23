using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Restaurante.Telas
{
	using Modelos;
	public partial class IniciarVenda : Form
	{
		ClasseMesa mesa;
        List<ClasseUsuario> lista = new List<ClasseUsuario>();


        public IniciarVenda(ClasseMesa mesa)
		{
			InitializeComponent();
			ClasseMesa.CarregarMesa();
			this.mesa = mesa;

			TBnumeroMesa.Text = mesa.numero.ToString();
		}

        private void BTabrir_Click(object sender, EventArgs e)
		{
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
               

                string index_garcom = CBnomegarcom.Text;
                string numeropessoa = TBnumeropessoas.Text;
                string couvert = TBcouvert.Text;
                mesa.MudarParaOcupado();
                Telas.Venda abrir = new Venda(mesa, index_garcom, numeropessoa, couvert);
                abrir.ShowDialog();
                Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void BTsair_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void IniciarVenda_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue.Equals(27)) //ESC
			{
				this.Close();
			}
		}

        private void IniciarVenda_Load(object sender, EventArgs e)
        {
            lista = ClasseUsuario.CarregarGarcom();

            foreach (var item in lista)
            {
                CBnomegarcom.Items.Add(item.nome);
            }
        }
    }
}
