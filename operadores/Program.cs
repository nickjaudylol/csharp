// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//E lógico
bool a = true;
bool b = false;
Console.WriteLine(a && b);

//OR lógico || (OU)
bool a1 = true;
bool b2 = false;
Console.WriteLine (a || b);

//NOT lógico !(NÂO)
bool a3 = true;
Console.WriteLine( !a );

//XOR lógico ^ (OU EXCLUSIVO)
bool a4 = true;
bool b4 = false;
Console.WriteLine(a^b);

//Exemplo de precendencia
bool a5 = true;
bool b5 = false;
bool c5 = false;
bool resultado = !a || (b && c);
Console.Writeline(resultado);

// exemplo de precedencia 

bool a6 = true;
bool b6 = false;
bool c6 = false;
bool resultado = !a || b && c;
Console.Writeline(resultado);

