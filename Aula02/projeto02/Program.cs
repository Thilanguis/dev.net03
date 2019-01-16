using System;
using System.Collections.Generic;

namespace projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> lista = new List<Cliente>(); // cria uma lista e n sobrepoe, não precisando apendarex:, true
            {
                for (int i = 0; i < 3; i++)
                {
                    Cliente cliente = new Cliente();

                    Console.WriteLine($"Entre com o {i + 1}º de cliente:");

                    Console.WriteLine("Id do Cliente .....:");
                    cliente.IdCliente = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nnome do Cleinte...:");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Email do Cliente...:");
                    cliente.Email = Console.ReadLine();

                    lista.Add(cliente);
                }

                Console.WriteLine("Cliente gravados com sucesso!");
                Console.WriteLine("QUantidade de Clientes:" + lista.Count); //lista.count conta a quantidade de clientes da lista

                foreach(Cliente c in lista) // ele le td que vc colocar dentro, parecido com for
                {
                    Console.WriteLine("ID......:" + c.IdCliente);
                    Console.WriteLine("Nome:...:" + c.Nome);
                    Console.WriteLine("Email...:" + c.Email);
                    Console.WriteLine("--------------------");
                }

                Console.ReadKey();
            }
        }
    }
}
