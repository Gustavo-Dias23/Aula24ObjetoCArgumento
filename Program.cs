using System;

namespace Aula24ObjetoCArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "Bioshock Infinite", 79.99f);
            Produto p2 = new Produto(2, "The Last of Us II", 249.99f);
            Produto p3 = new Produto(3, "Batman Arkham Knight", 69.99f);
            Produto p4 = new Produto(4, "The Witcher 3: Wild Hunt", 89.99f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            Produto novoProduto = new Produto(2, "Escape From Tarkov", 219.99f);
            cart.AlterarItem(2, novoProduto);


            cart.Ler();
            cart.SomarTotal();
        }
    }
}
