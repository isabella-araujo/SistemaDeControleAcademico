using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeControleAcademico
{
    internal class Turma
    {
        public int Codigo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }

        public List<Aluno> Alunos;

        public Turma(int codigo, Disciplina disciplina, Professor professor)
        {
            Alunos = new List<Aluno>();
            Codigo = codigo;
            Disciplina = disciplina;
            Professor = professor;
        }

        public string addAluno(Aluno aluno)
        {
            if (Alunos.Count == 10)
            {
                return "Turma cheia";
            }
            else
            {
                Alunos.Add(aluno);
                return $"Aluno {aluno.Nome} adicionado";
            }
        }

        public bool abrirTurma()
        {
            if(Alunos.Count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GerarPauta()
        {
            string alunos = "\n";

            foreach (var aluno in Alunos) { alunos += $"Nome: {aluno.Nome} - Matrícula: {aluno.Matricula}\n"; }
            
            return $"\nCódigo da Turma: {Codigo}\n" +
                   $"Disciplina: {Disciplina.Nome}\n" +
                   $"Professor: {Professor.Nome}\n" +
                   $"Alunos: \n {alunos}"; 
        }

        public string toString()
        {
            return $"Código da Turma: {Codigo} \n Disciplina: {Disciplina.Nome} \n Professor: {Professor.Nome}";
        }
    }
}
