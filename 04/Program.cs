using System;


class Program
{
    static void Main()
    {
        var faturamentos = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double faturamentoTotal = 0;
        foreach (var faturamento in faturamentos.Values)
        {
            faturamentoTotal += faturamento;
        }


        foreach (var estado in faturamentos)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
