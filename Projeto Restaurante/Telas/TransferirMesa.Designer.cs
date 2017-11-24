namespace Projeto_Restaurante.Telas
{
    partial class TransferirMesa
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBmesaatual = new System.Windows.Forms.TextBox();
            this.TBmesanova = new System.Windows.Forms.TextBox();
            this.BTsalvar = new System.Windows.Forms.Button();
            this.BTsair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa Atual";
            // 
            // TBmesaatual
            // 
            this.TBmesaatual.Location = new System.Drawing.Point(80, 12);
            this.TBmesaatual.Name = "TBmesaatual";
            this.TBmesaatual.Size = new System.Drawing.Size(100, 20);
            this.TBmesaatual.TabIndex = 1;
            this.TBmesaatual.Tag = "*";
            // 
            // TBmesanova
            // 
            this.TBmesanova.Location = new System.Drawing.Point(80, 46);
            this.TBmesanova.Name = "TBmesanova";
            this.TBmesanova.Size = new System.Drawing.Size(100, 20);
            this.TBmesanova.TabIndex = 2;
            this.TBmesanova.Tag = "*";
            // 
            // BTsalvar
            // 
            this.BTsalvar.Location = new System.Drawing.Point(6, 89);
            this.BTsalvar.Name = "BTsalvar";
            this.BTsalvar.Size = new System.Drawing.Size(75, 23);
            this.BTsalvar.TabIndex = 3;
            this.BTsalvar.Text = "Salvar";
            this.BTsalvar.UseVisualStyleBackColor = true;
            this.BTsalvar.Click += new System.EventHandler(this.BTsalvar_Click);
            // 
            // BTsair
            // 
            this.BTsair.Location = new System.Drawing.Point(101, 89);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(75, 23);
            this.BTsair.TabIndex = 4;
            this.BTsair.Text = "Sair";
            this.BTsair.UseVisualStyleBackColor = true;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesa Nova";
            // 
            // TransferirMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(188, 122);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.BTsalvar);
            this.Controls.Add(this.TBmesanova);
            this.Controls.Add(this.TBmesaatual);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransferirMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.Text = "Transferir Mesa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBmesaatual;
        private System.Windows.Forms.TextBox TBmesanova;
        private System.Windows.Forms.Button BTsalvar;
        private System.Windows.Forms.Button BTsair;
        private System.Windows.Forms.Label label2;
    }
}