using System;

using System.Collections.Generic;

namespace Aula24ObjetoseArgumentos
{
    public class Carrinho
    {

        //propriedade que ira guardar o valor total do carrinho
        public float ValorTotal { get; set; }

        // 1- criamos uma lista que representará nosso carrinho
        List<Produto> carrinho = new List<Produto>();

        // 2- criamos o método que adiciona o produto no carrinho
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        // 3- Criamos o método que remove um produto do carrinnho
        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        // 4- podemos criar um método para listar os produtos que estao no carrinho
        public void MostrarProdutos()
        {
           

            if(carrinho != null)
            {
                 foreach(Produto p in carrinho)
                 {
                       Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"R$ {p.preco.ToString("n2")} - {p.Nome} ");
                Console.ResetColor();

                 }
              MostrarTotal();
            }
        }

        // 5- Podemos criar um método para listar os produtos que estão no carrinho
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            
            if(carrinho != null)
            {
                foreach(Produto p in carrinho)
                {
                   ValorTotal += p.preco;
                }
                System.Console.WriteLine($"Total do carrinho RS {ValorTotal.ToString("n2")} ");

            }else{
                System.Console.WriteLine($"Seu carrinho ainda esta vazio! ");
            }
            Console.ResetColor();
        }

        // 6- como alterar determinado produto
        public void AlterarItem(int _codigo, Produto _novoproduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoproduto.Nome;
            carrinho.Find(x=> x.Codigo == _codigo).preco = _novoproduto.preco;
        }
    }
}