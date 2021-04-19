namespace oneSHOP.FormsCarteiras
{
    partial class formCarteiras
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
            this.txtPesquisaCarteiras = new System.Windows.Forms.TextBox();
            this.listCarteiras = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novaCarteiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirCarteiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // txtPesquisaCarteiras
            // 
            this.txtPesquisaCarteiras.Location = new System.Drawing.Point(547, 119);
            this.txtPesquisaCarteiras.Name = "txtPesquisaCarteiras";
            this.txtPesquisaCarteiras.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaCarteiras.TabIndex = 7;
            // 
            // listCarteiras
            // 
            this.listCarteiras.HideSelection = false;
            this.listCarteiras.Location = new System.Drawing.Point(12, 150);
            this.listCarteiras.Name = "listCarteiras";
            this.listCarteiras.Size = new System.Drawing.Size(776, 288);
            this.listCarteiras.TabIndex = 6;
            this.listCarteiras.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaCarteiraToolStripMenuItem,
            this.excluirCarteiraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novaCarteiraToolStripMenuItem
            // 
            this.novaCarteiraToolStripMenuItem.Name = "novaCarteiraToolStripMenuItem";
            this.novaCarteiraToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.novaCarteiraToolStripMenuItem.Text = "Nova Carteira";
            // 
            // excluirCarteiraToolStripMenuItem
            // 
            this.excluirCarteiraToolStripMenuItem.Name = "excluirCarteiraToolStripMenuItem";
            this.excluirCarteiraToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.excluirCarteiraToolStripMenuItem.Text = "Excluir Carteira";
            // 
            // formCarteiras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaCarteiras);
            this.Controls.Add(this.listCarteiras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formCarteiras";
            this.Text = "Carteiras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaCarteiras;
        private System.Windows.Forms.ListView listCarteiras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novaCarteiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirCarteiraToolStripMenuItem;
    }
}