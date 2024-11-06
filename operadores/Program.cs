// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//E lógico
bool a1 = true;
bool b1 = false;
Console.WriteLine(a1 && b1);

//OR lógico || (OU)
bool a2= true;
bool b2 = false;
Console.WriteLine (a2 || b2);

//NOT lógico !(NÂO)
bool a3 = true;
Console.WriteLine( !a3 );

//XOR lógico ^ (OU EXCLUSIVO)
bool a4 = true;
bool b3 = false;
Console.WriteLine(a4^b3);

//Exemplo de precendencia
bool a5 = true;
bool b4 = false;
bool c1 = false;
bool resultado = !a5 || (b4 && c1);
Console.WriteLine(resultado);

// exemplo de precedencia 

bool a6 = true;
bool b5 = false;
bool c2 = false;
bool Resultado = !a6 || b5 && c2;
Console.WriteLine(resultado);
