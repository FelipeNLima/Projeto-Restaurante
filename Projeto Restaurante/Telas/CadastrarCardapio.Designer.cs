namespace Projeto_Restaurante.Telas
{
    partial class CadastrarCardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCardapio));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBcadastrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TBnomeprato = new System.Windows.Forms.TextBox();
            this.TBvalorprato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBcategoriaprato = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBcadastrar,
            this.toolStripSeparator1,
            this.TSBsair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 139);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(512, 55);
            this.toolStrip1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Prato";
            // 
            // TBnomeprato
            // 
            this.TBnomeprato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBnomeprato.Location = new System.Drawing.Point(133, 17);
            this.TBnomeprato.Name = "TBnomeprato";
            this.TBnomeprato.Size = new System.Drawing.Size(363, 20);
            this.TBnomeprato.TabIndex = 2;
            this.TBnomeprato.Tag = "*";
            this.TBnomeprato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnomeprato_KeyPress);
            // 
            // TBvalorprato
            // 
            this.TBvalorprato.Location = new System.Drawing.Point(133, 61);
            this.TBvalorprato.Name = "TBvalorprato";
            this.TBvalorprato.Size = new System.Drawing.Size(201, 20);
            this.TBvalorprato.TabIndex = 4;
            this.TBvalorprato.Tag = "*";
            this.TBvalorprato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBvalorprato_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor do Prato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria Prato";
            // 
            // CBcategoriaprato
            // 
            this.CBcategoriaprato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcategoriaprato.FormattingEnabled = true;
            this.CBcategoriaprato.Location = new System.Drawing.Point(133, 103);
            this.CBcategoriaprato.Name = "CBcategoriaprato";
            this.CBcategoriaprato.Size = new System.Drawing.Size(201, 21);
            this.CBcategoriaprato.TabIndex = 6;
            // 
            // CadastrarCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 194);
            this.ControlBox = false;
            this.Controls.Add(this.CBcategoriaprato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBvalorprato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBnomeprato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCardapio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cardápio";
            this.Load += new System.EventHandler(this.CadastrarCardapio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBcadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBnomeprato;
        private System.Windows.Forms.TextBox TBvalorprato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBcategoriaprato;
    }
}