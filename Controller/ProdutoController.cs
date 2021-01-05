using System;
using MVC_CONSOLE.Models;
using MVC_CONSOLE.Views;
using System.Collections.Generic;

namespace MVC_CONSOLE.Controller
{
    public class ProdutoController
    {

        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void MostrarProdutos()
        {

            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
    }
}