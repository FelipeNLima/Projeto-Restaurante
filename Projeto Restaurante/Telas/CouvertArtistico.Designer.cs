namespace Projeto_Restaurante.Telas
{
    partial class CouvertArtistico
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
            this.BTsalvar = new System.Windows.Forms.Button();
            this.BTsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTsalvar
            // 
            this.BTsalvar.Location = new System.Drawing.Point(12, 62);
            this.BTsalvar.Name = "BTsalvar";
            this.BTsalvar.Size = new System.Drawing.Size(75, 23);
            this.BTsalvar.TabIndex = 0;
            this.BTsalvar.Text = "Salvar";
            this.BTsalvar.UseVisualStyleBackColor = true;
            this.BTsalvar.Click += new System.EventHandler(this.BTsalvar_Click);
            // 
            // BTsair
            // 
            this.BTsair.Location = new System.Drawing.Point(114, 61);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(75, 23);
            this.BTsair.TabIndex = 1;
            this.BTsair.Text = "Sair";
            this.BTsair.UseVisualStyleBackColor = true;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor";
            // 
            // TBvalor
            // 
            this.TBvalor.Location = new System.Drawing.Point(54, 22);
            this.TBvalor.Name = "TBvalor";
            this.TBvalor.Size = new System.Drawing.Size(135, 20);
            this.TBvalor.TabIndex = 3;
            // 
            // CouvertArtistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 96);
            this.ControlBox = false;
            this.Controls.Add(this.TBvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.BTsalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CouvertArtistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Couvert Artistico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTsalvar;
        private System.Windows.Forms.Button BTsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBvalor;
    }
}