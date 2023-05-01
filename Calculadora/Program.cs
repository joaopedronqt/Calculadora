using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Soma();
        //    Subtracao();
        //    Multiplicacao();
        //    Divisao();
           Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("-----------------------");
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicacao");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Selecione um opcao");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(s: Console.ReadLine());
            
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(s: Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"resultado da soma é igual a: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
           Console.Clear();
           
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(s: Console.ReadLine());
           
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(s: Console.ReadLine());

            float resultadoSubtracao = v1 - v2;
            Console.WriteLine($"resultado da Subtracao é igual a: {resultadoSubtracao}"); 
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(s: Console.ReadLine());
            
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(s: Console.ReadLine());

            float resultadoMultiplicacao = v1 * v2;
            Console.WriteLine($"resultado da Multiplicacao é igual a: {resultadoMultiplicacao}"); 
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(s: Console.ReadLine());
            
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(s: Console.ReadLine());

            float resultadoDivisao = v1 / v2;
            Console.WriteLine($"resultado da Divisao é igual a: {resultadoDivisao}");
            Console.ReadKey();
            Menu();
        }
    }
}
