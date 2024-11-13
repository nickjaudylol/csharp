Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1,101);
int contador = 0;
Console.WriteLine($"Numero Alvo: {numero}");
//Loop que incrementa o contador até ele atingir o numero alvo
while (contador != numero)
{
    Console.WriteLine($"Contador: {contador}.");
    contador++;

}
Console.WriteLine($"Contador atingiu o numero alvo: {contador}");
int numero = 0;

do 
{
    Console.WriteLine($"Numero: {numero}");
    numero++;
} while (numero < 10);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}

Estrutura de repetição foreach
string[] nomes = { "Nicolas", "Heitor","Elicassia"};
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

1
int soma = 0;
for(int i = 2; i <=100; i+=2)
{
    soma+=i;
}
Console.WriteLine("A soma dos numeros pares de 1 a 100 é:" + soma);



2

for(int n=10; n>0; n--)
{
    Console.WriteLine($"Valor de n: {n}");
}

Console.WriteLine("Decolar!");

//3

    int vogal = 0;
    char[] caracteres =  { 'a', 'e', 'i', 'o', 'u'};

    Console.WriteLine("Digite o seu nome completo:");

    char[] nome_completo = Console.ReadLine().ToLower().ToCharArray();

    for (int conta = 0; conta < nome_completo.Length; conta++)
    {
        if (caracteres.Contains(nome_completo[conta]));
        {
            vogal++;               
        }
    }

    Console.WriteLine("Total de {0} letras \"{1}\".", vogal, caracteres[0]);
    Console.Read();

    Console.ReadKey();

4

        Console.WriteLine("Digite uma palavra ou frase:");
        string input = Console.ReadLine();

        string cleanedInput = new string(input.Where(c => Char.IsLetterOrDigit(c)).ToArray()).ToLower();
        if (IsPalindrome(cleanedInput))
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    

     bool IsPalindrome(string str)
    {
        int start = 0;

        int end = str.Length - 1;

        while (start < end)
        {
            if (str[start] != str[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }


5
 
    Random gerarNumero = new Random();
    
    int numeroGerado = gerarNumero.Next(1,100);
    
    int numeroDigitado = 0;
    
    int tentativas = 0;
    
    
    Console.WriteLine(@"Acerte o numero");
    
    Console.WriteLine("Bem vindo ao meu jogo");
    
    Console.WriteLine("O jogo gerou um número aleatório entre 1 e 100! Tente adivinhar qual o número.\n");
    
    Console.WriteLine("Você tem 5 tentativas");
    
    
    while ( tentativas < 5 )
    {
        Console.WriteLine($"{tentativas + 1}º tentativa");
        Console.Write("Digite um numero: ");
        numeroDigitado = int.Parse(Console.ReadLine()!);
        
        if ( numeroDigitado == numeroGerado)
        {
            Console.WriteLine("Parabens você acertou o numero gerado");
            Thread.Sleep(1500);
            break;
        }
        
        else if (tentativas <= 3) 
        {
        
            Console.WriteLine( (numeroDigitado < numeroGerado) ? "O numero digitado é menor que o numero gerado" : "O numero digitado é maior que o numero gerado");
            Thread.Sleep(1500);
        }	
        else 
        {
            Console.WriteLine($"Essa foi sua ultima tentativa, e o numero digitado \"{numeroDigitado}\"é diferente de \"{numeroGerado}\"  ");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Você perdeu");
            Thread.Sleep(1500);
        }
        
        tentativas++;
        Console.Clear();
    }




