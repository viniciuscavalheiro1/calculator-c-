using System;

namespace Calculator
{
    class Program
    {
      
        static void Main(string[] args)
        {
          int op = 0;
          do{
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Menu();
            op = int.Parse(Console.ReadLine());


            switch(op) {
              case 1:
                Soma(v1, v2);
                break;
              case 2:
                Subtracao(v1, v2);
                break;
              case 3:
                Divisao(v1, v2);
                break;
              case 4:
                Multiplicacao(v1, v2);
                break;
              case 5:
                System.Environment.Exit(0);
                break;
            }

          }while(op != 5);
        }

        static void Menu() {
          Console.WriteLine("+-----------------------+");
          Console.WriteLine("|      Calculadora      |");
          Console.WriteLine("+-----------------------+");
          Console.WriteLine("|  1 - Soma             |");
          Console.WriteLine("|  2 - Subtração        |");
          Console.WriteLine("|  3 - Divisão          |");
          Console.WriteLine("|  4 - Multiplicação    |");
          Console.WriteLine("|  5 - Sair             |");
          Console.WriteLine("+-----------------------+");
          Console.WriteLine("Digite a opção: ");
        }

        static void Soma(float v1, float v2) {
          Console.WriteLine($"Resultado: {v1 + v2}");
          Console.ReadKey();
        }

        static void Subtracao(float v1, float v2) {
          Console.WriteLine($"Resultado: {v1 - v2}");
          Console.ReadKey();
        }

        static void Divisao(float v1, float v2) {
          Console.WriteLine($"Resultado: {v1 / v2}");
          Console.ReadKey();
        }

        static void Multiplicacao(float v1, float v2) {
          Console.WriteLine($"Resultado: {v1 * v2}");
          Console.ReadKey();
        }
    }
}
