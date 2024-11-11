// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1,101);
// int contador = 0;
// Console.WriteLine($"Numero Alvo: {numero}");
// //Loop que incrementa o contador até ele atingir o numero alvo
// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;

// }
// Console.WriteLine($"Contador atingiu o numero alvo: {contador}");
// int numero = 0;

// do 
// {
//     Console.WriteLine($"Numero: {numero}");
//     numero++;
// } while (numero < 10);

// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine($"Valor de i: {i}");
// }

//Estrutura de repetição foreach
// string[] nomes = { "Nicolas", "Heitor","Elicassia"};
// foreach (string nome in nomes)
// {
//     Console.WriteLine(nome);
// }

//1
// int soma = 0;
// for(int i = 2; i <=100; i+=2)
// {
//     soma+=i;
// }
// Console.WriteLine("A soma dos numeros pares de 1 a 100 é:" + soma);



//2

// for(int n=10; n>0; n--)
// {
//     Console.WriteLine($"Valor de n: {n}");
// }

// //3

//     int vogal = 0;
//     char[] caracteres =  { 'a', 'e', 'i', 'o', 'u'};

//     Console.WriteLine("Digite o seu nome completo:");

//     char[] nome_completo = Console.ReadLine().ToLower().ToCharArray();

//     for (int conta = 0; conta < nome_completo.Length; conta++)
//     {
//         if (caracteres.Contains(nome_completo[conta]));
//         {
//             vogal++;               
//         }
//     }

//     Console.WriteLine("Total de {0} letras \"{1}\".", vogal, caracteres[0]);
//     Console.Read();

//     Console.ReadKey();

//4

        Console.WriteLine("Digite um palavra ou frase:");
        string entrada =
        console.ReadLine();

        string limpaEntrada =
        entrada.Replace("ana")ToLower();

        if 
        (EhPalindromo(limpaEntrada))
        {
            Console.WriteLine("A entrada é um palíndromo.");
        }
        else
        {
            Console.WriteLine("A entrada nao e um palíndromo");
        }
        
        int inicio =0;
        int fim = str.Length-1;

        while(inicio< fim);
        {
            if(str[inicio] != str[fim])
            {
                return false;
            }
            inicio++;
            fim--;
        
        
        return true;
        }
        
    



