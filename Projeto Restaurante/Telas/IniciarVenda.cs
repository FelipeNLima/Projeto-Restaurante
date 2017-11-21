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
	using Modelos;
	public partial class IniciarVenda : Form
	{
		ClasseMesa mesa;

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

                string numerogarcom = TBnumerogarçom.Text;
                string numeropessoa = TBnumeropessoas.Text;
                mesa.MudarParaOcupado();
                Telas.Venda abrir = new Venda(mesa, numerogarcom, numeropessoa);
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
	}
}
