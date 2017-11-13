using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Restaurante.Verificações
{
	class Entradas
	{

		public void VerificaLetra(KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
				
			}
			
		}

		public void VerificaNumero(KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
		}

	}
}
