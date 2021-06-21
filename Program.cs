using System;
using System.Collections.Generic;

namespace NotasAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            var QtdNotas = 3;
            List<Aluno> Alunos = new List<Aluno>();
            Console.WriteLine("Digite a quantidade de alunos:");
            int QtdAlunos = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < QtdAlunos; i++)
            {
                var aluno = new Aluno();
                Console.WriteLine($"Digite o nome do aluno {i + 1}");
                aluno.Nome = Console.ReadLine();
                aluno.Notas = new List<double>();
                
                for (int n = 0; n < QtdNotas; n++)
                {
                    Console.WriteLine($"Digite a nota {n + 1} do aluno {aluno.Nome}");
                    aluno.Notas.Add(Convert.ToDouble(Console.ReadLine()));
                }
                Alunos.Add(aluno);

            }
            
            Console.Clear();

            foreach (var aluno in Alunos)
            {
                Console.WriteLine("=========================");
                Console.WriteLine($"Nome {aluno.Nome}");
                double notas = 0;
                for (int i = 0; i < aluno.Notas.Count; i++)
                {
                    Console.WriteLine($"Nota {i + 1} - {aluno.Notas[i]: 0.0}");
                    /*notas += aluno.Notas[i];*/
                }

                Console.WriteLine($"Média - {aluno.CalculaMedia(): 0.0}");
            }
            Console.WriteLine("=========================");
        }

    }
}
