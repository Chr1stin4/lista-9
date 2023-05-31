using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ex;
            Console.WriteLine("========Menu========");
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Exercício 6");
            switch (Ex) {

                case 1:

            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 101); // Valores aleatórios entre 1 e 100
            }

            Console.WriteLine("Vetor gerado:");
            foreach (int valor in vetor)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();

            double soma = 0;
            foreach (int valor in vetor)
            {
                soma += valor;
            }

            double media = soma / tamanho;
            Console.WriteLine("Média aritmética: " + media);


            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 101); // Valores aleatórios entre 1 e 100
            }





            Console.WriteLine("Vetor gerado:");
            foreach (int valor in vetor)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();

            int somaPares = 0;
            int somaImpares = 0;

            foreach (int valor in vetor)
            {
                if (valor % 2 == 0)
                {
                    somaPares += valor;
                }
                else
                {
                    somaImpares += valor;
                }
            }

            Console.WriteLine("Soma dos valores pares: " + somaPares);
            Console.WriteLine("Soma dos valores ímpares: " + somaImpares);
        }
    }
}
