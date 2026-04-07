using System;

public class Filosofo
{
    public string Nome;
    private Talheres talheres;

    public Filosofo(string nome, Talheres t)
    {
        Nome = nome;
        talheres = t;
    }

    public void Pensar()
    {
        Console.WriteLine(Nome + " está pensando ");
    }

    public void PegarFaca()
    {
        if (talheres.FacaLivre)
        {
            talheres.FacaLivre = false;
            talheres.DonoFaca = Nome;
            Console.WriteLine(Nome + " pegou a faca (α)");
        }
        else
        {
            Console.WriteLine("Não pode pegar a faca, está com " + talheres.DonoFaca);
        }
    }

    public void PegarGarfo()
    {
        if (talheres.GarfoLivre)
        {
            talheres.GarfoLivre = false;
            talheres.DonoGarfo = Nome;
            Console.WriteLine(Nome + " pegou o garfo (β)");
        }
        else
        {
            Console.WriteLine("Não pode pegar o garfo, está com " + talheres.DonoGarfo);
        }
    }

    public void Comer()
    {
        if (talheres.DonoFaca == Nome && talheres.DonoGarfo == Nome)
        {
            Console.WriteLine(Nome + " está comendo ");
        }
        else
        {
            Console.WriteLine(Nome + " não pode comer, faltam talheres");
        }
    }

    public void DevolverTalheres()
    {
        if (talheres.DonoFaca == Nome)
        {
            talheres.FacaLivre = true;
            talheres.DonoFaca = "";
        }

        if (talheres.DonoGarfo == Nome)
        {
            talheres.GarfoLivre = true;
            talheres.DonoGarfo = "";
        }

        Console.WriteLine(Nome + " devolveu os talheres ");
    }
}
