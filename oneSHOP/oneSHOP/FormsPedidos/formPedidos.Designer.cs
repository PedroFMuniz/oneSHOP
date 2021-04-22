namespace oneSHOP.FormsPedidos
{
    partial class formPedidos
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
            this.novoMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarMovimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisaMovimento = new System.Windows.Forms.TextBox();
            this.listMovimento = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoMovimentoToolStripMenuItem,
            this.importarXMLToolStripMenuItem,
            this.cancelarMovimentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoMovimentoToolStripMenuItem
            // 
            this.novoMovimentoToolStripMenuItem.Name = "novoMovimentoToolStripMenuItem";
            this.novoMovimentoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.novoMovimentoToolStripMenuItem.Text = "Novo pedido";
            this.novoMovimentoToolStripMenuItem.Click += new System.EventHandler(this.novoMovimentoToolStripMenuItem_Click);
            // 
            // importarXMLToolStripMenuItem
            // 
            this.importarXMLToolStripMenuItem.Name = "importarXMLToolStripMenuItem";
            this.importarXMLToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.importarXMLToolStripMenuItem.Text = "Editar pedido";
            // 
            // cancelarMovimentoToolStripMenuItem
            // 
            this.cancelarMovimentoToolStripMenuItem.Name = "cancelarMovimentoToolStripMenuItem";
            this.cancelarMovimentoToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.cancelarMovimentoToolStripMenuItem.Text = "Cancelar pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pesquisa";
            // 
            // txtPesquisaMovimento
            // 
            this.txtPesquisaMovimento.Location = new System.Drawing.Point(547, 125);
            this.txtPesquisaMovimento.Name = "txtPesquisaMovimento";
            this.txtPesquisaMovimento.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaMovimento.TabIndex = 17;
            // 
            // listMovimento
            // 
            this.listMovimento.HideSelection = false;
            this.listMovimento.Location = new System.Drawing.Point(12, 156);
            this.listMovimento.Name = "listMovimento";
            this.listMovimento.Size = new System.Drawing.Size(776, 288);
            this.listMovimento.TabIndex = 16;
            this.listMovimento.UseCompatibleStateImageBehavior = false;
            // 
            // formPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaMovimento);
            this.Controls.Add(this.listMovimento);
            this.Name = "formPedidos";
            this.Text = "formPedidos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarMovimentoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaMovimento;
        private System.Windows.Forms.ListView listMovimento;
    }
}