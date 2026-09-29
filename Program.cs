Console.WriteLine("--- Tempo de Download ---");
Console.WriteLine();

Console.Write("Tamanho do arquivo em MB........: ");
double tamanho = double.Parse(Console.ReadLine()!);

Console.Write("Velocidade da conexão em Mbps...: ");
double velocidade = double.Parse(Console.ReadLine()!);

double segundos = (tamanho * 8) / velocidade;
double minutos = segundos / 60;

Console.WriteLine();
Console.WriteLine("Tempo estimado de download: " + minutos.ToString("F1") + " minutos"); 
