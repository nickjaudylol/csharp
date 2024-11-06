//Estrutura Condicional Simples
double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3) /3;
if (media >=7)
{
    Console.WriteLine($"Média{media:F2}: Aprovado");
}
else
{
    Console.WriteLine($"Média {media:F2}: Recuperação");
}

double nota4 = 8;
double nota5 = 8.0;
double nota6 = 5.0;
double mediaNota = (nota4 + nota5 + nota6) /3;
if (mediaNota >=7)
{
    Console.WriteLine($"Média {mediaNota:F2}: Aprovado");
}
else if (mediaNota >=5 && mediaNota <7)
{
    Console.WriteLine($"Média {mediaNota:F2}: Recuperação");
}


else
{
    Console.WriteLine($"Média {mediaNota:F2}: Reprovado");
}

Console.WriteLine("Digite uma vogal");
string? letra = Console.ReadLine();
if(letra == "a" && letra == "A")
{
Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if (letra =="e" || letra == "E")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if (letra =="i" || letra == "I")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if (letra == "o" || letra == "O")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else if (letra == "u" || letra == "U")
{
    Console.WriteLine($"Você digitou uma vogal: {letra}");
}
else 
{
    Console.WriteLine($"A letra {letra} nao e uma vogal");
}