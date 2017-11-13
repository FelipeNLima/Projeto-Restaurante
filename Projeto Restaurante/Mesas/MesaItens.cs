using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projeto_Restaurante
{
    using Modelos;
    class MesaItens
    {
        public static Color getCorMesas(ClasseMesa mesa)
        {
            if (mesa.status == StatusMesa.Disponivel)
            {
                return Color.Green;
            }
            else if(mesa.status == StatusMesa.Ocupado)
            {
                return Color.Red;
            }
            return Color.Yellow;
        } 
    }
}
