﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

           System.Console.WriteLine(" ========================================== ");
           System.Console.WriteLine(" Bem-vindo a sua  Calculadora em Console ");
           System.Console.WriteLine(" ========================================== ");



         Soma();

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
        }
    }
}
