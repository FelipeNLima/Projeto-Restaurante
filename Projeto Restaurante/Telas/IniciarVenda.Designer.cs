namespace Projeto_Restaurante.Telas
{
	partial class IniciarVenda
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
            this.TBnumerogarçom = new System.Windows.Forms.TextBox();
            this.TBnumeropessoas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBnumeroMesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTabrir = new System.Windows.Forms.Button();
            this.BTsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Garçom";
            // 
            // TBnumerogarçom
            // 
            this.TBnumerogarçom.Location = new System.Drawing.Point(143, 59);
            this.TBnumerogarçom.Name = "TBnumerogarçom";
            this.TBnumerogarçom.Size = new System.Drawing.Size(116, 20);
            this.TBnumerogarçom.TabIndex = 1;
            this.TBnumerogarçom.Tag = "*";
            // 
            // TBnumeropessoas
            // 
            this.TBnumeropessoas.Location = new System.Drawing.Point(143, 100);
            this.TBnumeropessoas.Name = "TBnumeropessoas";
            this.TBnumeropessoas.Size = new System.Drawing.Size(116, 20);
            this.TBnumeropessoas.TabIndex = 3;
            this.TBnumeropessoas.Tag = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Pessoas";
            // 
            // TBnumeroMesa
            // 
            this.TBnumeroMesa.Location = new System.Drawing.Point(143, 22);
            this.TBnumeroMesa.Name = "TBnumeroMesa";
            this.TBnumeroMesa.Size = new System.Drawing.Size(116, 20);
            this.TBnumeroMesa.TabIndex = 5;
            this.TBnumeroMesa.Tag = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero da Mesa";
            // 
            // BTabrir
            // 
            this.BTabrir.Location = new System.Drawing.Point(14, 135);
            this.BTabrir.Name = "BTabrir";
            this.BTabrir.Size = new System.Drawing.Size(87, 23);
            this.BTabrir.TabIndex = 6;
            this.BTabrir.Text = "Abrir";
            this.BTabrir.UseVisualStyleBackColor = true;
            this.BTabrir.Click += new System.EventHandler(this.BTabrir_Click);
            // 
            // BTsair
            // 
            this.BTsair.Location = new System.Drawing.Point(172, 135);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(87, 23);
            this.BTsair.TabIndex = 7;
            this.BTsair.Text = "Sair";
            this.BTsair.UseVisualStyleBackColor = true;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // IniciarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 179);
            this.ControlBox = false;
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.BTabrir);
            this.Controls.Add(this.TBnumeroMesa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBnumeropessoas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBnumerogarçom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "IniciarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "*";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IniciarVenda_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TBnumerogarçom;
		private System.Windows.Forms.TextBox TBnumeropessoas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TBnumeroMesa;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button BTabrir;
		private System.Windows.Forms.Button BTsair;
	}
}