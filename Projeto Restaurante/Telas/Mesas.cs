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
	public partial class Mesas : Form
	{

		public Mesas()
		{
			InitializeComponent();
			panel1.Visible = false;
			CarregarMesas();
			panel1.Visible = true;
		}

		public void CarregarMesas()
		{
			panel1.Controls.Clear();
			int x = 12;
			int y = 12;

			foreach (var mesaitem in ClasseMesa.CarregarMesa())
			{

				panel1.Controls.Add(NovoPanel(mesaitem, new Point(x, y)));
				x += 135;

				if (x + 126 > Screen.PrimaryScreen.WorkingArea.Width)
				{
					x = 12;
					y += 67;

				}

			}
		}

		private Panel NovoPanel(ClasseMesa mesa, Point posicao)
		{
			Color cor = MesaItens.getCorMesas(mesa);
			var pn = new Panel
			{
				Location = posicao,
				Tag = mesa,
				BackColor = cor,
				Size = new System.Drawing.Size(116, 63),
				Cursor = Cursors.Hand,
				BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			};

			var tb = new TextBox
			{
				Text = mesa.numero.ToString(),
				ReadOnly = true,
				TabStop = false,
				Cursor = Cursors.Hand,
				Location = new Point(-2, -4),
				Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, FontStyle.Bold),
				ForeColor = System.Drawing.Color.White,
				BackColor = cor,
				Tag = mesa,
				TextAlign = HorizontalAlignment.Center,
				BorderStyle = System.Windows.Forms.BorderStyle.None,
				Size = new System.Drawing.Size(126, 68),
				AccessibleRole = AccessibleRole.None,
				CausesValidation = false,
				ShortcutsEnabled = false,
				TabIndex = 999,
				WordWrap = false,
			};

            tb.Click += PnClick;
            pn.Controls.Add(tb);

            pn.Tag = mesa;

            pn.Click += PnClick;

            return pn;
        }

		private void PnClick(object sender, EventArgs e)
		{
			ClasseMesa mesaClicada = null;

			if (sender is Panel)
				mesaClicada = (sender as Panel)?.Tag as ClasseMesa;

			if (sender is TextBox)
				mesaClicada = (sender as TextBox)?.Tag as ClasseMesa;

			if (mesaClicada.status == StatusMesa.Disponivel)
			{
				IniciarVenda abrir = new IniciarVenda(mesaClicada);
				abrir.ShowDialog();
				CarregarMesas();
			}
			else  
			{
				Venda x = new Venda(mesaClicada);
				x.ShowDialog();
                if(x.alteracao)
                {
                    CarregarMesas();
                }
			}
		}

		private void Mesas_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue.Equals(27)) //ESC
			{
				this.Close();
			}
            if(e.KeyCode == Keys.F8)
            {
                Telas.TransferirMesa abrir = new TransferirMesa();
                abrir.ShowDialog();
            }
		}

        private void BTcouvertArtistico_Click(object sender, EventArgs e)
        {
            //Telas.CouvertArtistico abrir = new CouvertArtistico();
            //abrir.ShowDialog();
        }

        private void BTTransferirMesa_Click(object sender, EventArgs e)
        {
            Telas.TransferirMesa abrir = new TransferirMesa();
            abrir.ShowDialog();
            CarregarMesas();
        }
    }
}
