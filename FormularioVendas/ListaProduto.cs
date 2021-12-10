using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioVendas
{
    class ListaProduto
    {
        private static readonly List<Produto> produtos = new();

        public static void AddProduto(Produto p)
        {
            produtos.Add(p);
        }

        public static List<Produto> ObterProdutos()
        {
            return produtos;
        }
    }
}
