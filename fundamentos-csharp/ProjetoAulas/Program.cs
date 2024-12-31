using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Cadastro.Produto("Teclado Gamer Razr", "Teclado Gamer de alta performance");
            produto1.SetId(15);
            produto1.ImprimeDadosDoProduto();
        }
    }
}