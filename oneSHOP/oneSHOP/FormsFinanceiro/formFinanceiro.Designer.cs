namespace oneSHOP.FormsFinanceiro
{
    partial class formFinanceiro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvosLancamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarNFCeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarTítuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaFinanceiro = new System.Windows.Forms.TextBox();
            this.listFinanceiro = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.nvosLancamentosToolStripMenuItem,
            this.cancelarLançamentoToolStripMenuItem,
            this.gerarNFCeToolStripMenuItem,
            this.baixarTítuloToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // nvosLancamentosToolStripMenuItem
            // 
            this.nvosLancamentosToolStripMenuItem.Name = "nvosLancamentosToolStripMenuItem";
            this.nvosLancamentosToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.nvosLancamentosToolStripMenuItem.Text = "Novo Lançamento";
            // 
            // cancelarLançamentoToolStripMenuItem
            // 
            this.cancelarLançamentoToolStripMenuItem.Name = "cancelarLançamentoToolStripMenuItem";
            this.cancelarLançamentoToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.cancelarLançamentoToolStripMenuItem.Text = "Cancelar Lançamento";
            // 
            // gerarNFCeToolStripMenuItem
            // 
            this.gerarNFCeToolStripMenuItem.Name = "gerarNFCeToolStripMenuItem";
            this.gerarNFCeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gerarNFCeToolStripMenuItem.Text = "Gerar NFC-e";
            // 
            // baixarTítuloToolStripMenuItem
            // 
            this.baixarTítuloToolStripMenuItem.Name = "baixarTítuloToolStripMenuItem";
            this.baixarTítuloToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.baixarTítuloToolStripMenuItem.Text = "Baixar título";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisa";
            // 
            // txtPesquisaFinanceiro
            // 
            this.txtPesquisaFinanceiro.Location = new System.Drawing.Point(547, 119);
            this.txtPesquisaFinanceiro.Name = "txtPesquisaFinanceiro";
            this.txtPesquisaFinanceiro.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaFinanceiro.TabIndex = 4;
            // 
            // listFinanceiro
            // 
            this.listFinanceiro.HideSelection = false;
            this.listFinanceiro.Location = new System.Drawing.Point(12, 150);
            this.listFinanceiro.Name = "listFinanceiro";
            this.listFinanceiro.Size = new System.Drawing.Size(776, 288);
            this.listFinanceiro.TabIndex = 3;
            this.listFinanceiro.UseCompatibleStateImageBehavior = false;
            // 
            // formFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaFinanceiro);
            this.Controls.Add(this.listFinanceiro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formFinanceiro";
            this.Text = "Financeiro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvosLancamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarLançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNFCeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarTítuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaFinanceiro;
        private System.Windows.Forms.ListView listFinanceiro;
    }
}