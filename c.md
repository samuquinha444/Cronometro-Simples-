{
    static void Main(string[] args)
    {
        int contador = 0;
        bool continuar = true;

        Console.WriteLine("Pressione Enter para iniciar o contador.");
        Console.ReadLine();

        while (continuar)
        {
            contador++;
            Console.WriteLine(contador);
            System.Threading.Thread.Sleep(1000);

            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                continuar = false;
            }
        }

        Console.WriteLine($"Contador parado em: {contador}.");
    }
}
