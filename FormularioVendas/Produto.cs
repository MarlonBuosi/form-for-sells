using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioVendas
{
    class Produto
    {
        public string ProdutoNome { get; set; }
        public string Exposicao { get; set; }
        public string Frete { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double Total { get; set; }
        public string Fornecedor { get; set; }

        public Produto() { }

        public Produto(string produtoNome, int quantidade, double valor, string exposicao, string frete, string fornecedor)
        {
            ProdutoNome = produtoNome;
            Quantidade = quantidade;
            Valor = valor;
            Fornecedor = fornecedor;
            Exposicao = exposicao;
            Frete = frete;
            Total = quantidade * valor;
        }
    }
}
