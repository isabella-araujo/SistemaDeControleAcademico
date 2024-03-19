using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeControleAcademico
{
    internal class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public string toString()
        {
            return $"Código: {Codigo} - Nome: {Nome}";
        }
    }
}
