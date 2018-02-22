namespace Projeto_Restaurante.Telas
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBproduto = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBcadastrar = new System.Windows.Forms.ToolStripButton();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.LVestoque = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto";
            // 
            // CBproduto
            // 
            this.CBproduto.FormattingEnabled = true;
            this.CBproduto.Location = new System.Drawing.Point(88, 12);
            this.CBproduto.Name = "CBproduto";
            this.CBproduto.Size = new System.Drawing.Size(496, 21);
            this.CBproduto.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBcadastrar,
            this.TSBsair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 360);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 55);
            this.toolStrip1.TabIndex = 7;
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
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(88, 59);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(196, 20);
            this.quantidade.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data ";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(347, 59);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(237, 20);
            this.data.TabIndex = 12;
            // 
            // LVestoque
            // 
            this.LVestoque.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produto,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6});
            this.LVestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVestoque.GridLines = true;
            this.LVestoque.Location = new System.Drawing.Point(0, 95);
            this.LVestoque.Name = "LVestoque";
            this.LVestoque.Size = new System.Drawing.Size(625, 262);
            this.LVestoque.TabIndex = 17;
            this.LVestoque.UseCompatibleStateImageBehavior = false;
            this.LVestoque.View = System.Windows.Forms.View.Details;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 155;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Esoque Minimo";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Entrada";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantidade Entrada";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Estoque Atual";
            this.columnHeader6.Width = 97;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 415);
            this.ControlBox = false;
            this.Controls.Add(this.LVestoque);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CBproduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque Entrada";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBproduto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBcadastrar;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.ListView LVestoque;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}