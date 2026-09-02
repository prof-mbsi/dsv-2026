using System;

#region Classes Exercícios 1, 2 e 3

class Disciplina
{
    public string Nome;
    public int CargaHoraria;

    public Disciplina(string nome, int cargaHoraria)
    {
        Nome = nome;
        CargaHoraria = cargaHoraria;
    }
}

class Aluno
{
    public string Nome;
    public Disciplina Disciplina;
    public Disciplina[] Disciplinas;

    public Aluno(string nome, Disciplina disciplina)
    {
        Nome = nome;
        Disciplina = disciplina;
    }

    public Aluno(string nome, Disciplina[] disciplinas)
    {
        Nome = nome;
        Disciplinas = disciplinas;
    }
}

#endregion

#region Classes Desafio

class Turma
{
    public string Nome;
    public AlunoTurma[] Alunos;

    public Turma(string nome, AlunoTurma[] alunos)
    {
        Nome = nome;
        Alunos = alunos;
    }
}

class AlunoTurma
{
    public string Nome;
    public Disciplina[] Disciplinas;

    public AlunoTurma(string nome, Disciplina[] disciplinas)
    {
        Nome = nome;
        Disciplinas = disciplinas;
    }
}

#endregion

class Program
{
    static void Main(string[] args)
    {
        // ======================================================
        // EXERCÍCIO 1 - Aluno e Disciplina
        // ======================================================

        Disciplina disciplina = new Disciplina(
            "Desenvolvimento de Software Visual",
            80);

        Aluno aluno = new Aluno(
            "João",
            disciplina);

        Console.WriteLine("EXERCÍCIO 1");
        Console.WriteLine($"Aluno: {aluno.Nome}");
        Console.WriteLine($"Disciplina: {aluno.Disciplina.Nome}");
        Console.WriteLine($"Carga Horária: {aluno.Disciplina.CargaHoraria}h");


        Console.WriteLine("\n=====================================\n");


        // ======================================================
        // EXERCÍCIO 2 - Aluno com várias disciplinas
        // ======================================================

        Disciplina[] disciplinasAluno =
        {
            new Disciplina("Programação", 80),
            new Disciplina("Banco de Dados", 60),
            new Disciplina("Redes", 40),
            new Disciplina("Engenharia de Software", 80)
        };

        Aluno aluno2 = new Aluno(
            "Maria",
            disciplinasAluno);

        Console.WriteLine("EXERCÍCIO 2");
        Console.WriteLine($"Aluno: {aluno2.Nome}");
        Console.WriteLine("Disciplinas:");

        foreach (Disciplina d in aluno2.Disciplinas)
        {
            Console.WriteLine(
                $"{d.Nome} - {d.CargaHoraria}h");
        }


        Console.WriteLine("\n=====================================\n");


        // ======================================================
        // EXERCÍCIO 3 - Carga horária total
        // ======================================================

        int cargaTotal = 0;

        foreach (Disciplina d in aluno2.Disciplinas)
        {
            cargaTotal += d.CargaHoraria;
        }

        Console.WriteLine("EXERCÍCIO 3");
        Console.WriteLine($"Aluno: {aluno2.Nome}");
        Console.WriteLine($"Carga horária total: {cargaTotal}h");


        Console.WriteLine("\n=====================================\n");


        // ======================================================
        // DESAFIO
        // ======================================================

        AlunoTurma alunoA = new AlunoTurma(
            "Carlos",
            new Disciplina[]
            {
                new Disciplina("Programação",80),
                new Disciplina("Banco de Dados",60),
                new Disciplina("Redes",40)
            });

        AlunoTurma alunoB = new AlunoTurma(
            "Fernanda",
            new Disciplina[]
            {
                new Disciplina("Engenharia de Software",80),
                new Disciplina("Programação Web",60),
                new Disciplina("UX/UI",40)
            });

        AlunoTurma alunoC = new AlunoTurma(
            "Pedro",
            new Disciplina[]
            {
                new Disciplina("Algoritmos",80),
                new Disciplina("Estruturas de Dados",60),
                new Disciplina("Sistemas Operacionais",60)
            });

        Turma turma = new Turma(
            "ADS 2026",
            new AlunoTurma[]
            {
                alunoA,
                alunoB,
                alunoC
            });

        int totalDisciplinas = 0;

        Console.WriteLine("DESAFIO");
        Console.WriteLine($"Turma: {turma.Nome}");

        foreach (AlunoTurma a in turma.Alunos)
        {
            Console.WriteLine($"\nAluno: {a.Nome}");

            foreach (Disciplina d in a.Disciplinas)
            {
                Console.WriteLine(
                    $" - {d.Nome} ({d.CargaHoraria}h)");

                totalDisciplinas++;
            }
        }

        Console.WriteLine(
            $"\nTotal de disciplinas cadastradas na turma: {totalDisciplinas}");
    }
}