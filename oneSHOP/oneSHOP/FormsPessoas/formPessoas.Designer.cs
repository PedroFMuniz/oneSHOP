namespace oneSHOP
{
    partial class formPessoas
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
            this.listPessoa = new System.Windows.Forms.ListView();
            this.txtPesquisaPessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPessoa
            // 
            this.listPessoa.HideSelection = false;
            this.listPessoa.Location = new System.Drawing.Point(12, 150);
            this.listPessoa.Name = "listPessoa";
            this.listPessoa.Size = new System.Drawing.Size(776, 288);
            this.listPessoa.TabIndex = 0;
            this.listPessoa.UseCompatibleStateImageBehavior = false;
            // 
            // txtPesquisaPessoa
            // 
            this.txtPesquisaPessoa.Location = new System.Drawing.Point(547, 119);
            this.txtPesquisaPessoa.Name = "txtPesquisaPessoa";
            this.txtPesquisaPessoa.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaPessoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPessoaToolStripMenuItem,
            this.excluirPessoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaPessoaToolStripMenuItem
            // 
            this.novaPessoaToolStripMenuItem.Name = "novaPessoaToolStripMenuItem";
            this.novaPessoaToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.novaPessoaToolStripMenuItem.Text = "Nova Pessoa";
            // 
            // excluirPessoaToolStripMenuItem
            // 
            this.excluirPessoaToolStripMenuItem.Name = "excluirPessoaToolStripMenuItem";
            this.excluirPessoaToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.excluirPessoaToolStripMenuItem.Text = "Excluir Pessoa";
            // 
            // formPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaPessoa);
            this.Controls.Add(this.listPessoa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPessoas";
            this.Text = "Pessoas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPessoa;
        private System.Windows.Forms.TextBox txtPesquisaPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirPessoaToolStripMenuItem;
    }
}