using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLoja.uteis
{
    public class Estoque
    {
        private List<Produtos> produto = new List<Produtos>();
        public Estoque() { }

        public bool AdicionarProduto(Produtos prod)
        {
            try
            {
                produto.Add(prod);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoverProduto(int idproduto)
        {
            bool produtoEncontrado = false;
            for (int i = 0; i < produto.Count; i++)
            {
                if (produto[i].IdProduto == idproduto)
                {
                    produto.Remove(produto[i]);
                    produtoEncontrado = true;
                    break;
                }
                
            }
            return produtoEncontrado;
        }

        public List<Produtos> ListarProdutos()
        {
            return produto;
        }
    }
}
