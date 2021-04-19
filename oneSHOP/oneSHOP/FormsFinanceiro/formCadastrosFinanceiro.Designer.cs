namespace oneSHOP.FormsFinanceiro
{
    partial class formCadastrosFinanceiro
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
            this.btnContas = new System.Windows.Forms.Button();
            this.btnCarteiras = new System.Windows.Forms.Button();
            this.btnNaturezas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContas
            // 
            this.btnContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContas.Location = new System.Drawing.Point(498, 56);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(237, 74);
            this.btnContas.TabIndex = 5;
            this.btnContas.Text = "Contas";
            this.btnContas.UseVisualStyleBackColor = true;
            // 
            // btnCarteiras
            // 
            this.btnCarteiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarteiras.Location = new System.Drawing.Point(255, 56);
            this.btnCarteiras.Name = "btnCarteiras";
            this.btnCarteiras.Size = new System.Drawing.Size(237, 74);
            this.btnCarteiras.TabIndex = 4;
            this.btnCarteiras.Text = "Carteiras";
            this.btnCarteiras.UseVisualStyleBackColor = true;
            // 
            // btnNaturezas
            // 
            this.btnNaturezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaturezas.Location = new System.Drawing.Point(12, 56);
            this.btnNaturezas.Name = "btnNaturezas";
            this.btnNaturezas.Size = new System.Drawing.Size(237, 74);
            this.btnNaturezas.TabIndex = 3;
            this.btnNaturezas.Text = "Naturezas";
            this.btnNaturezas.UseVisualStyleBackColor = true;
            // 
            // formCadastrosFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 194);
            this.Controls.Add(this.btnContas);
            this.Controls.Add(this.btnCarteiras);
            this.Controls.Add(this.btnNaturezas);
            this.Name = "formCadastrosFinanceiro";
            this.Text = "Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnCarteiras;
        private System.Windows.Forms.Button btnNaturezas;
    }
}