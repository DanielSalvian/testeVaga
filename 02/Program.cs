using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());
     
            if (EhFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence a sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence a sequência de Fibonacci.");
            }
       
    }

    static bool EhFibonacci(int n)
    {
        return QuadradPerfeito(5 * n * n + 4) || QuadradPerfeito(5 * n * n - 4);
    }

    static bool QuadradPerfeito(int x)
    {
        int raiz = (int)Math.Sqrt(x);
        return raiz * raiz == x;
    }
}
