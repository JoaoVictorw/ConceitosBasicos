using System;

namespace ExerciseMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Run();
        }
    }

    class Menu
    {
        public void Run()
        {
            int choice;
            do
            {
                Console.WriteLine("Menu de Exercícios:");
                Console.WriteLine("0) Sair");
                Console.WriteLine("1) Somar Números");
                Console.WriteLine("2) Converter de Metros para Milímetros");
                Console.WriteLine("3) Calcular Aumento (Método com retorno / Sequência de Fibonacci até um número N - Método estático)");
                Console.Write("Digite sua escolha: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa.");
                        break;
                    case 1:
                        SomaNumeros();
                        break;
                    case 2:
                        ConverterMetrosEmMillimetros();
                        break;
                    case 3:
                        CalculeAumento();
                        SequenciaDeFibonacci();
                        break;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }
            } while (choice != 0);
        }

        static void SomaNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine($"Soma: {soma}");
        }

        static void ConverterMetrosEmMillimetros()
        {
            Console.Write("Digite o comprimento em metros: ");
            double metros = double.Parse(Console.ReadLine());
            double milimetros = metros * 1000;
            Console.WriteLine($"Comprimento em milímetros: {milimetros}");
        }

        static void CalculeAumento()
        {
            Console.Write("Digite o salário atual: ");
            double salarioAtual = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de aumento: ");
            double percentualAumento = double.Parse(Console.ReadLine());

            double novoSalario = CalcularAumento(salarioAtual, percentualAumento);

            Console.WriteLine($"O novo salário após o aumento é: {novoSalario:C}");
        }
        static double CalcularAumento(double salarioAtual, double percentualAumento)
        {
            double novoSalario = salarioAtual * (1 + percentualAumento / 100);
            return novoSalario;
        }

        static void SequenciaDeFibonacci()
        {
            Console.Write("Digite o valor de N para a sequência de Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;
            Console.Write("Sequência de Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {a}");
                int temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine();
        }
    }
}