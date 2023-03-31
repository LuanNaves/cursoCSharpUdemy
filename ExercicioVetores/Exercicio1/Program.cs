using System;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            Student[] rent = new Student[10];

            Console.Write("How many rooms will be rented? ");
            int rentedRooms = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < rentedRooms; i++) {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                rent[room] = new Student(name, email, room);

                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0;i < rent.Length;i++) {
                if (rent[i] != null) {
                    Console.WriteLine(rent[i]);
                }
            }
        }
    }
}