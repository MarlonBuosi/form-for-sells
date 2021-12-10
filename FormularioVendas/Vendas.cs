using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioVendas
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            fornecedorBox.SelectedIndex = 0;
        }

        private void Limpar()
        {
            produtoBox.Clear();
            quantidadeBox.Clear();
            valorBox.Clear();
            fornecedorBox.SelectedIndex = 0;
            ExposicaoBox.Checked = false;
            if (FreteButton.Checked)
                FreteButton2.Checked = true;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            if (!produtoBox.Text.Equals("") && !quantidadeBox.Text.Equals("") && !valorBox.Text.Equals("") &&
                !fornecedorBox.Text.Equals(""))
            {
                try
                {
                    int quantidade = int.Parse(quantidadeBox.Text);
                    double valor = float.Parse(valorBox.Text);
                    string frete = "Não";
                    string exposicao = "Não";

                    if (ExposicaoBox.Checked)
                        exposicao = "Sim";
                    if (FreteButton.Checked)
                        frete = "Sim";
                       
                    Produto p = new(produtoBox.Text, quantidade, valor, exposicao, frete, fornecedorBox.Text);
                    ListaProduto.AddProduto(p);
                    AtualizarGrid();
                }
                catch (Exception)
                {
                    MessageBox.Show("Atenção, formato errado.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Atenção, preencha todos os campos.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarGrid()
        {
            dataGrid.Rows.Clear();
            foreach (Produto temp in ListaProduto.ObterProdutos())
            {
                dataGrid.Rows.Add(temp.ProdutoNome, temp.Exposicao, temp.Frete, temp.Quantidade, temp.Fornecedor, Math.Round(temp.Valor, 2) + " R$", Math.Round(temp.Total, 2) + " R$");
            }
        }

        private void ProcessarButton_Click(object sender, EventArgs e)
        {
            exposicaoListBox.Items.Clear();
            foreach (Produto temporario in ListaProduto.ObterProdutos())
            {
                if (temporario.Exposicao.Equals("Sim"))
                {
                    exposicaoListBox.Items.Add(temporario.ProdutoNome);
                }
            }
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
