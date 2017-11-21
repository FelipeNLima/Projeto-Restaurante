using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Restaurante.Verificações
{
    public class VerificarCampos
    {

        public static void Validar(Control.ControlCollection controls)
        {
            foreach (Control campo in controls)
            {
                if (campo is TextBox)
                {
                    if ((campo as TextBox)?.Tag.ToString() == "*")
                        if (string.IsNullOrEmpty((campo as TextBox).Text))
                        throw new Exception("Campo(s) Inválido(s)!");
                }
            }
        }
    }
}
