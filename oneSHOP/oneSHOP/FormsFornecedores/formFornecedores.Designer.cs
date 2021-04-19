namespace oneSHOP
{
    partial class formFornecedores
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
            this.txtPesquisaFornecedor = new System.Windows.Forms.TextBox();
            this.listFornecedor = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // txtPesquisaFornecedor
            // 
            this.txtPesquisaFornecedor.Location = new System.Drawing.Point(547, 119);
            this.txtPesquisaFornecedor.Name = "txtPesquisaFornecedor";
            this.txtPesquisaFornecedor.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaFornecedor.TabIndex = 4;
            // 
            // listFornecedor
            // 
            this.listFornecedor.HideSelection = false;
            this.listFornecedor.Location = new System.Drawing.Point(12, 150);
            this.listFornecedor.Name = "listFornecedor";
            this.listFornecedor.Size = new System.Drawing.Size(776, 288);
            this.listFornecedor.TabIndex = 3;
            this.listFornecedor.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFornecedorToolStripMenuItem,
            this.editarFornecedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoFornecedorToolStripMenuItem
            // 
            this.novoFornecedorToolStripMenuItem.Name = "novoFornecedorToolStripMenuItem";
            this.novoFornecedorToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.novoFornecedorToolStripMenuItem.Text = "Novo Fornecedor";
            // 
            // editarFornecedorToolStripMenuItem
            // 
            this.editarFornecedorToolStripMenuItem.Name = "editarFornecedorToolStripMenuItem";
            this.editarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.editarFornecedorToolStripMenuItem.Text = "Excluir Fornecedor";
            // 
            // formFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaFornecedor);
            this.Controls.Add(this.listFornecedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formFornecedores";
            this.Text = "Fornecedores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaFornecedor;
        private System.Windows.Forms.ListView listFornecedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFornecedorToolStripMenuItem;
    }
}