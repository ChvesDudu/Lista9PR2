using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31._05
{
    internal class Program
    {
        public static void Ex1()
        {
            Console.WriteLine("Ex1");
            
            {
                Console.Write("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];
                Random random = new Random();

                for (int i = 0; i < tamanho; i++)
                {
                    vetor[i] = random.Next(1, 101); // Intervalo de 1 a 100
                }

                Console.WriteLine("Vetor:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(vetor[i] + " ");
                }

                double soma = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    soma += vetor[i];
                }

                double media = soma / tamanho;
                Console.WriteLine("\nMédia aritmética: " + media);
            }
        }
        public static void Ex2()
        {
            Console.WriteLine("Ex2");

            {
                Console.Write("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];
                Random random = new Random();

                for (int i = 0; i < tamanho; i++)
                {
                    vetor[i] = random.Next(1, 101); // Intervalo de 1 a 100
                }

                Console.WriteLine("Vetor:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(vetor[i] + " ");
                }

                int somaPares = 0;
                int somaImpares = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] % 2 == 0)
                    {
                        somaPares += vetor[i];
                    }
                    else
                    {
                        somaImpares += vetor[i];
                    }
                }

                Console.WriteLine("\nSoma dos valores pares: " + somaPares);
                Console.WriteLine("Soma dos valores ímpares: " + somaImpares);
            }
        }
        public static void Ex3()
        {
            Console.WriteLine("Ex3");

            {
                Console.Write("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];
                Random random = new Random();

                for (int i = 0; i < tamanho; i++)
                {
                    vetor[i] = random.Next(1, 101); // Intervalo de 1 a 100
                }

                Console.WriteLine("Vetor original:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(vetor[i] + " ");
                }

                Array.Sort(vetor); // Ordena o vetor em ordem crescente

                Console.WriteLine("\nVetor em ordem crescente:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(vetor[i] + " ");
                }

                Array.Reverse(vetor); // Inverte a ordem do vetor

                Console.WriteLine("\nVetor em ordem decrescente:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
        }
        public static void Ex4()
        {
            Console.WriteLine("Ex4");

            {
                Console.Write("Digite o tamanho do vetor: ");
                int tamanho = int.Parse(Console.ReadLine());

                int[] vetor = new int[tamanho];
                Random random = new Random();

                for (int i = 0; i < tamanho; i++)
                {
                    vetor[i] = random.Next(1, 101); // Intervalo de 1 a 100
                }

                Console.WriteLine("Vetor:");
                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(vetor[i] + " ");
                }

                int somaDivisiveis = 0;
                int countDivisiveis = 0;
                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] % 3 == 0 && vetor[i] % 5 == 0)
                    {
                        somaDivisiveis += vetor[i];
                        countDivisiveis++;
                    }
                }

                double mediaDivisiveis = (countDivisiveis > 0) ? (double)somaDivisiveis / countDivisiveis : 0;

                Console.WriteLine("\nValores divisíveis por 3 e por 5:");
                for (int i = 0; i < tamanho; i++)
                {
                    if (vetor[i] % 3 == 0 && vetor[i] % 5 == 0)
                    {
                        Console.Write(vetor[i] + " ");
                    }
                }

                Console.WriteLine("\nMédia aritmética dos valores divisíveis por 3 e por 5: " + mediaDivisiveis);
            }
        }

        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("=============MENU=============");
                Console.WriteLine("Para executar ex 1 - digite 1");
                Console.WriteLine("Para executar ex 2 - digite 2");
                Console.WriteLine("Para executar ex 3 - digite 3");
                Console.WriteLine("Para executar ex 3 - digite 4");
                Console.WriteLine("==============================");

                opcao = int.Parse(Console.ReadLine()); //Lê a opção escolhida
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Thanks for using my system!");
                        break;

                    case 1:
                        Ex1();
                        break;

                    case 2:
                        Ex2();
                        break;

                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Ex4();
                        break;
                }

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}
