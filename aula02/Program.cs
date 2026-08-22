using System;
class Program
{
    static void Main(string[] args)
    {
        //Variáveis:
        int idade = 25;
        double altura = 1.75;
        string nome = "Maria";
        bool ativo = true;
        Console.WriteLine(nome);
        Console.WriteLine(idade);

        //Entrada de dados / Conversão com Parse:
        Console.Write("Digite seu nome: ");
        string nomeInput = Console.ReadLine();
        Console.WriteLine("Olá " + nomeInput);

        //Decisões: 
        Console.Write("Digite sua idade: ");
        int idadeInput = int.Parse(Console.ReadLine());
        if (idadeInput >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        //Loops: for e while:
        int num = 0;
        while (num < 5)
        {
            Console.WriteLine(num);
            num++;
        }

        Console.Write("Digite 5 números:");
        int[] numeros = new int[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Números informados:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine("EXERCÍCIO 1");
        Console.WriteLine("Leia 5 números e exiba-os.\n");

        int[] numerosEx1 = new int[5];

        for (int i = 0; i < numerosEx1.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numerosEx1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros informados:");

        for (int i = 0; i < numerosEx1.Length; i++)
        {
            Console.WriteLine(numerosEx1[i]);
        }

        Console.WriteLine("EXERCÍCIO 2");
        Console.WriteLine("Conte quantos números pares existem.\n");

        int[] numerosEx2 = new int[10];
        int quantidadePares = 0;

        for (int i = 0; i < numerosEx2.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numerosEx2[i] = int.Parse(Console.ReadLine());

            if (numerosEx2[i] % 2 == 0)
            {
                quantidadePares++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {quantidadePares}");

        Console.WriteLine("EXERCÍCIO 3");
        Console.WriteLine("Calcule a média de 5 notas.\n");

        double[] notas = new double[5];
        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a {i + 1}ª nota: ");
            notas[i] = double.Parse(Console.ReadLine());

            soma += notas[i];
        }

        double media = soma / notas.Length;

        Console.WriteLine($"\nMédia das notas: {media:F2}");


        Console.WriteLine("DESAFIO");
        Console.WriteLine("Informe o maior e o menor número.\n");

        int[] numerosDesafio = new int[10];

        for (int i = 0; i < numerosDesafio.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numerosDesafio[i] = int.Parse(Console.ReadLine());
        }

        int maior = numerosDesafio[0];
        int menor = numerosDesafio[0];

        for (int i = 1; i < numerosDesafio.Length; i++)
        {
            if (numerosDesafio[i] > maior)
            {
                maior = numerosDesafio[i];
            }

            if (numerosDesafio[i] < menor)
            {
                menor = numerosDesafio[i];
            }
        }

        Console.WriteLine($"\nMaior valor: {maior}");
        Console.WriteLine($"Menor valor: {menor}");
    }
}