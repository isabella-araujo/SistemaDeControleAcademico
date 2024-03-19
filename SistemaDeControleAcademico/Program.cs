namespace SistemaDeControleAcademico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina(123, "Matemática");

            Professor professor = new Professor(2020, "Julia Araujo");

            Turma turma = new Turma(1010, disciplina, professor);

            professor.Turma = turma;

            Console.WriteLine(turma.addAluno(new Aluno(100, "Evelyn Rosângela Silva")));
            Console.WriteLine(turma.addAluno(new Aluno(101, "João da Silva")));
            Console.WriteLine(turma.addAluno(new Aluno(102, "Maria Oliveira")));
            Console.WriteLine(turma.addAluno(new Aluno(103, "Pedro Sousa")));
            Console.WriteLine(turma.addAluno(new Aluno(104, "Ana Costa")));
            Console.WriteLine(turma.addAluno(new Aluno(105, "Luiz Pereira")));
            Console.WriteLine(turma.addAluno(new Aluno(106, "Carla Santos")));
            Console.WriteLine(turma.addAluno(new Aluno(107, "Fernanda Almeida")));

            Console.WriteLine("\nTurma aberta: " + turma.abrirTurma());

            Console.WriteLine(turma.GerarPauta());
        }
    }
}
