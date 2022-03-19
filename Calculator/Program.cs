using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

         
        Menu();

        }

        static  void Menu()
        {

            System.Console.Clear();


            System.Console.WriteLine(" ========================================== ");
            System.Console.WriteLine("  Bem-vindo a sua  Calculadora em Console ");
            System.Console.WriteLine(" ========================================== ");

            System.Console.WriteLine("");
            System.Console.WriteLine(" Qual  cálculo  deseja  efetuar ? ");
            System.Console.WriteLine("");

            System.Console.WriteLine(" 1 - Soma ");
            System.Console.WriteLine(" 2 - Subtração ");
            System.Console.WriteLine(" 3 - Divisão ");
            System.Console.WriteLine(" 4 - multiplicação ");
            System.Console.WriteLine(" 5 - Sair ");

            System.Console.WriteLine();
            System.Console.WriteLine(" ========================================== ");
            System.Console.WriteLine("           Selecione uma  opção:  ");
            System.Console.WriteLine(" ========================================== ");
            System.Console.WriteLine("");
            
            short opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: Soma(); ;break;
                case 2: Subtracao();break;
                case 3: Divisao(); break;
                case 4: Multipicacao();break;
                case 5: Finalizar();break;
                default: Menu();break;
            }


        }

        static void Soma()

        {

          
           System.Console.Clear();
              
           System.Console.WriteLine("");

           System.Console.Write(" Digite o primeiro valor: ");
           float v1 = float.Parse(Console.ReadLine());

           System.Console.Write(" Digite o segundo  valor: ");
           float v2 = float.Parse(Console.ReadLine());

           System.Console.WriteLine("");
           float resultado = v1 + v2;

           System.Console.WriteLine($" O resultado da soma de {v1} + {v2} é = {resultado}");
           System.Console.WriteLine();
           System.Console.ReadKey();
           Menu();

        }
        static void Subtracao()
        {
            System.Console.Clear();

            System.Console.WriteLine("");

            System.Console.Write(" Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.Write(" Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            float resultado = v1 - v2;

            System.Console.Write($" O resultado da subtração de {v1} - {v2} é = {resultado}");
            System.Console.Write("");
            System.Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            System.Console.Clear();

            System.Console.WriteLine("");

            System.Console.Write(" Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            System.Console.Write(" Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            float resultado = v1 / v2;

            System.Console.WriteLine($" O resultado da divisão de {v1} / {v2} é = {resultado}");
            System.Console.WriteLine("");
            System.Console.ReadKey();
            Menu();
        }

        static void Multipicacao()
        {
            System.Console.Clear();

            System.Console.WriteLine("");

            System.Console.Write(" Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            System.Console.Write(" Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            float resultado  = v1 * v2;

            System.Console.WriteLine($"O resultado da multiplicação de {v1} x {v2} é = {resultado} ");
            System.Console.WriteLine("");
            System.Console.ReadKey();
            Menu();
        }

        static void Finalizar()
        {
            
            System.Console.Clear();
            System.Console.WriteLine("");

            System.Console.WriteLine(" ==================================================== ");
            System.Console.WriteLine("   Obrigado por utilizar a Calculadora em Console ");
            System.Console.WriteLine(" ==================================================== ");

            System.Environment.Exit(0);
            //Encerrando aplicação em console
        }

    }
    
}
