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
                    if ((campo as TextBox)?.Tag != null)
                        if ((campo as TextBox)?.Tag?.ToString() == "*")
                            if (string.IsNullOrEmpty((campo as TextBox).Text))
                                throw new Exception("Campo(s) Inválido(s)!");
                }
                else if (campo is ComboBox)
                    if ((campo as ComboBox)?.Tag != null)
                        if ((campo as ComboBox)?.Tag?.ToString() == "*")
                            if ((campo as ComboBox)?.SelectedIndex == -1)
                                throw new Exception("Campo(s) Inválido(s)!");
            }
        }
    }
}
