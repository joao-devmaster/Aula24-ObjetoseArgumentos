using System;

namespace Aula24ObjetoseArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1- criamos alguns produtos
           Produto p1 = new Produto(1, "Destiny 2", 200f);
           Produto p2 = new Produto(2, "FIFA 20", 90f );
           Produto p3 = new Produto(3, "UFC 20", 100f);
           Produto p4 = new Produto(4, "GTA 5", 70f);

           //Adicionamos eles ao carrinho
           Carrinho carrinho = new Carrinho();
           carrinho.AdicionarProduto(p1);
           carrinho.AdicionarProduto(p2);
           carrinho.AdicionarProduto(p3);
           carrinho.AdicionarProduto(p4);

           //para mostrar o carrinho completo:
           carrinho.MostrarProdutos();



        }
    }
}
