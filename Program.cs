Cronometro();
static void Cronometro()
{
    Console.Clear();
    Console.WriteLine("Cronometro");
    Console.WriteLine("S - Segundos | Ex. 10s para calcular 10 segundos");
    Console.WriteLine("M - Minutos | Ex. 1m para calcular 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar?");
    
    string? data = Console.ReadLine().ToLower();
    
    if (data == null || data == "0")
        Environment.Exit(0);
    
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;
    
    if (type == 'm')
        multiplier = 60;
    
    if (time == 0)
        Environment.Exit(0);
    
    Start(time * multiplier);
}

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine($"{time - currentTime} segundos restantes");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Tempo definido: {time} segundos");
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Cronometro finalizado");
    Thread.Sleep(2500);
    Cronometro();
}