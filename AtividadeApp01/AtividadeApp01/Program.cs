// See https://aka.ms/new-console-template for more information
float altura, peso, imc;

Console.WriteLine("____________________________________");
Console.WriteLine("          CALCULADORA DE IMC");
Console.WriteLine("____________________________________");

Console.Write("informe sua altura (M) : ");
altura = float.Parse(Console.ReadLine());
Console.Write("informe seu peso (Kg) : ");
peso = float.Parse(Console.ReadLine());

imc = (peso) / (altura * altura);

if (imc >= 40)
{
    Console.WriteLine("_____________________________________");
    Console.Write($"Seu imc é {imc}, você está em obesidade grave.");
}
else if (imc >= 30 && imc < 40)
{
    Console.WriteLine("_____________________________________");
    Console.Write($"Seu imc é {imc}, você está em obesidade.");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("_____________________________________");
    Console.Write($"Seu imc é {imc}, você está em sobrepeso.");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("_____________________________________");
    Console.Write($"Seu imc é {imc}, você está com o peso ideal.");
}
else
{
    Console.WriteLine("_____________________________________");
    Console.Write($"Seu imc é {imc}, você está abaixo do peso ideal.");
}