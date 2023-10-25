using System;


// Cria as variáveis para armazenar os valores
string? nome;
string? profissao;
string? telefone;
string? email;
string? descricao;

// Solicita as informações do cartão
Console.WriteLine("Digite o seu  nome");
nome = Console.ReadLine();

Console.WriteLine("Digite sua profissão?");
profissao = Console.ReadLine();

Console.WriteLine("Digite seu telefone");
telefone = Console.ReadLine();

Console.WriteLine("Digite seu e-mail");
email = Console.ReadLine();

Console.WriteLine("Digite sua descrição");
descricao = Console.ReadLine();


Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
Console.WriteLine("X                                        X");
Console.WriteLine("X               "+ nome +"               X");
Console.WriteLine("X            "+ profissao +"             X");
Console.WriteLine("X             "+ telefone +"             X");
Console.WriteLine("X              "+ email +"               X");
Console.WriteLine("X            "+ descricao +"             X");
Console.WriteLine("X                                        X");
Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");