// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 30;
// meuArray[3] = 40;
// meuArray[4] = 50;
// Console.WriteLine("Numeros no array");
// for (int i = 0; i < meuArray.Length; i++)
// {
//     Console.WriteLine(meuArray[i]);
// }

// //lista de elementos

// List<string> listaDeNomes = new List<string> {"Nicolas", "Heitor","Elicássia"};
// listaDeNomes.Add("Nicoly");

// //exibindo a lista inicial

// Console.WriteLine("Nomes na lista:");
// for (int i =0; i <listaDeNomes.Count; i++)
// {
//     Console.WriteLine(listaDeNomes[i]);
// }

// //verificar se um nome esta na lista

// Console.WriteLine("\nVerificação de existência do nome Elicássia");
// string nomeParaVerificar = "Elicássia";
// if (listaDeNomes.Contains(nomeParaVerificar))
// {
//     Console.WriteLine($"{nomeParaVerificar} está na lista.");
// }

// else
// {
//     Console.WriteLine($"{nomeParaVerificar}não está na lista.");
// }

// //remover um nome da lista
// Console.WriteLine ("\nApós remover Nicolas:");
// string nomeParaRemover = "Nicolas";
// bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
// if(foiRemovido)
// {
//     Console.WriteLine($"{nomeParaRemover} foi removido da lista.");
// }
// else
// {
//     Console.WriteLine($"{nomeParaRemover} não foi encontrado na lista.");
// }

//Conjunto (set)

// HashSet<int> conjunto = new HashSet<int> {1, 2, 3};
// conjunto.Add(4);
// conjunto.Add(2);

// Console.WriteLine("Elementos do conjunto");
// foreach (int elemento in conjunto)
// {
//     Console.WriteLine(elemento);
// }

// HashSet<string> frutas = new HashSet<string> {"Maçã", "Banana", "Laranja"};
// frutas.Add("Uva");
// frutas.Add("Maçã");

// Console.WriteLine("Frutas no conjunto:");
// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }

// Console.WriteLine("\nVericação de existência:");
// Console.WriteLine(frutas.Contains("Banana") ? "Banana está no conjunto" : "Banana não está no conjunto");

// frutas.Remove("Laranja");
// Console.WriteLine("\nApós remover laranja:");
// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }

//1

// int[] numeros = {1,2,3,4,5};
// int soma = 0;
// for(int i = 0; i <=5; i++)
// {
//     soma+=i;
// }
// Console.WriteLine("a soma dos numeros de 1 a 5 é :" + soma);

//2
// List<string> listaDeNomes = new List<string> {"Jeane", "Wanderson","Jeane","Ryan","Jeane"};
// int contador =0;
// for (int i =0; i <listaDeNomes.Count; i++)
// {
//     if (listaDeNomes[i] == "Jeane"){
//         contador++;
//     }

// }
// Console.WriteLine($"o nome jeane aparece {contador} vezes");

//3
// HashSet<int> conjunto = new HashSet<int> {1, 2, 2, 3, 4, 4,5};
// conjunto.Add(4);
// conjunto.Add(2);

// Console.WriteLine("Elementos do conjunto");
// foreach (int elemento in conjunto)
// {
//     Console.WriteLine(elemento);
// }

//4

// HashSet<string> frutas = new HashSet<string> {"Maçã", "Banana", "Laranja"};
// frutas.Add("Uva");
// frutas.Add("Maçã");

// Console.WriteLine("Frutas no conjunto:");
// foreach (string fruta in frutas)
// {
//     Console.WriteLine(fruta);
// }

// Console.WriteLine("\nVericação de existência:");
// Console.WriteLine(frutas.Contains("Banana") ? "Banana está dentro no conjunto" : "Banana não está no conjunto");


//5

// List<int> numeros = new List<int>();
// numeros.Add(1);
// numeros.Add(2);
// numeros.Add(3);
// numeros.Add(4);
// numeros.Add(5);
// Console.WriteLine("Elementos da lista");
// foreach (int elemento in numeros)
// {
//     Console.WriteLine(elemento);
// }
