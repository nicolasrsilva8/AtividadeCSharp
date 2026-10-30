// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// !! EXERCÍCIOS C# !! \\


// * EXERCÍCIO 1

// Console.Write($"Digite seu nome: ");
// string? nome = Console.ReadLine();

// Console.Write($"Digite sua idade: ");
// string? idade = Console.ReadLine();

// Console.Write($"Digite sua cidade: ");
// string? cidade = Console.ReadLine();

// Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e moro em {cidade}.");


// * EXERCÍCIO 2

// using System.Net.Http.Headers;

// Console.Write("Digite o nome do produto: ");

// string? produto = Console.ReadLine();

// Console.Write("Digite o preço do produto: ");
// decimal preco = Convert.ToDecimal(Console.ReadLine());

// Console.Write("Digite a quantidade de produtos: " );
// decimal quantidade = Convert.ToDecimal(Console.ReadLine());

// decimal PrecoTotal(decimal preco, decimal quantidade)
// {
//     return preco * quantidade;
// }

// Console.WriteLine($"\n\n Resumo do pedido: \n Produto: {produto} \n Preço: {preco} \n Quantidade: {quantidade} \n Preço Total: {PrecoTotal(preco, quantidade)}");


// * EXERCÍCIO 3

// Console.Write($"Digite a sua nota: ");
// int nota = Convert.ToInt32(Console.ReadLine());

// if (nota < 5 && nota >= 0)
// {
//     Console.WriteLine("Aluno Reprovado.");
// }
// else if( nota >= 5 && nota < 7)
// {
//     Console.WriteLine("Aluno em Recuperação.");
// }
// else if ( nota >= 7 && nota <= 10)
// {
//     Console.WriteLine("Aluno Aprovado.");
// } 
// else
// {
//     Console.WriteLine("Nota inválida.");
// }


// * EXERCÍCIO  4

// Console.Write("digite um numero: ");
// decimal numero = Convert.ToDecimal(Console.ReadLine());

// for(int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// * EXERCÍCIO 5

