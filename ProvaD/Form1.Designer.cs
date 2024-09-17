namespace ProvaD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtAlterarQtd = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterarQtd = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblValUnit = new System.Windows.Forms.Label();
            this.lblItemSelecionado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.lblVendaNumero = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(135, 66);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(404, 20);
            this.txtProduto.TabIndex = 0;
            // 
            // txtAlterarQtd
            // 
            this.txtAlterarQtd.Location = new System.Drawing.Point(249, 363);
            this.txtAlterarQtd.Name = "txtAlterarQtd";
            this.txtAlterarQtd.Size = new System.Drawing.Size(100, 20);
            this.txtAlterarQtd.TabIndex = 3;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(135, 118);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 1;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToOrderColumns = true;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.quant,
            this.valor,
            this.Tota});
            this.dgvLista.Location = new System.Drawing.Point(157, 198);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(497, 135);
            this.dgvLista.TabIndex = 19;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // quant
            // 
            this.quant.HeaderText = "quant";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Tota
            // 
            this.Tota.HeaderText = "Tota";
            this.Tota.Name = "Tota";
            this.Tota.ReadOnly = true;
            this.Tota.Visible = false;
            // 
            // txtUnitario
            // 
            this.txtUnitario.Location = new System.Drawing.Point(135, 163);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 2;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(363, 118);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(109, 39);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(524, 118);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(109, 39);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterarQtd
            // 
            this.btnAlterarQtd.Location = new System.Drawing.Point(374, 363);
            this.btnAlterarQtd.Name = "btnAlterarQtd";
            this.btnAlterarQtd.Size = new System.Drawing.Size(139, 20);
            this.btnAlterarQtd.TabIndex = 7;
            this.btnAlterarQtd.Text = "Alterar a quantidade";
            this.btnAlterarQtd.UseVisualStyleBackColor = true;
            this.btnAlterarQtd.Click += new System.EventHandler(this.btnAlterarQtd_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(583, 464);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(122, 39);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar Sistema";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(400, 464);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(208, 464);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(128, 39);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar venda";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(41, 66);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 11;
            this.lblProduto.Text = "Produto:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(41, 121);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 12;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblValUnit
            // 
            this.lblValUnit.AutoSize = true;
            this.lblValUnit.Location = new System.Drawing.Point(41, 163);
            this.lblValUnit.Name = "lblValUnit";
            this.lblValUnit.Size = new System.Drawing.Size(71, 13);
            this.lblValUnit.TabIndex = 13;
            this.lblValUnit.Text = "Valor Unitáro:";
            // 
            // lblItemSelecionado
            // 
            this.lblItemSelecionado.AutoSize = true;
            this.lblItemSelecionado.Location = new System.Drawing.Point(23, 366);
            this.lblItemSelecionado.Name = "lblItemSelecionado";
            this.lblItemSelecionado.Size = new System.Drawing.Size(202, 13);
            this.lblItemSelecionado.TabIndex = 14;
            this.lblItemSelecionado.Text = "Alterar a quantidade do item selecionado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total da venda:";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(275, 422);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(13, 13);
            this.lblTotalVenda.TabIndex = 16;
            this.lblTotalVenda.Text = "0";
            // 
            // lblVendaNumero
            // 
            this.lblVendaNumero.AutoSize = true;
            this.lblVendaNumero.Location = new System.Drawing.Point(41, 32);
            this.lblVendaNumero.Name = "lblVendaNumero";
            this.lblVendaNumero.Size = new System.Drawing.Size(41, 13);
            this.lblVendaNumero.TabIndex = 17;
            this.lblVendaNumero.Text = "Venda:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(154, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 553);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblVendaNumero);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblItemSelecionado);
            this.Controls.Add(this.lblValUnit);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAlterarQtd);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtUnitario);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtAlterarQtd);
            this.Controls.Add(this.txtProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtAlterarQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtUnitario;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterarQtd;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblValUnit;
        private System.Windows.Forms.Label lblItemSelecionado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.Label lblVendaNumero;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tota;
    }
}

