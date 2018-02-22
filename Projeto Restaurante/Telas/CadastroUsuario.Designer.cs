namespace Projeto_Restaurante
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBcadastrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBcargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBlogin = new System.Windows.Forms.TextBox();
            this.TBsenha = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // TBnome
            // 
            this.TBnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TBnome.Location = new System.Drawing.Point(53, 22);
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(343, 20);
            this.TBnome.TabIndex = 1;
            this.TBnome.Tag = "*";
            this.TBnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnome_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBcadastrar,
            this.toolStripSeparator1,
            this.TSBsair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 183);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(416, 55);
            this.toolStrip1.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // CBcargo
            // 
            this.CBcargo.FormattingEnabled = true;
            this.CBcargo.Location = new System.Drawing.Point(53, 140);
            this.CBcargo.Name = "CBcargo";
            this.CBcargo.Size = new System.Drawing.Size(343, 21);
            this.CBcargo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cargo";
            // 
            // TBlogin
            // 
            this.TBlogin.Location = new System.Drawing.Point(53, 60);
            this.TBlogin.Name = "TBlogin";
            this.TBlogin.Size = new System.Drawing.Size(343, 20);
            this.TBlogin.TabIndex = 9;
            this.TBlogin.Tag = "*";
            // 
            // TBsenha
            // 
            this.TBsenha.Location = new System.Drawing.Point(55, 102);
            this.TBsenha.Name = "TBsenha";
            this.TBsenha.Size = new System.Drawing.Size(341, 20);
            this.TBsenha.TabIndex = 10;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 238);
            this.ControlBox = false;
            this.Controls.Add(this.TBsenha);
            this.Controls.Add(this.TBlogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBcargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TBnome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.Text = "Cadastrar Usuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBcadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBcargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBlogin;
        private System.Windows.Forms.TextBox TBsenha;
    }
}