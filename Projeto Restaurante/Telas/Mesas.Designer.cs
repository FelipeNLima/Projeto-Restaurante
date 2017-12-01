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
            this.BTTransferirMesa = new System.Windows.Forms.Button();
            this.BTmenuprincipal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
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
            // BTTransferirMesa
            // 
            this.BTTransferirMesa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTTransferirMesa.Location = new System.Drawing.Point(115, 3);
            this.BTTransferirMesa.Name = "BTTransferirMesa";
            this.BTTransferirMesa.Size = new System.Drawing.Size(81, 55);
            this.BTTransferirMesa.TabIndex = 0;
            this.BTTransferirMesa.Text = "Transferencia de Mesa   (F8) ";
            this.BTTransferirMesa.UseVisualStyleBackColor = true;
            this.BTTransferirMesa.Click += new System.EventHandler(this.BTTransferirMesa_Click);
            // 
            // BTmenuprincipal
            // 
            this.BTmenuprincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTmenuprincipal.Location = new System.Drawing.Point(12, 3);
            this.BTmenuprincipal.Name = "BTmenuprincipal";
            this.BTmenuprincipal.Size = new System.Drawing.Size(81, 55);
            this.BTmenuprincipal.TabIndex = 2;
            this.BTmenuprincipal.Text = "Menu Principal   (F7) ";
            this.BTmenuprincipal.UseVisualStyleBackColor = true;
            this.BTmenuprincipal.Click += new System.EventHandler(this.BTmenuprincipal_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.BTmenuprincipal);
            this.panel2.Controls.Add(this.BTTransferirMesa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 61);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 431);
            this.panel1.TabIndex = 13;
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 492);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mesas_KeyDown);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList Imagem;
        private System.Windows.Forms.Button BTmenuprincipal;
        private System.Windows.Forms.Button BTTransferirMesa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
	}
}