using System;

class Program
{
    // F1 comeu
    static void F1Comeu()
    {
        Console.WriteLine("----- F1 Comeu -----");

        Console.WriteLine("P1 - F1 está pensando");
        Console.WriteLine("α1 - F1 pegou a faca");
        Console.WriteLine("β1 - F1 pegou o garfo");
        Console.WriteLine("C1 - F1 está comendo");
        Console.WriteLine("γ1 - F1 devolveu os talheres");
        Console.WriteLine("P1 - F1 voltou a pensar");

        Console.WriteLine();
    }

    // F2 comeu
    static void F2Comeu()
    {
        Console.WriteLine("----- F2 Comeu -----");

        Console.WriteLine("P2 - F2 está pensando");
        Console.WriteLine("α2 - F2 pegou a faca");
        Console.WriteLine("β2 - F2 pegou o garfo");
        Console.WriteLine("C2 - F2 está comendo");
        Console.WriteLine("γ2 - F2 devolveu os talheres");
        Console.WriteLine("P2 - F2 voltou a pensar");

        Console.WriteLine();
    }

    // F2 e F1 comeram
    static void F2eF1Comeu()
    {
        Console.WriteLine("===== F2 e F1 Comeram =====");

        F2Comeu();
        F1Comeu();
    }

    // F1 e F2 comeram
    static void F1eF2Comeu()
    {
        Console.WriteLine("===== F1 e F2 Comeram =====");

        F1Comeu();
        F2Comeu();
    }

    // MENU
    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("PROJETO FILOSOFOS");
            Console.WriteLine("1 - F1 comeu");
            Console.WriteLine("2 - F2 comeu");
            Console.WriteLine("3 - F2 e F1 comeram");
            Console.WriteLine("4 - F1 e F2 comeram");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    F1Comeu();
                    break;

                case 2:
                    F2Comeu();
                    break;

                case 3:
                    F2eF1Comeu();
                    break;

                case 4:
                    F1eF2Comeu();
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("Pressione qualquer tecla...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }
}