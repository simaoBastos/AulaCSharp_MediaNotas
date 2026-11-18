namespace MediaNotas.App;
public class AvaliadorNotas
{
    public double CalcularMedia(double n1, double n2) => (n1 + n2) / 2;
    public bool Aprovado(double media) => media >= 7;
}