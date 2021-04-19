namespace oneSHOP.FormsMonetario
{
    partial class formMonetario
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
            this.txtPesquisaMonetario = new System.Windows.Forms.TextBox();
            this.listMonetario = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carteirasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pesquisa";
            // 
            // txtPesquisaMonetario
            // 
            this.txtPesquisaMonetario.Location = new System.Drawing.Point(547, 119);
            this.txtPesquisaMonetario.Name = "txtPesquisaMonetario";
            this.txtPesquisaMonetario.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaMonetario.TabIndex = 10;
            // 
            // listMonetario
            // 
            this.listMonetario.HideSelection = false;
            this.listMonetario.Location = new System.Drawing.Point(12, 150);
            this.listMonetario.Name = "listMonetario";
            this.listMonetario.Size = new System.Drawing.Size(776, 288);
            this.listMonetario.TabIndex = 9;
            this.listMonetario.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteirasToolStripMenuItem,
            this.contasToolStripMenuItem,
            this.naturezasToolStripMenuItem,
            this.cancelarLançamentoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carteirasToolStripMenuItem
            // 
            this.carteirasToolStripMenuItem.Name = "carteirasToolStripMenuItem";
            this.carteirasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.carteirasToolStripMenuItem.Text = "Carteiras";
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // naturezasToolStripMenuItem
            // 
            this.naturezasToolStripMenuItem.Name = "naturezasToolStripMenuItem";
            this.naturezasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.naturezasToolStripMenuItem.Text = "Naturezas";
            // 
            // cancelarLançamentoToolStripMenuItem
            // 
            this.cancelarLançamentoToolStripMenuItem.Name = "cancelarLançamentoToolStripMenuItem";
            this.cancelarLançamentoToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.cancelarLançamentoToolStripMenuItem.Text = "Cancelar Lançamento";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // formMonetario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaMonetario);
            this.Controls.Add(this.listMonetario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMonetario";
            this.Text = "formMonetario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaMonetario;
        private System.Windows.Forms.ListView listMonetario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carteirasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarLançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
    }
}