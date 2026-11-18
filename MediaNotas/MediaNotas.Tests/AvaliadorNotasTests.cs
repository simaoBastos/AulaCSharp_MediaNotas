using Xunit;
using MediaNotas.App;

namespace MediaNotas.Tests;
public class AvaliadorNotasTests
{
    [Theory]
    [InlineData(8, 6, 7)]
    [InlineData(4, 6, 5)]
    [InlineData(10, 10, 10)]
    public void Media_CalculaCorretamente(double a, double b, double esperado)
    {
        var servico = new AvaliadorNotas();
        Assert.Equal(esperado, servico.CalcularMedia(a, b));
    }


    [Theory]
    [InlineData(7, true)]
    [InlineData(6.9, false)]
    [InlineData(10, true)]
    public void Aprovacao_RespeitaLimite(double media, bool esperado)
    {
        var servico = new AvaliadorNotas();
        Assert.Equal(esperado, servico.Aprovado(media));
    }
}