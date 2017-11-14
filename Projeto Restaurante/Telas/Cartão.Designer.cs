namespace Projeto_Restaurante
{
    partial class Cartão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartão));
            this.BTpesquisa = new System.Windows.Forms.Button();
            this.TBpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBadicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBatualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBdeletar = new System.Windows.Forms.ToolStripButton();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.LVbandeira = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTpesquisa
            // 
            this.BTpesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.BTpesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("BTpesquisa.Image")));
            this.BTpesquisa.Location = new System.Drawing.Point(511, 12);
            this.BTpesquisa.Name = "BTpesquisa";
            this.BTpesquisa.Size = new System.Drawing.Size(75, 60);
            this.BTpesquisa.TabIndex = 10;
            this.BTpesquisa.UseVisualStyleBackColor = false;
            this.BTpesquisa.Click += new System.EventHandler(this.BTpesquisa_Click);
            // 
            // TBpesquisa
            // 
            this.TBpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBpesquisa.Location = new System.Drawing.Point(118, 33);
            this.TBpesquisa.Name = "TBpesquisa";
            this.TBpesquisa.Size = new System.Drawing.Size(387, 20);
            this.TBpesquisa.TabIndex = 9;
            this.TBpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBpesquisa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome da Bandeira";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 356);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 55);
            this.toolStrip1.TabIndex = 11;
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
            this.TSBsair.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // LVbandeira
            // 
            this.LVbandeira.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVbandeira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LVbandeira.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LVbandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVbandeira.FullRowSelect = true;
            this.LVbandeira.GridLines = true;
            this.LVbandeira.Location = new System.Drawing.Point(0, 81);
            this.LVbandeira.Name = "LVbandeira";
            this.LVbandeira.Size = new System.Drawing.Size(593, 273);
            this.LVbandeira.TabIndex = 12;
            this.LVbandeira.UseCompatibleStateImageBehavior = false;
            this.LVbandeira.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 192;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Taxa";
            this.columnHeader3.Width = 149;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Forma de Pagamento";
            this.columnHeader4.Width = 187;
            // 
            // Cartão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 411);
            this.ControlBox = false;
            this.Controls.Add(this.LVbandeira);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BTpesquisa);
            this.Controls.Add(this.TBpesquisa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cartão";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartão";
            this.Load += new System.EventHandler(this.Cartão_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTpesquisa;
        private System.Windows.Forms.TextBox TBpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView LVbandeira;
        private System.Windows.Forms.ToolStripButton TSBadicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBatualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBdeletar;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}