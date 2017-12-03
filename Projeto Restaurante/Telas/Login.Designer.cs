namespace Projeto_Restaurante
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BT_logar = new System.Windows.Forms.Button();
            this.BT_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_usuario = new System.Windows.Forms.TextBox();
            this.TB_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT_logar
            // 
            this.BT_logar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_logar.Location = new System.Drawing.Point(80, 116);
            this.BT_logar.Name = "BT_logar";
            this.BT_logar.Size = new System.Drawing.Size(116, 23);
            this.BT_logar.TabIndex = 0;
            this.BT_logar.Text = "Logar";
            this.BT_logar.UseVisualStyleBackColor = true;
            this.BT_logar.Click += new System.EventHandler(this.BT_logar_Click);
            // 
            // BT_sair
            // 
            this.BT_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_sair.Location = new System.Drawing.Point(202, 116);
            this.BT_sair.Name = "BT_sair";
            this.BT_sair.Size = new System.Drawing.Size(115, 23);
            this.BT_sair.TabIndex = 1;
            this.BT_sair.Text = "Sair";
            this.BT_sair.UseVisualStyleBackColor = true;
            this.BT_sair.Click += new System.EventHandler(this.BT_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // TB_usuario
            // 
            this.TB_usuario.Location = new System.Drawing.Point(80, 39);
            this.TB_usuario.Name = "TB_usuario";
            this.TB_usuario.Size = new System.Drawing.Size(237, 20);
            this.TB_usuario.TabIndex = 4;
            this.TB_usuario.Tag = "*";
            // 
            // TB_senha
            // 
            this.TB_senha.Location = new System.Drawing.Point(80, 74);
            this.TB_senha.Name = "TB_senha";
            this.TB_senha.PasswordChar = '*';
            this.TB_senha.Size = new System.Drawing.Size(237, 20);
            this.TB_senha.TabIndex = 5;
            this.TB_senha.Tag = "*";
            this.TB_senha.UseSystemPasswordChar = true;
            this.TB_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_senha_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 178);
            this.Controls.Add(this.TB_senha);
            this.Controls.Add(this.TB_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_sair);
            this.Controls.Add(this.BT_logar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_logar;
        private System.Windows.Forms.Button BT_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_usuario;
        private System.Windows.Forms.TextBox TB_senha;
    }
}