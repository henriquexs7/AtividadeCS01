﻿// See https://aka.ms/new-console-template for more information
float m1, m2, m3, m4, mf;

Console.Write("Olá, informe o nome do aluno: ");
string nome = Console.ReadLine();
Console.Write("Agora informe a série do aluno: ");
string serie = Console.ReadLine();
Console.Write("Por fim, informe o turno do aluno: ");
string turno = Console.ReadLine();

Console.WriteLine("_____________________________________________________");

Console.Write("Digite a média do aluno no 1º bimestre (0-10) : ");
m1 = float.Parse(Console.ReadLine());
Console.Write("Digite a média do aluno no 2º bimestre (0-10) : ");
m2 = float.Parse(Console.ReadLine());
Console.Write("Digite a média do aluno no 3º bimestre (0-10) : ");
m3 = float.Parse(Console.ReadLine());
Console.Write("Digite a média do aluno no 4º bimestre (0-10) : ");
m4 = float.Parse(Console.ReadLine());

Console.WriteLine("_____________________________________________________");
mf = ((m1 + m2 + m3 + m4) / 4);

if (mf >= 6)
{
    Console.WriteLine($"O aluno {nome} de {serie} {turno} ficou com a média final em {mf}. O aluno está aprovado.");
}
else if (mf < 6)
{
    Console.WriteLine($"O aluno {nome} de {serie} {turno} ficou com a média final em {mf}. O aluno está reprovado.");
}

Console.WriteLine("____________________________________________________");
