﻿using System;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da segunda pessoa ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");
            }
            else if (pessoa1.Idade < pessoa2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
            else {
                Console.WriteLine($"{pessoa1.Nome} e {pessoa2.Nome} tem a mesma idade");
            }
        }
    }
}