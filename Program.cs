using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> usuarios = new List<string>();
        int opcao;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Adicionar Usuário");
            Console.WriteLine("2. Listar Usuários");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do usuário: ");
                        string nome = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(nome))
                        {
                            usuarios.Add(nome);
                            Console.WriteLine("Usuário cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Nome inválido. Tente novamente.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Lista de Usuários ---");
                        if (usuarios.Count > 0)
                        {
                            foreach (var usuario in usuarios)
                            {
                                Console.WriteLine(usuario);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum usuário cadastrado.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número.");
            }
        } while (opcao != 3);
    }
}
