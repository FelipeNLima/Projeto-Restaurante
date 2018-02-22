namespace Projeto_Restaurante
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.listViewusuario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBadicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBeditar = new System.Windows.Forms.ToolStripButton();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBdeletar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TBpesquisa = new System.Windows.Forms.TextBox();
            this.BTpesquisa = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewusuario
            // 
            this.listViewusuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewusuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listViewusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewusuario.FullRowSelect = true;
            this.listViewusuario.GridLines = true;
            this.listViewusuario.Location = new System.Drawing.Point(0, 78);
            this.listViewusuario.Name = "listViewusuario";
            this.listViewusuario.Size = new System.Drawing.Size(594, 233);
            this.listViewusuario.TabIndex = 0;
            this.listViewusuario.UseCompatibleStateImageBehavior = false;
            this.listViewusuario.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login";
            this.columnHeader2.Width = 243;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cargo";
            this.columnHeader4.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBadicionar,
            this.toolStripSeparator1,
            this.TSBeditar,
            this.TSBsair,
            this.toolStripSeparator2,
            this.TSBdeletar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 314);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBadicionar
            // 
            this.TSBadicionar.CheckOnClick = true;
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
            // TSBeditar
            // 
            this.TSBeditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBeditar.Image = ((System.Drawing.Image)(resources.GetObject("TSBeditar.Image")));
            this.TSBeditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBeditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBeditar.Name = "TSBeditar";
            this.TSBeditar.Size = new System.Drawing.Size(52, 52);
            this.TSBeditar.Text = "Atualizar";
            this.TSBeditar.Click += new System.EventHandler(this.TSBeditar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Usuario";
            // 
            // TBpesquisa
            // 
            this.TBpesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBpesquisa.Location = new System.Drawing.Point(122, 33);
            this.TBpesquisa.Name = "TBpesquisa";
            this.TBpesquisa.Size = new System.Drawing.Size(365, 20);
            this.TBpesquisa.TabIndex = 3;
            this.TBpesquisa.Tag = "*";
            this.TBpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBpesquisa_KeyPress);
            // 
            // BTpesquisa
            // 
            this.BTpesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.BTpesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTpesquisa.Image = ((System.Drawing.Image)(resources.GetObject("BTpesquisa.Image")));
            this.BTpesquisa.Location = new System.Drawing.Point(507, 12);
            this.BTpesquisa.Name = "BTpesquisa";
            this.BTpesquisa.Size = new System.Drawing.Size(75, 60);
            this.BTpesquisa.TabIndex = 4;
            this.BTpesquisa.UseVisualStyleBackColor = false;
            this.BTpesquisa.Click += new System.EventHandler(this.BTpesquisa_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 369);
            this.ControlBox = false;
            this.Controls.Add(this.BTpesquisa);
            this.Controls.Add(this.TBpesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listViewusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewusuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBadicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBdeletar;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBpesquisa;
        private System.Windows.Forms.Button BTpesquisa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBeditar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}