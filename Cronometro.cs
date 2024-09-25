using System;
using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        return1:
        Console.Write("Quantos segundos o cronometro deve contar? ");
        if(int.TryParse(Console.ReadLine(), out int seconds))
        {
            Console.Clear();
            for(int i = seconds; i >= 0; i--)
            {
                Console.WriteLine($"Tempo restante: {i} segundos");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("Valor inválido!"); 
            goto return1;
        }
    }
}
