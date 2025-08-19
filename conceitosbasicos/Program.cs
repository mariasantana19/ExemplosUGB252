/*
try
{

    Console.WriteLine("informe seu nome");
    string nome = Console.ReadLine();
    Console.WriteLine("informe seu salario");
    decimal salario = decimal.Parse(Console.ReadLine());

    Console.WriteLine("seja bem-vinda(o) {0}, o salario informado foi {1}", nome, salario);

    //informem o valor do IRPF  a ser pago de acordo com o salario informado. Utiliza a tabela real de desconto de IRPF.

    decimal irpfDevido;
    if (salario <= 2259.20m)
        irpfDevido = 0;

    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 169.21m;

    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 381.44m;

    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 662.77m;

    else
        irpfDevido = salario * 0.275m - 896m;

    Console.WriteLine($"para o salario de {salario} o valor a ser pago de IRPF é{irpfDevido}, entao o salario com desconto de IRPF sera {salario - irpfDevido}");

}

catch (FormatException)
{

    Console.WriteLine("o salario deve ser informado em formato numerico");

}
catch (Exception e)
{

    Console.WriteLine("ocorreu um erro. Informe ao suporte tecnico");
    Console.WriteLine(e.StackTrace);




}
*/

using conceitosbasicos.uteis;
SomaDoisNumeros SomaDoisNumeros;
SomaDoisNumeros = new SomaDoisNumeros();
int resultado = SomaDoisNumeros.Somar(20, 22);
Console.WriteLine(resultado);


int milimetros = MetrosMilimetros.Converter(2);

