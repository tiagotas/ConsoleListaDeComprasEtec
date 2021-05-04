using System;
using System.Collections.Generic;
using System.Globalization;

namespace AppListaDeComprasEtec
{
    class Program
    {
        static void Main(string[] args)
        {
            var nfi = new CultureInfo("pt-BR").NumberFormat;


            Console.WriteLine("Lista de Compras");

            List<Produto> compra_itens = new List<Produto>();

            // Primeira forma de adicionar itens na lista.
            Produto p1 = new Produto();
            p1.Descricao = "Nikito Chocolate";
            p1.Quantidade = 5;
            p1.PrecoUnitario = 2.30;
            //p1.PrecoTotal = 11.50;
            compra_itens.Add(p1);


            // Segunda forma de adicionar itens na lista (equilavente a forma anterior)
            compra_itens.Add(new Produto()
            {
                Descricao = "Pudim Leite Cond",
                Quantidade = 2,
                PrecoUnitario = 15.0,
                //PrecoTotal = 30
            });

            compra_itens.Add(new Produto()
            {
                Descricao = "Torta de Morango",
                Quantidade = 1,
                PrecoUnitario = 12.0,
                //PrecoTotal = 12.0
            });

            compra_itens.Add(new Produto()
            {
                Descricao = "Bolo de Cenoura",
                Quantidade = 3,
                PrecoUnitario = 9.50,
                //PrecoTotal = 28.50
            });

            compra_itens.Add(new Produto()
            {
                Descricao = "Bolo de Limão",
                Quantidade = 1,
                PrecoUnitario = 9.50,
                //PrecoTotal = 9.50
            });





            double valor_total_compra = 0;

            Console.WriteLine("Item    Produto          Quantidade      Preço Unitário     Preço Total");
            
            for(int i=0; i<compra_itens.Count; i++)
            {
                Console.WriteLine(
                    "{0}    {1}          {2}             {3}            {4}",
                    i,
                    compra_itens[i].Descricao,
                    compra_itens[i].Quantidade,
                    compra_itens[i].PrecoUnitario.ToString("C", nfi),
                    compra_itens[i].PrecoTotal.ToString("C", nfi)
                );

                // Acumulador.
                valor_total_compra = valor_total_compra + compra_itens[i].PrecoTotal;
            }

            Console.WriteLine("Total da Compra: {0} ", valor_total_compra.ToString("C", nfi));


            Console.ReadKey();
        }
    }
}
