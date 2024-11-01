// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//tipos de dados primitivos 
//Numeros inteiros
short ano = 2025;
int contador = 10;
long populacaoMundial = 7800000000;

//Numeros de ponto flutuante
float temperatura = 43.6f;
double precoProduto = 199.90;

//tipo caracter
char inicial = "W";

//tipos logicos
bool estaLogado = true;
bool ativo = false;

// tipos de dados não primitivos 
string saudacao = "Olá mundo!";

//Arrays
int[] numeros = {1,2,3,4,5};
string[] nomes = {"Nicolas","Heitor","Nicoly"};

//tipo classe 
public class pessoa
{
    public string nome;
    
    public int idade;
}
//structs
public class ponto
{
    public int X;
    public int Y;
}


//Enuns
public enum diaDaSemana 
{
    Segunda,Terça,Quarta,Quinta,Sexta,Sabado,Domingo
}

//interfaces
public interface IVeiculo
{
    void Mover();
}

//delegates 
public void deLegates Processar(int numero);

//Nullable types
int? idade = null;
