using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(string[] args)
    {
        /*double salario = 3300.0;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Seu IR é de 7,5%. Você pode deduzir na declaração o valor de R$142");
        }
        else if (salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("Seu IR é de 15%. Você pode deduzir na declaração o valor de R$350");
        }
        else if (salario >= 3751.01 && salario <= 4664.0)
        {
            Console.WriteLine("Seu IR é de 22,5%. Você pode deduzir na declaração o valor de R$636");
        }


    

// para não precisar desencadear muitos ifs, podemos usar o switch.
// Onde será escolhido o case que se aplica. Se não houver nenhum ele executa
// o default
        int mes = 13;

        switch (mes)
        {
            case 1:
                Console.WriteLine("O mês é Janeiro");
                break;
            case 2:
                Console.WriteLine("O mês é Fevereiro");
                break;
            case 3:
                Console.WriteLine("O mês é Março");
                break;
            case 4:
                Console.WriteLine("O mês é Abril");
                break;
            case 5:
                Console.WriteLine("O mês é Maio");
                break;
            case 6:
                Console.WriteLine("O mês é Junho");
                break;
            case 7:
                Console.WriteLine("O mês é Julho");
                break;
            case 8:
                Console.WriteLine("O mês é Agosto");
                break;
            case 9:
                Console.WriteLine("O mês é Setembro");
                break;
            case 10:
                Console.WriteLine("O mês é Outubro");
                break;
            case 11:
                Console.WriteLine("O mês é Novembro");
                break;
            case 12:
                Console.WriteLine("O mês é Dezembro");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }
        Console.ReadLine();

        
        for (int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine(contador);
           
        }

        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
            Console.WriteLine();
        }
        //forma diferente
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        //tabuada
        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                Console.WriteLine();
            }
            Console.WriteLine();
        }*/
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}


    
        
    


    

