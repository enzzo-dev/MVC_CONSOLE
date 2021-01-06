using System;
using System.IO;
using System.Collections.Generic;

namespace MVC_CONSOLE.Models
{
    public class Produto
    {
        public int Codigo {get;set;}
        public string Nome {get;set;}
        public float Preco {get;set;}

        private const string PATH  = "Database/Produto.csv";


        //Método construtor para dividir a pasta do arquivo
        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }


        //Ler lista de produtos
        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                Produto prod = new Produto();
                prod.Codigo  = int.Parse( atributos[0]);
                prod.Nome    = atributos[1];
                prod.Preco   = float.Parse( atributos[2] );

                produtos.Add(prod);
            }

            return produtos;
        }


        //Atribuir informações em CSV dinamicamente
        public void Inserir(Produto p)
        {
            string[] linhas = {PrepararLinhaCSV(p)};
            File.AppendAllLines(PATH, linhas);
        }

        public string PrepararLinhaCSV(Produto produtosCSV)
        {
            return $"{produtosCSV.Codigo};{produtosCSV.Nome};{produtosCSV.Preco}\n";
        }
        
    }
}