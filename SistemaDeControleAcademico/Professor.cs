using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeControleAcademico
{
    internal class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Turma? Turma { get; set; }

        public Professor(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public string toString()
        {
            return  $"Nome: {Nome} \n Matricula: {Matricula} \n Turma: {Turma}";
        }
    }
}
