namespace Projeto_Restaurante.Telas
{
    partial class CadastrarCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCategorias));
			this.TBdescricao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.TSBcadastrar = new System.Windows.Forms.ToolStripButton();
			this.TSBsair = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TBdescricao
			// 
			this.TBdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TBdescricao.Location = new System.Drawing.Point(165, 32);
			this.TBdescricao.Name = "TBdescricao";
			this.TBdescricao.Size = new System.Drawing.Size(320, 20);
			this.TBdescricao.TabIndex = 11;
			this.TBdescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdescricao_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nome da Categoria";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBcadastrar,
            this.TSBsair,
            this.toolStripSeparator1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 82);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(497, 55);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// TSBcadastrar
			// 
			this.TSBcadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSBcadastrar.Image = ((System.Drawing.Image)(resources.GetObject("TSBcadastrar.Image")));
			this.TSBcadastrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.TSBcadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBcadastrar.Name = "TSBcadastrar";
			this.TSBcadastrar.Size = new System.Drawing.Size(52, 52);
			this.TSBcadastrar.Text = "Cadastrar";
			this.TSBcadastrar.Click += new System.EventHandler(this.TSBcadastrar_Click);
			// 
			// TSBsair
			// 
			this.TSBsair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.TSBsair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSBsair.Image = ((System.Drawing.Image)(resources.GetObject("TSBsair.Image")));
			this.TSBsair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.TSBsair.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBsair.Name = "TSBsair";
			this.TSBsair.Size = new System.Drawing.Size(52, 52);
			this.TSBsair.Text = "Sair";
			this.TSBsair.Click += new System.EventHandler(this.TSBsair_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
			// 
			// CadastrarCategorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 137);
			this.ControlBox = false;
			this.Controls.Add(this.TBdescricao);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadastrarCategorias";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastrar Categorias";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBcadastrar;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}