using System;

class Program
{
    static void MenuFilosofo(Filosofo f)
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("MENU " + f.Nome);
            Console.WriteLine("1 - Pensar");
            Console.WriteLine("2 - Pegar Faca");
            Console.WriteLine("3 - Pegar Garfo");
            Console.WriteLine("4 - Comer");
            Console.WriteLine("5 - Devolver Talheres");
            Console.WriteLine("0 - Voltar");

            Console.Write("\nEscolha: ");
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    f.Pensar();
                    break;

                case 2:
                    f.PegarFaca();
                    break;

                case 3:
                    f.PegarGarfo();
                    break;

                case 4:
                    f.Comer();
                    break;

                case 5:
                    f.DevolverTalheres();
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }

    static void Main()
    {
        Talheres talheres = new Talheres();

        Filosofo F1 = new Filosofo("F1", talheres);
        Filosofo F2 = new Filosofo("F2", talheres);

        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("CONTROLE DOS FILOSOFOS\n");

            Console.WriteLine("1 - Filosofo F1");
            Console.WriteLine("2 - Filosofo F2");
            Console.WriteLine("0 - Sair");

            Console.Write("\nEscolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    MenuFilosofo(F1);
                    break;

                case 2:
                    MenuFilosofo(F2);
                    break;
            }

        } while (opcao != 0);
    }
}