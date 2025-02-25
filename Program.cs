using System;

class Program
{
    static void Main ()
    {
        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());
        double desconto = preco * 0.15;
        double PrecoComDesconto = preco - desconto;

        Console.WriteLine($"Preço original R$ {preco}, com desconto fica R$ {PrecoComDesconto}");
          
    }
}