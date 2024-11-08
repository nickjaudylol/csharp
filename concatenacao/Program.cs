// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string nome = "joão";
// string saudacao = "olá," + nome + "!Bem-vindo.";
// Console.WriteLine(saudacao);

// string nome1 = "Nicolas";
// string saudacao1 = $"Olá,{nome1}! Bem-vindo.";
// Console.WriteLine (saudacao1);

// int numero = 5;
// Console.WriteLine(numero.GetType());

// Console.WriteLine(typeof(int));

// string valorTexto ="100";
// Console.WriteLine("A variavel valorTexto e do tipo:" + valorTexto.GetType());

// int numero2 = int.Parse (valorTexto);
// Console.WriteLine(numero2);
// Console.WriteLine("A variavel numero parse e do tipo:"+ numero.GetType());

// //Método Convert
// string valorEmTexto = "100";
// Console.WriteLine("Valor da variável String:" + valorEmTexto);
// Console.WriteLine("A variável valorEmTexto é do tipo:" + valorEmTexto.GetType());

// int numeroConvertido = Convert.ToInt32(valorEmTexto);
// Console.WriteLine(numeroConvertido);
// Console.WriteLine("Após concersão a variável numeroConvertido é do tipo: " + numeroConvertido. GetType());

// //Método ToString
// int  numero3 =123;
// Console.WriteLine(numero3.GetType());


// string numeroComoString = numero3.ToString();
// Console.WriteLine(numeroComoString.GetType());

// //Personalização de Formato

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// string dataHoraFormatada = dataAtual.ToString("dd/MM/yyyy");
// Console.WriteLine(dataHoraFormatada);

// //Uso em Interpolação de Strings
// double preco = 29.99;
// Console.WriteLine($"O preço é: {preco.ToString("C2")}");

// //Cultural e Formato 
// decimal valor = 1234.56m;
// string valorUS = valor.ToString("C", new System.Globalization.CultureInfo("en-US"));
// Console.WriteLine(valorUS);

// string valorBR = valor.ToString("C", new System.Globalization.CultureInfo ("pt-BR"));
// Console.WriteLine(valorBR);

//Switch Case
// string dia = "Sábado";
// switch (dia)
// {
//     case "Sábado":
//         Console.WriteLine("Sábadooo galera!");
//         break;
//     case "Domingo":
//         Console.WriteLine("Domingão, hoje é dia de assistir tricolor!");
//         break;
//     default:
//         Console.WriteLine("Hoje é dia de semana, para de preguiça, levanta e vai trabalhar!");
//         break; 
// }

// Console.WriteLine("Digite uma vogal");
// string? letra = Console.ReadLine();
// string letraMinuscula = letra . ToLower();
// switch (letraMinuscula)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//          Console.WriteLine($"A letra' {letraMinuscula}'é uma vogal.");
//          break;
//     default:
//          Console.WriteLine($"A letra' {letraMinuscula}'não é uma vogal.");
//          break;
// }

//Operador Tenário
// int idade = 18;
// string mensagem = idade >= 18 ? "Maior de Idade" : "Menor de Idade";
// Console.WriteLine(mensagem);



//Exercícios

// bool maiorIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;
// if (maiorIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// bool possuiPresencaMinima = true;
// bool possuiMediaIgualOuMaiorQue7 = true;
// if (possuiPresencaMinima && possuiMediaIgualOuMaiorQue7)
// {
//     Console.WriteLine("Aprovado");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }
// bool possuiPresencaMinima1 =true;
// double media3 = 7.0;

// if(possuiPresencaMinima1 && media3 >=7)
// {
//     Console.WriteLine($"Média `{media3:F1}: Aprovado");
// }
// else
// {
//     Console.WriteLine($"Média {media3:F1}: Reprovado");
// }

bool choveu = false;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Vou pedalar outro dia.");
}
