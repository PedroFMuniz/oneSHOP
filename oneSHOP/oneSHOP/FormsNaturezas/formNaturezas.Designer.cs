namespace oneSHOP.FormsNaturezas
{
    partial class formNaturezas
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
            this.txtPesquisaNatureza = new System.Windows.Forms.TextBox();
            this.listNatureza = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaNaturezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirNaturezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pesquisa";
            // 
            // txtPesquisaNatureza
            // 
            this.txtPesquisaNatureza.Location = new System.Drawing.Point(547, 119);
            this.txtPesquisaNatureza.Name = "txtPesquisaNatureza";
            this.txtPesquisaNatureza.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaNatureza.TabIndex = 7;
            // 
            // listNatureza
            // 
            this.listNatureza.HideSelection = false;
            this.listNatureza.Location = new System.Drawing.Point(12, 150);
            this.listNatureza.Name = "listNatureza";
            this.listNatureza.Size = new System.Drawing.Size(776, 288);
            this.listNatureza.TabIndex = 6;
            this.listNatureza.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaNaturezaToolStripMenuItem,
            this.excluirNaturezaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaNaturezaToolStripMenuItem
            // 
            this.novaNaturezaToolStripMenuItem.Name = "novaNaturezaToolStripMenuItem";
            this.novaNaturezaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.novaNaturezaToolStripMenuItem.Text = "Nova Natureza";
            // 
            // excluirNaturezaToolStripMenuItem
            // 
            this.excluirNaturezaToolStripMenuItem.Name = "excluirNaturezaToolStripMenuItem";
            this.excluirNaturezaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.excluirNaturezaToolStripMenuItem.Text = "Excluir Natureza";
            // 
            // formNaturezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaNatureza);
            this.Controls.Add(this.listNatureza);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formNaturezas";
            this.Text = "Naturezas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaNatureza;
        private System.Windows.Forms.ListView listNatureza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaNaturezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirNaturezaToolStripMenuItem;
    }
}