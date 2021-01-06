using System;
using MVC_CONSOLE.Models;
using MVC_CONSOLE.Controller;


namespace MVC_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
           ProdutoController produtoController = new ProdutoController(); 

            produtoController.Cadastrar();

           produtoController.MostrarProdutos();

        }
    }
}
