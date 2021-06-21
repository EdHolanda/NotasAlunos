using System;
using System.Collections.Generic;
using System.Text;

namespace NotasAlunos
{
    public class Aluno
    {
        public string Nome {get; set;}
        public List<double> Notas {get; set;}

        public double CalculaMedia()
        {
            double soma = 0;
            foreach (double nota in this.Notas)
            {
                soma += nota;
            }
            double media = soma / this.Notas.Count;
            return (media);
        }

    }
}
