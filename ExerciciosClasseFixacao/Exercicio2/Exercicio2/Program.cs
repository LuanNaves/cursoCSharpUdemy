﻿using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();
            double porcentagem;

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {funcionario}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {funcionario}");
        }
    }
}