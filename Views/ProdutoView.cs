using System;
using System.IO;
using System.Collections.Generic;
using MVC_CONSOLE.Models;

namespace MVC_CONSOLE.Views
{
    public class ProdutoView
    {
        
        public void ListarTodos(List<Produto> produtos)
        {
            foreach (Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine($"Código : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preço : R$ {item.Preco}");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o código do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o valor do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());
            
            return produto;
            
        }

    }
}