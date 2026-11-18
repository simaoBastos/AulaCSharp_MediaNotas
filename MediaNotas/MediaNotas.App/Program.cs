using MediaNotas.App;

var avaliador = new AvaliadorNotas();
Console.Write("Primeira nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Segunda nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());
double media = avaliador.CalcularMedia(n1, n2);
Console.WriteLine($"Média: {media:F1}");
Console.WriteLine(avaliador.Aprovado(media) ? "Aprovado" : "Reprovado");