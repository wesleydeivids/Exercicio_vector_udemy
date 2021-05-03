using System;

namespace Aluguel_quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("How many room will be rented: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"rent#{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("email: ");
                string email = Console.ReadLine();
                Console.Write("room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Estudante(name, email);
            }
            Console.WriteLine(" ");
            Console.WriteLine("rented rooms");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i +": " + vect[i]);
                }
            }
        }
    }
}
