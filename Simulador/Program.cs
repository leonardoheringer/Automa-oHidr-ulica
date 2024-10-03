using System;
Random randNum = new Random();
bool repetir = true;
while (repetir == true)
{
int b1 = randNum.Next(0, 2);
int b2 = randNum.Next(0, 2);
int b3 = randNum.Next(0, 2);
Console.Clear();
 Console.WriteLine("-------BEM VINDO SIMULADOR HIDRÁULICO-------");
 Console.WriteLine("Simula a automação de um sistema hidráulico");
    if (b1 == 1)
    {
        Console.WriteLine("Boia A está lígada!");
    }
    else
    {
        Console.WriteLine("Boia A está Desligada!");
    }
    if (b2 == 1)
    {
        Console.WriteLine("Boia B está lígada!");
    }
    else
    {
        Console.WriteLine("Boia B está Desligada!");
    }
    if (b3 == 1)
    {
        Console.WriteLine("Boia C está lígada!");
    }
    else
    {
        Console.WriteLine("Boia C está Desligada!");
    }

    if (b1 == 0 && b2 == 0 && b3 == 0)
    {
        Console.WriteLine("Ligar Registro!");
    }
    if (b1 == 0 && b2 == 0 && b3 == 1)
    {
        Console.WriteLine("Ligar Registro!");
    }
    if (b1 == 0 && b2 == 1 && b3 == 0)
    {
        Console.WriteLine("Erro Sensor!");
        Console.WriteLine("Solicitar Técnico!");
    }

    if (b1 == 0 && b2 == 1 && b3 == 1)
    {
        Console.WriteLine("Erro Sensor!");
        Console.WriteLine("Solicitar Técnico!");
    }
    if (b1 == 1 && b2 == 0 && b3 == 0)
    {
        Console.WriteLine("Ligar Registro!");
        Console.WriteLine("Ligar Bomba!");
    }
    if (b1 == 1 && b2 == 0 && b3 == 1)
    {
        Console.WriteLine("Ligar Registro!");
    }
    if (b1 == 1 && b2 == 1 && b3 == 0)
    {
        Console.WriteLine("Ligar Bomba!");
    }
    if (b1 == 1 && b2 == 1 && b3 == 1)
    {
        Console.WriteLine("Manter bomba desligada!");
        Console.WriteLine("Manter registro copasa desligado!");
    }
    Console.WriteLine("Deseja simular novamente? (s/n)");

    var continuar = Console.ReadLine();

    if (continuar?.ToLower() != "s")
    {
        Console.WriteLine("Obrigado!");
        repetir = false;
    }
}