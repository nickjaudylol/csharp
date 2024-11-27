using System.Reflection.Metadata.Ecma335;

Console.Title = "Calculadora";
            Console.WriteLine("============================ Calculadora ============================ ");


            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, valorDigitado;
            bool isNumeroInteiro;


            Console.WriteLine("Digite o 1 valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);
            if (isNumeroInteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }


            Console.WriteLine("Digite a operação (' / , + , * , -'): ");
            operador = Console.ReadLine();


            Console.WriteLine("Digite o 2 valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);
            if (isNumeroInteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }


            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }


            Console.ReadKey();
        
    public double Dividir(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b==0)
        {
            Console.WriteLine("Erro: Divisao por zero nao permitida");
            return double.NaN;
        }
        return a/b;
            }