
namespace FormularioVendas
{
    partial class Vendas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.AdicionarButton = new System.Windows.Forms.Button();
            this.fornecedorBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantidadeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FreteButton2 = new System.Windows.Forms.RadioButton();
            this.FreteButton = new System.Windows.Forms.RadioButton();
            this.ExposicaoBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.produtoBox = new System.Windows.Forms.TextBox();
            this.processarButton = new System.Windows.Forms.Button();
            this.exposicaoListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limparButton);
            this.groupBox1.Controls.Add(this.AdicionarButton);
            this.groupBox1.Controls.Add(this.fornecedorBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.valorBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.quantidadeBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FreteButton2);
            this.groupBox1.Controls.Add(this.FreteButton);
            this.groupBox1.Controls.Add(this.ExposicaoBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.produtoBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos";
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(6, 134);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(171, 29);
            this.limparButton.TabIndex = 9;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // AdicionarButton
            // 
            this.AdicionarButton.Location = new System.Drawing.Point(196, 134);
            this.AdicionarButton.Name = "AdicionarButton";
            this.AdicionarButton.Size = new System.Drawing.Size(175, 29);
            this.AdicionarButton.TabIndex = 7;
            this.AdicionarButton.Text = "Adicionar";
            this.AdicionarButton.UseVisualStyleBackColor = true;
            this.AdicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // fornecedorBox
            // 
            this.fornecedorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fornecedorBox.FormattingEnabled = true;
            this.fornecedorBox.Items.AddRange(new object[] {
            "Fornecedor 1",
            "Fornecedor 2",
            "Fornecedor 3",
            "Fornecedor 4",
            "Fornecedor 5"});
            this.fornecedorBox.Location = new System.Drawing.Point(273, 57);
            this.fornecedorBox.Name = "fornecedorBox";
            this.fornecedorBox.Size = new System.Drawing.Size(98, 23);
            this.fornecedorBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fornecedor";
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(273, 93);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(98, 23);
            this.valorBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // quantidadeBox
            // 
            this.quantidadeBox.Location = new System.Drawing.Point(79, 93);
            this.quantidadeBox.Name = "quantidadeBox";
            this.quantidadeBox.Size = new System.Drawing.Size(98, 23);
            this.quantidadeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frete";
            // 
            // FreteButton2
            // 
            this.FreteButton2.AutoSize = true;
            this.FreteButton2.Checked = true;
            this.FreteButton2.Location = new System.Drawing.Point(130, 58);
            this.FreteButton2.Name = "FreteButton2";
            this.FreteButton2.Size = new System.Drawing.Size(47, 19);
            this.FreteButton2.TabIndex = 3;
            this.FreteButton2.TabStop = true;
            this.FreteButton2.Text = "Não";
            this.FreteButton2.UseVisualStyleBackColor = true;
            // 
            // FreteButton
            // 
            this.FreteButton.AutoSize = true;
            this.FreteButton.Location = new System.Drawing.Point(79, 58);
            this.FreteButton.Name = "FreteButton";
            this.FreteButton.Size = new System.Drawing.Size(45, 19);
            this.FreteButton.TabIndex = 2;
            this.FreteButton.Text = "Sim";
            this.FreteButton.UseVisualStyleBackColor = true;
            // 
            // ExposicaoBox
            // 
            this.ExposicaoBox.AutoSize = true;
            this.ExposicaoBox.Location = new System.Drawing.Point(273, 24);
            this.ExposicaoBox.Name = "ExposicaoBox";
            this.ExposicaoBox.Size = new System.Drawing.Size(84, 19);
            this.ExposicaoBox.TabIndex = 1;
            this.ExposicaoBox.Text = "Exposição?";
            this.ExposicaoBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // produtoBox
            // 
            this.produtoBox.Location = new System.Drawing.Point(79, 22);
            this.produtoBox.Name = "produtoBox";
            this.produtoBox.Size = new System.Drawing.Size(184, 23);
            this.produtoBox.TabIndex = 0;
            // 
            // processarButton
            // 
            this.processarButton.Location = new System.Drawing.Point(412, 23);
            this.processarButton.Name = "processarButton";
            this.processarButton.Size = new System.Drawing.Size(139, 29);
            this.processarButton.TabIndex = 8;
            this.processarButton.Text = "Processar";
            this.processarButton.UseVisualStyleBackColor = true;
            this.processarButton.Click += new System.EventHandler(this.ProcessarButton_Click);
            // 
            // exposicaoListBox
            // 
            this.exposicaoListBox.FormattingEnabled = true;
            this.exposicaoListBox.ItemHeight = 15;
            this.exposicaoListBox.Location = new System.Drawing.Point(412, 72);
            this.exposicaoListBox.Name = "exposicaoListBox";
            this.exposicaoListBox.Size = new System.Drawing.Size(139, 109);
            this.exposicaoListBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Produtos em exposição::";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Exposicao,
            this.Frete,
            this.Quantidade,
            this.Fornecedor,
            this.Valor,
            this.Total});
            this.dataGrid.Location = new System.Drawing.Point(12, 187);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(539, 172);
            this.dataGrid.TabIndex = 15;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Exposicao
            // 
            this.Exposicao.HeaderText = "Exposição";
            this.Exposicao.Name = "Exposicao";
            this.Exposicao.ReadOnly = true;
            // 
            // Frete
            // 
            this.Frete.HeaderText = "Frete";
            this.Frete.Name = "Frete";
            this.Frete.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 366);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exposicaoListBox);
            this.Controls.Add(this.processarButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox produtoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FreteButton2;
        private System.Windows.Forms.RadioButton FreteButton;
        private System.Windows.Forms.CheckBox ExposicaoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantidadeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdicionarButton;
        private System.Windows.Forms.Button processarButton;
        private System.Windows.Forms.ListBox exposicaoListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox fornecedorBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button limparButton;
    }
}

