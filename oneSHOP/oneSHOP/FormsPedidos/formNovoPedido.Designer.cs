namespace oneSHOP.FormsPedidos
{
    partial class formNovoPedido
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
            this.txtRevendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpfPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoPedido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisaProdutoPedido = new System.Windows.Forms.TextBox();
            this.listProdutoPedido = new System.Windows.Forms.ListView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtRevendedor
            // 
            this.txtRevendedor.Enabled = false;
            this.txtRevendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevendedor.Location = new System.Drawing.Point(12, 43);
            this.txtRevendedor.Name = "txtRevendedor";
            this.txtRevendedor.Size = new System.Drawing.Size(291, 29);
            this.txtRevendedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Revendedor";
            // 
            // txtCpfPedido
            // 
            this.txtCpfPedido.Enabled = false;
            this.txtCpfPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfPedido.Location = new System.Drawing.Point(347, 43);
            this.txtCpfPedido.Name = "txtCpfPedido";
            this.txtCpfPedido.Size = new System.Drawing.Size(227, 29);
            this.txtCpfPedido.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de acerto";
            // 
            // txtEnderecoPedido
            // 
            this.txtEnderecoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoPedido.Location = new System.Drawing.Point(12, 102);
            this.txtEnderecoPedido.Name = "txtEnderecoPedido";
            this.txtEnderecoPedido.Size = new System.Drawing.Size(776, 29);
            this.txtEnderecoPedido.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pesquisar produtos";
            // 
            // txtPesquisaProdutoPedido
            // 
            this.txtPesquisaProdutoPedido.Location = new System.Drawing.Point(547, 242);
            this.txtPesquisaProdutoPedido.Name = "txtPesquisaProdutoPedido";
            this.txtPesquisaProdutoPedido.Size = new System.Drawing.Size(241, 20);
            this.txtPesquisaProdutoPedido.TabIndex = 10;
            // 
            // listProdutoPedido
            // 
            this.listProdutoPedido.HideSelection = false;
            this.listProdutoPedido.Location = new System.Drawing.Point(12, 268);
            this.listProdutoPedido.Name = "listProdutoPedido";
            this.listProdutoPedido.Size = new System.Drawing.Size(776, 288);
            this.listProdutoPedido.TabIndex = 9;
            this.listProdutoPedido.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(564, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 31);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(679, 562);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(109, 31);
            this.btnGravar.TabIndex = 37;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // formNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisaProdutoPedido);
            this.Controls.Add(this.listProdutoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnderecoPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpfPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRevendedor);
            this.Name = "formNovoPedido";
            this.Text = "Novo Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRevendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpfPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisaProdutoPedido;
        private System.Windows.Forms.ListView listProdutoPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}