int[] meuArray = new int[5];
meuArray[0] = 10;
meuArray[1] = 20;
meuArray[2] = 30;
meuArray[3] = 40;
meuArray[4] = 50;
Console.WriteLine("Numeros no array");
for (int i = 0; i < meuArray.Length; i++)
{
    Console.WriteLine(meuArray[i]);
}

//lista de elementos

List<string> listaDeNomes = new List<string> {"Nicolas", "Heitor","Elicássia"};
listaDeNomes.Add("Nicoly");

//exibindo a lista inicial

Console.WriteLine("Nomes na lista:");
for (int i =0; i <listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}

//verificar se um nome esta na lista

Console.WriteLine("\nVerificação de existência do nome Elicássia");
string nomeParaVerificar = "Elicássia";
if (listaDeNomes.Contains(nomeParaVerificar))
{
    Console.WriteLine($"{nomeParaVerificar} está na lista.");
}

else
{
    Console.WriteLine($"{nomeParaVerificar}não está na lista.");
}

//remover um nome da lista
Console.WriteLine ("\nApós remover Nicolas:");
string nomeParaRemover = "Nicolas";
bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
if(foiRemovido)
{
    Console.WriteLine($"{nomeParaRemover} foi removido da lista.");
}
else
{
    Console.WriteLine($"{nomeParaRemover} não foi encontrado na lista.");
}