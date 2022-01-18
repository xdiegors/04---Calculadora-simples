// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua opção:");
Console.WriteLine("1 - Somar");
Console.WriteLine("2 - Subtrair");
Console.WriteLine("3 - Multiplicar");
Console.WriteLine("4 - Dividir");

string opcaoSelecionada = Console.ReadLine();

int primeiroNumero;
int segundoNumero;
int resultado;

switch (opcaoSelecionada) 
{
    case "1" : Console.WriteLine("Digite dois números para serem somados:");
        Console.WriteLine("Digite o primeiro número:");
        primeiroNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        segundoNumero = int.Parse(Console.ReadLine());

        resultado = primeiroNumero + segundoNumero;

        Console.WriteLine("O resultado da soma é: " + resultado);

        break;

    case "2":  Console.WriteLine("Você escolheu 2");
        Console.WriteLine("Digite o primeiro número:");
        primeiroNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        segundoNumero = int.Parse(Console.ReadLine());

        resultado = primeiroNumero - segundoNumero;

        Console.WriteLine("O resultado da subtração é: " + resultado);
    break;

    case "3":
        Console.WriteLine("Digite o primeiro número:");
        primeiroNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        segundoNumero = int.Parse(Console.ReadLine());

        resultado = primeiroNumero * segundoNumero;

        Console.WriteLine("O resultado da multiplicação é: " + resultado);
    break;

    case "4":
        Console.WriteLine("Digite o primeiro número:");
        primeiroNumero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        segundoNumero = int.Parse(Console.ReadLine());

        resultado = primeiroNumero / segundoNumero;

        Console.WriteLine("O resultado da divisão é: " + resultado);
    break;
}