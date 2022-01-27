using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laço de repetição While");

        double valorInvestido = 1000;
        int contadorMes = 1;

        while (contadorMes <= 12)
        {
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("O valor investido no mês " + contadorMes + " é de R$" + valorInvestido);
            contadorMes++;
        }
    }
}