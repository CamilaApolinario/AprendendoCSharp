using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Laço de repetição For");

        double valorInvestido = 1000;
        
        for (int contadorMes = 1; contadorMes <=12; contadorMes++)
        {
            valorInvestido *= 1.0036;
            Console.WriteLine("O valor investido após " + contadorMes + " mesess é de R$" + valorInvestido);
            
        }*/

        Console.WriteLine("Laço de repetição For encadeado");

        double valorInvestido = 1000;
        double fatorRendimento = 1.0036;

        for (int contadorAno = 1; contadorAno <=5; contadorAno++)
        {
            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= fatorRendimento;
            }
            fatorRendimento += 0.0010; 
        }
        Console.WriteLine("O valor investido é de R$" + valorInvestido);

    }
}