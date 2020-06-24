using System;
using System.Collections.Generic;
namespace Aula24ObjetoCArgumento
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto){
            carrinho.Add(_produto);
        }
        public void Ler(){
            foreach(Produto item in carrinho){
                Console.WriteLine($"Jogo: {item.Nome} - Preço: R${item.Preco}");
            }
        }
        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(y => y.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(y => y.Codigo == _codigo).Preco = _novoProduto.Preco;

        }
        public void SomarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.WriteLine($"\n Total dos itens: R$ {ValorTotal}");
        }
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }
    }
}