namespace Projeto_Restaurante.Telas
{
    partial class Pagamento
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
            this.TBvalortotal = new System.Windows.Forms.TextBox();
            this.TBsubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBvalorRecebido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBopcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBtroco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTok = new System.Windows.Forms.Button();
            this.BTsair = new System.Windows.Forms.Button();
            this.LVbandeiracartao = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.CBformapagamento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total";
            // 
            // TBvalortotal
            // 
            this.TBvalortotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBvalortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBvalortotal.Location = new System.Drawing.Point(17, 40);
            this.TBvalortotal.Name = "TBvalortotal";
            this.TBvalortotal.Size = new System.Drawing.Size(330, 29);
            this.TBvalortotal.TabIndex = 1;
            this.TBvalortotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBvalortotal_KeyPress);
            // 
            // TBsubtotal
            // 
            this.TBsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsubtotal.Location = new System.Drawing.Point(397, 40);
            this.TBsubtotal.Name = "TBsubtotal";
            this.TBsubtotal.Size = new System.Drawing.Size(166, 29);
            this.TBsubtotal.TabIndex = 3;
            this.TBsubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBsubtotal_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "SubTotal";
            // 
            // TBvalorRecebido
            // 
            this.TBvalorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBvalorRecebido.Location = new System.Drawing.Point(89, 181);
            this.TBvalorRecebido.Name = "TBvalorRecebido";
            this.TBvalorRecebido.Size = new System.Drawing.Size(258, 29);
            this.TBvalorRecebido.TabIndex = 5;
            this.TBvalorRecebido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBvalorRecebido_KeyDown);
            this.TBvalorRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBvalorRecebido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Recebido";
            // 
            // TBopcao
            // 
            this.TBopcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBopcao.Location = new System.Drawing.Point(17, 181);
            this.TBopcao.Name = "TBopcao";
            this.TBopcao.Size = new System.Drawing.Size(66, 29);
            this.TBopcao.TabIndex = 7;
            this.TBopcao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBopcao_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opção";
            // 
            // TBtroco
            // 
            this.TBtroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtroco.Location = new System.Drawing.Point(397, 106);
            this.TBtroco.Name = "TBtroco";
            this.TBtroco.Size = new System.Drawing.Size(166, 29);
            this.TBtroco.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Troco";
            // 
            // BTok
            // 
            this.BTok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTok.Location = new System.Drawing.Point(397, 152);
            this.BTok.Name = "BTok";
            this.BTok.Size = new System.Drawing.Size(75, 29);
            this.BTok.TabIndex = 11;
            this.BTok.Text = "OK";
            this.BTok.UseVisualStyleBackColor = true;
            this.BTok.Click += new System.EventHandler(this.BTok_Click);
            // 
            // BTsair
            // 
            this.BTsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTsair.Location = new System.Drawing.Point(488, 152);
            this.BTsair.Name = "BTsair";
            this.BTsair.Size = new System.Drawing.Size(75, 29);
            this.BTsair.TabIndex = 12;
            this.BTsair.Text = "Sair";
            this.BTsair.UseVisualStyleBackColor = true;
            this.BTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // LVbandeiracartao
            // 
            this.LVbandeiracartao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LVbandeiracartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVbandeiracartao.GridLines = true;
            this.LVbandeiracartao.Location = new System.Drawing.Point(12, 216);
            this.LVbandeiracartao.Name = "LVbandeiracartao";
            this.LVbandeiracartao.Size = new System.Drawing.Size(335, 315);
            this.LVbandeiracartao.TabIndex = 13;
            this.LVbandeiracartao.UseCompatibleStateImageBehavior = false;
            this.LVbandeiracartao.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bandeira do Cartão";
            this.columnHeader2.Width = 232;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Forma de Pagamento";
            // 
            // CBformapagamento
            // 
            this.CBformapagamento.BackColor = System.Drawing.SystemColors.Window;
            this.CBformapagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBformapagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBformapagamento.FormattingEnabled = true;
            this.CBformapagamento.Location = new System.Drawing.Point(17, 103);
            this.CBformapagamento.Name = "CBformapagamento";
            this.CBformapagamento.Size = new System.Drawing.Size(330, 32);
            this.CBformapagamento.TabIndex = 15;
            this.CBformapagamento.SelectedIndexChanged += new System.EventHandler(this.CBformapagamento_SelectedIndexChanged);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 543);
            this.ControlBox = false;
            this.Controls.Add(this.CBformapagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LVbandeiracartao);
            this.Controls.Add(this.BTsair);
            this.Controls.Add(this.BTok);
            this.Controls.Add(this.TBtroco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBopcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBvalorRecebido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBsubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBvalortotal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pagamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pagamento_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBvalortotal;
        private System.Windows.Forms.TextBox TBsubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBvalorRecebido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBopcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBtroco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTok;
        private System.Windows.Forms.Button BTsair;
        private System.Windows.Forms.ListView LVbandeiracartao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBformapagamento;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}