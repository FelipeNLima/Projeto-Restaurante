namespace Projeto_Restaurante.Telas
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBcaixa = new System.Windows.Forms.ToolStripButton();
            this.TSBsair = new System.Windows.Forms.ToolStripButton();
            this.data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBvalor = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBcaixa,
            this.TSBsair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 96);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(238, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBcaixa
            // 
            this.TSBcaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBcaixa.Image = ((System.Drawing.Image)(resources.GetObject("TSBcaixa.Image")));
            this.TSBcaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBcaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBcaixa.Name = "TSBcaixa";
            this.TSBcaixa.Size = new System.Drawing.Size(52, 52);
            this.TSBcaixa.Text = "OK";
            this.TSBcaixa.Click += new System.EventHandler(this.TSBcaixa_Click);
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
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(13, 13);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(52, 17);
            this.data.TabIndex = 1;
            this.data.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor";
            // 
            // TBvalor
            // 
            this.TBvalor.Location = new System.Drawing.Point(65, 49);
            this.TBvalor.Name = "TBvalor";
            this.TBvalor.Size = new System.Drawing.Size(161, 20);
            this.TBvalor.TabIndex = 3;
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 151);
            this.ControlBox = false;
            this.Controls.Add(this.TBvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBcaixa;
        private System.Windows.Forms.ToolStripButton TSBsair;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBvalor;
        private System.Windows.Forms.Timer timer1;
    }
}