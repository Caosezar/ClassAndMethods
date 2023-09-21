using ExercícioProposto2;
using System;
namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preencha os dados do produto.");
            Produto p1 = new Produto();
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            p1.Quant = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Dados do produto{p1}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int adc = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(adc);
            Console.WriteLine();
            Console.Write($"Dados atualizados.. {p1}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remo = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(remo);
            Console.WriteLine($"Dados atualizados.. {p1}");
            

        }
    }
}