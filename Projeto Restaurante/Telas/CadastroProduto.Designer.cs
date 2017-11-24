namespace Projeto_Restaurante
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.TBnomeproduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBestoqueatual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBestoqueminimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBcategoria = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBadicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.TBprecocusto = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // TBnomeproduto
            // 
            this.TBnomeproduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBnomeproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnomeproduto.Location = new System.Drawing.Point(129, 27);
            this.TBnomeproduto.Margin = new System.Windows.Forms.Padding(4);
            this.TBnomeproduto.Name = "TBnomeproduto";
            this.TBnomeproduto.Size = new System.Drawing.Size(588, 23);
            this.TBnomeproduto.TabIndex = 1;
            this.TBnomeproduto.Tag = "*";
            this.TBnomeproduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomeproduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço de Custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // TBestoqueatual
            // 
            this.TBestoqueatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBestoqueatual.Location = new System.Drawing.Point(129, 169);
            this.TBestoqueatual.Margin = new System.Windows.Forms.Padding(4);
            this.TBestoqueatual.Name = "TBestoqueatual";
            this.TBestoqueatual.Size = new System.Drawing.Size(201, 23);
            this.TBestoqueatual.TabIndex = 11;
            this.TBestoqueatual.Tag = "*";
            this.TBestoqueatual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBestoqueatual_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estoque Atual";
            // 
            // TBestoqueminimo
            // 
            this.TBestoqueminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBestoqueminimo.Location = new System.Drawing.Point(509, 170);
            this.TBestoqueminimo.Margin = new System.Windows.Forms.Padding(4);
            this.TBestoqueminimo.Name = "TBestoqueminimo";
            this.TBestoqueminimo.Size = new System.Drawing.Size(211, 23);
            this.TBestoqueminimo.TabIndex = 13;
            this.TBestoqueminimo.Tag = "*";
            this.TBestoqueminimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBestoqueminimo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estoque Minimo";
            // 
            // CBcategoria
            // 
            this.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcategoria.FormattingEnabled = true;
            this.CBcategoria.Location = new System.Drawing.Point(509, 101);
            this.CBcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.CBcategoria.Name = "CBcategoria";
            this.CBcategoria.Size = new System.Drawing.Size(208, 24);
            this.CBcategoria.TabIndex = 14;
            this.CBcategoria.Tag = "*";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBadicionar,
            this.toolStripSeparator1,
            this.TSBsair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 216);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 55);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBadicionar
            // 
            this.TSBadicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBadicionar.Image = ((System.Drawing.Image)(resources.GetObject("TSBadicionar.Image")));
            this.TSBadicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBadicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBadicionar.Name = "TSBadicionar";
            this.TSBadicionar.Size = new System.Drawing.Size(52, 52);
            this.TSBadicionar.Text = "Cadastrar";
            this.TSBadicionar.Click += new System.EventHandler(this.TSBadicionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
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
            // TBprecocusto
            // 
            this.TBprecocusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBprecocusto.Location = new System.Drawing.Point(129, 101);
            this.TBprecocusto.Margin = new System.Windows.Forms.Padding(4);
            this.TBprecocusto.Name = "TBprecocusto";
            this.TBprecocusto.Size = new System.Drawing.Size(201, 23);
            this.TBprecocusto.TabIndex = 18;
            this.TBprecocusto.Tag = "*";
            this.TBprecocusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBprecocusto_KeyPress);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 271);
            this.ControlBox = false;
            this.Controls.Add(this.TBprecocusto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CBcategoria);
            this.Controls.Add(this.TBestoqueminimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBestoqueatual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBnomeproduto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBnomeproduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBestoqueatual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBestoqueminimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBcategoria;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBadicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.TextBox TBprecocusto;
    }
}