using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
       
        string caminhoJson = "faturamento.json";

        List<double> faturamentos = LerFaturamentoDeJson(caminhoJson);
       

        if (faturamentos.Count == 0)
        {
            Console.WriteLine("Não há dados de faturamento disponíveis.");
            return;
        }

      
        var diasComFaturamento = faturamentos.Where(f => f > 0).ToList();

        if (diasComFaturamento.Count == 0)
        {
            Console.WriteLine("Não há dias com faturamento registrado.");
            return;
        }

     
        double menorFaturamento = diasComFaturamento.Min();

       
        double maiorFaturamento = diasComFaturamento.Max();

      
        double mediaMensal = diasComFaturamento.Average();

        
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f > mediaMensal);

       
        Console.WriteLine($"Menor faturamento diário: {menorFaturamento:C}");
        Console.WriteLine($"Maior faturamento diário: {maiorFaturamento:C}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }

    static List<double> LerFaturamentoDeJson(string caminhoArquivo)
    {
        try
        {
            string jsonString = File.ReadAllText(caminhoArquivo);
            var faturamentos = JsonSerializer.Deserialize<List<FaturamentoJson>>(jsonString);
            return faturamentos.Select(f => f.faturamento).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
            return new List<double>();
        }
    }

}

class FaturamentoJson
{
    public int dia { get; set; }
    public double faturamento { get; set; }
}
