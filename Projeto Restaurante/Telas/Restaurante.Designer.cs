namespace Projeto_Restaurante.Telas
{
    partial class Restaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurante));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBadicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBatualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBdeletar = new System.Windows.Forms.ToolStripButton();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BTpesquisa = new System.Windows.Forms.Button();
            this.TBpesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LVrestaurante = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBadicionar,
            this.toolStripSeparator1,
            this.TSBatualizar,
            this.toolStripSeparator2,
            this.TSBdeletar,
            this.TSBsair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 234);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(726, 55);
            this.toolStrip1.TabIndex = 16;
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
            this.TSBadicionar.Text = "Adicionar";
            this.TSBadicionar.Click += new System.EventHandler(this.TSBadicionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // TSBatualizar
            // 
            this.TSBatualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBatualizar.Image = ((System.Drawing.Image)(resources.GetObject("TSBatualizar.Image")));
            this.TSBatualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBatualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBatualizar.Name = "TSBatualizar";
            this.TSBatualizar.Size = new System.Drawing.Size(52, 52);
            this.TSBatualizar.Text = "Atualizar";
            this.TSBatualizar.Click += new System.EventHandler(this.TSBatualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // TSBdeletar
            // 
            this.TSBdeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBdeletar.Image = ((System.Drawing.Image)(resources.GetObject("TSBdeletar.Image")));
            this.TSBdeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBdeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBdeletar.Name = "TSBdeletar";
            this.TSBdeletar.Size = new System.Drawing.Size(52, 52);
            this.TSBdeletar.Text = "Deletar";
            this.TSBdeletar.Click += new System.EventHandler(this.TSBdeletar_Click);
            // 
            // TSBsair
            // 
            this.TSBsair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBsair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBsair.Image = ((System.Drawing.Image)(resources.GetObject("TSBsair.Image")));
            this.TSBsair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBsair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBsair.Name = "TSBsair";
            this.TSBsair.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TSBsair.Size = new System.Drawing.Size(52, 52);
            this.TSBsair.Text = "Sair";
            this.TSBsair.Click += new System.EventHandler(this.TSBsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-146, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome da Bandeira";
            // 
            // BTpesquisa
            // 
            this.BTpesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.BTpesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("BTpesquisa.Image")));
            this.BTpesquisa.Location = new System.Drawing.Point(639, 7);
            this.BTpesquisa.Name = "BTpesquisa";
            this.BTpesquisa.Size = new System.Drawing.Size(75, 60);
            this.BTpesquisa.TabIndex = 19;
            this.BTpesquisa.UseVisualStyleBackColor = false;
            this.BTpesquisa.Click += new System.EventHandler(this.BTpesquisa_Click);
            // 
            // TBpesquisa
            // 
            this.TBpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBpesquisa.Location = new System.Drawing.Point(272, 28);
            this.TBpesquisa.Name = "TBpesquisa";
            this.TBpesquisa.Size = new System.Drawing.Size(361, 20);
            this.TBpesquisa.TabIndex = 18;
            this.TBpesquisa.Tag = "*";
            this.TBpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBpesquisa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome do Restaurante";
            // 
            // LVrestaurante
            // 
            this.LVrestaurante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVrestaurante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVrestaurante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.LVrestaurante.FullRowSelect = true;
            this.LVrestaurante.GridLines = true;
            this.LVrestaurante.Location = new System.Drawing.Point(0, 73);
            this.LVrestaurante.Name = "LVrestaurante";
            this.LVrestaurante.Size = new System.Drawing.Size(726, 158);
            this.LVrestaurante.TabIndex = 20;
            this.LVrestaurante.UseCompatibleStateImageBehavior = false;
            this.LVrestaurante.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Razão Social";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome Fantasia";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CNPJ";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "I/E";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefone";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "E-mail";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Endereço";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Numero";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Cidade";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Estado";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "CEP";
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 289);
            this.ControlBox = false;
            this.Controls.Add(this.LVrestaurante);
            this.Controls.Add(this.BTpesquisa);
            this.Controls.Add(this.TBpesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Restaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.Text = "Restaurante";
            this.Load += new System.EventHandler(this.Restaurante_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBadicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBatualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBdeletar;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTpesquisa;
        private System.Windows.Forms.TextBox TBpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LVrestaurante;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}