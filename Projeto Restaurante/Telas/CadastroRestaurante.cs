using System;
using System.Windows.Forms;

namespace Projeto_Restaurante
{
	public partial class CadastroRestaurante : Form
	{
		int id;
		bool cadastrar;
		public CadastroRestaurante()
		{
			InitializeComponent();
			cadastrar = true;
		}

		public CadastroRestaurante(int id)
		{
			InitializeComponent();
			this.id = id;
			CarregarDados();
			cadastrar = false;
			this.Text = "Editar Restaurante";
		}

		private void TSBsair_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void TSBcadastrar_Click(object sender, EventArgs e)
		{
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
                if (validar())
                    if (cadastrar)
                    {
                        cadastrarRestaurante();
                    }
                    else
                    {
                        AtualizarRestaurante();
                    }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private bool validar()
		{
			if (!Verificações.ValidadorCNPJ.ValidarCNPJ(TBcnpj.Text))
			{
				MessageBox.Show("CNPJ invalido");
				return false;
			}
			return true;
		}
		public void cadastrarRestaurante()
		{
			Modelos.ClasseRestaurante restaurante = new Modelos.ClasseRestaurante();


			restaurante.Nome_restaurante = TBrazaosocial.Text;
			restaurante.Nome_fantasia = TBnomefantasia.Text;
			restaurante.CNPJ = TBcnpj.Text;
			restaurante.IE = TBie.Text;
			restaurante.Telefone = TBtelefone.Text;
			restaurante.email = TBemail.Text;
			restaurante.Endereco = TBendereco.Text;
			restaurante.numero = int.Parse(TBnumero.Text);
			restaurante.Cidade = TBcidade.Text;
			restaurante.Estado = TBestado.Text;
			restaurante.cep = TBcep.Text;


			bool certo = restaurante.CadastrarRestaurante();
			try
			{
				if (certo)
				{
					MessageBox.Show("Restaurante Cadastrado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Cadastrar Restaurante! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}

		}

		public void AtualizarRestaurante()
		{
			Modelos.ClasseRestaurante restaurante = new Modelos.ClasseRestaurante();

			restaurante.id_restaurante = id;
			restaurante.Nome_restaurante = TBrazaosocial.Text;
			restaurante.Nome_fantasia = TBnomefantasia.Text;
			restaurante.CNPJ = TBcnpj.Text;
			restaurante.IE = TBie.Text;
			restaurante.Telefone = TBtelefone.Text;
			restaurante.email = TBemail.Text;
			restaurante.Endereco = TBendereco.Text;
			restaurante.numero = int.Parse(TBnumero.Text);
			restaurante.Cidade = TBcidade.Text;
			restaurante.Estado = TBestado.Text;
			restaurante.cep = TBcep.Text;


			bool certo = restaurante.AtualizarRestaurante();
			try
			{
				if (certo)
				{
					MessageBox.Show("Restaurante Atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Atualizar Restaurante! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}
		}

		public void CarregarDados()
		{
			Modelos.ClasseRestaurante restaurante = new Modelos.ClasseRestaurante();
			restaurante.CarregarPorID(id);
			TBrazaosocial.Text = restaurante.Nome_restaurante;
			TBnomefantasia.Text = restaurante.Nome_fantasia;
			TBcnpj.Text = restaurante.CNPJ;
			TBie.Text = restaurante.IE;
			TBtelefone.Text = restaurante.Telefone.ToString();
			TBemail.Text = restaurante.email;
			TBendereco.Text = restaurante.Endereco;
			TBnumero.Text = restaurante.numero.ToString();
			TBcidade.Text = restaurante.Cidade;
			TBestado.Text = restaurante.Estado;
			TBcep.Text = restaurante.cep.ToString();

		}
	}
}
