using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Verificações
{
	class ValidadorCNPJ
	{
		public static bool ValidarCNPJ(string cnpj)
		{
			var multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
			var multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

			string tempCnpj;
			string digito;
			string verifica;
			int soma;
			int resto;

			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace("/", "").Replace(".", "").Replace("-", "");

			if (cnpj.Length == 14)
			{
				verifica = cnpj.Substring(12);
				tempCnpj = cnpj.Substring(0, 12);
				soma = 0;

				for (var i = 0; i < 12; i++)
					soma = soma + int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

				resto = soma % 11;
				resto = resto < 2 ? 0 : 11 - resto;
				digito = resto.ToString();
				tempCnpj = tempCnpj + digito;
				soma = 0;

				for (var i = 0; i < 13; i++)
					soma = soma + int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

				resto = soma % 11;
				resto = resto < 2 ? 0 : 11 - resto;
				digito = digito + resto;

				if (digito != verifica)
					return false;

				for (var i = 0; i < 10; i++)
					if (cnpj == new string(char.Parse(i.ToString()), 14))
						return false;
			}
			else
				return false;

			return true;
		}
	}
}


