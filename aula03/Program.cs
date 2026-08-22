using System;

class Produto
{
    public string Nome;
    public double Preco;
    public Produto(string nome, double preco)
    {
        Nome = nome; Preco = preco;
    }
    public void Exibir()
    {
        Console.WriteLine(Nome + " - " + Preco);
    }
}

// Exercício 1 e 2
class Pessoa
{
    public string Nome;
    public int Idade;

    // Construtor (utilizado no exercício 2)
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }
}
// Exercício 3
class Conta
{
    public int Numero;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        Saldo -= valor;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
    }
}
// Desafio
class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;

    public double CalcularMedia()
    {
        return (Nota1 + Nota2) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto("Notebook", 3500);
        p.Exibir();

        // ==========================
        // EXERCÍCIO 1 E 2 - PESSOA
        // ==========================

        Console.WriteLine("=== EXERCÍCIO 1 E 2 ===");

        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade da pessoa: ");
        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

        Console.WriteLine("\nDados da pessoa:");
        pessoa.ExibirDados();

        // ==========================
        // EXERCÍCIO 3 - CONTA
        // ==========================

        Console.WriteLine("\n=== EXERCÍCIO 3 ===");

        Conta conta = new Conta();

        Console.Write("Número da conta: ");
        conta.Numero = int.Parse(Console.ReadLine());

        Console.Write("Valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine());

        conta.Depositar(deposito);

        Console.Write("Valor para saque: ");
        double saque = double.Parse(Console.ReadLine());

        conta.Sacar(saque);

        conta.ExibirSaldo();

        // ==========================
        // DESAFIO - ALUNO
        // ==========================

        Console.WriteLine("\n=== DESAFIO ===");

        Aluno aluno = new Aluno();

        Console.Write("Nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Nota 1: ");
        aluno.Nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        aluno.Nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nAluno: {aluno.Nome}");
        Console.WriteLine($"Média: {aluno.CalcularMedia():F2}");
    }
}

