using System.Security.Cryptography.X509Certificates;

Console.WriteLine( "informe seu nome");
string nome = Console.ReadLine();
Console.WriteLine("informe seu salario");
decimal salarioSrt = decimal.Parse(Console.ReadLine());

Console.WriteLine($"meu nome é" {nome} "meu salario é"{salario} );
Console.WriteLine("seja bem-vinda(o) {0}, o salario informado foi {1}", nome, salario);