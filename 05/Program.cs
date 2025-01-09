using System;

class Program
{
    static void Main()
    {
        
        string original = "Inverter a string feito corretamente";

       
        string invertida = InverterString(original);

     
        Console.WriteLine("Original: " + original);
        Console.WriteLine("Invertida: " + invertida);
    }

    static string InverterString(string input)
    {
        
  
        char[] caracteresInvertidos = new char[input.Length];

       
        for (int i = 0, j = input.Length - 1; i <= j; i++, j--)
        {
           
            caracteresInvertidos[i] = input[j];

            if (i != j)
            {
                caracteresInvertidos[j] = input[i];
            }
        }

        
        return new string(caracteresInvertidos);
    }
}
