namespace Projeto_Restaurante.Telas
{
    partial class Mesas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesas));
            this.Imagem = new System.Windows.Forms.ImageList(this.components);
            this.timerAtualizandoMesa = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTmenuprincipal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTTransferirMesa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTcouvertArtistico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBCalculadora = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Imagem
            // 
            this.Imagem.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagem.ImageStream")));
            this.Imagem.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagem.Images.SetKeyName(0, "testemesa.png");
            this.Imagem.Images.SetKeyName(1, "testemesa.png");
            this.Imagem.Images.SetKeyName(2, "testemesa.png");
            // 
            // timerAtualizandoMesa
            // 
            this.timerAtualizandoMesa.Enabled = true;
            this.timerAtualizandoMesa.Interval = 30000;
            this.timerAtualizandoMesa.Tick += new System.EventHandler(this.timerAtualizandoMesa_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 458);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 34);
            this.panel2.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTmenuprincipal,
            this.toolStripSeparator1,
            this.BTTransferirMesa,
            this.toolStripSeparator2,
            this.BTcouvertArtistico,
            this.toolStripSeparator3,
            this.TSBCalculadora});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTmenuprincipal
            // 
            this.BTmenuprincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BTmenuprincipal.Image = ((System.Drawing.Image)(resources.GetObject("BTmenuprincipal.Image")));
            this.BTmenuprincipal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTmenuprincipal.Name = "BTmenuprincipal";
            this.BTmenuprincipal.Size = new System.Drawing.Size(118, 28);
            this.BTmenuprincipal.Text = "Voltar Principal";
            this.BTmenuprincipal.Click += new System.EventHandler(this.BTmenuprincipal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BTTransferirMesa
            // 
            this.BTTransferirMesa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BTTransferirMesa.Image = ((System.Drawing.Image)(resources.GetObject("BTTransferirMesa.Image")));
            this.BTTransferirMesa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTTransferirMesa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTTransferirMesa.Name = "BTTransferirMesa";
            this.BTTransferirMesa.Size = new System.Drawing.Size(121, 28);
            this.BTTransferirMesa.Text = "Transferir Mesa";
            this.BTTransferirMesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTTransferirMesa.ToolTipText = "Transferencia de Mesa   (F8) \r\n";
            this.BTTransferirMesa.Click += new System.EventHandler(this.BTTransferirMesa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BTcouvertArtistico
            // 
            this.BTcouvertArtistico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BTcouvertArtistico.Image = ((System.Drawing.Image)(resources.GetObject("BTcouvertArtistico.Image")));
            this.BTcouvertArtistico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTcouvertArtistico.Name = "BTcouvertArtistico";
            this.BTcouvertArtistico.Size = new System.Drawing.Size(130, 28);
            this.BTcouvertArtistico.Text = "Couvert Artistico";
            this.BTcouvertArtistico.Click += new System.EventHandler(this.BTcouvertArtistico_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // TSBCalculadora
            // 
            this.TSBCalculadora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSBCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("TSBCalculadora.Image")));
            this.TSBCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCalculadora.Name = "TSBCalculadora";
            this.TSBCalculadora.Size = new System.Drawing.Size(98, 28);
            this.TSBCalculadora.Text = "Calculadora";
            this.TSBCalculadora.Click += new System.EventHandler(this.TSBCalculadora_Click);
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 492);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mesas_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList Imagem;
        private System.Windows.Forms.Timer timerAtualizandoMesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTTransferirMesa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTmenuprincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTcouvertArtistico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBCalculadora;
    }
}