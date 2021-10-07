using System;
using System.Text;

class MainClass
{
    String a = "";
    String b = "";
    String c = "";

    static void Main(string[] args)
    {
        var programa = new MainClass();
        programa.run();
    }

    public void run()
    {
        a = Console.ReadLine();
        b = Console.ReadLine();
        c = Console.ReadLine();

        if (a.Equals("vertebrado")) this.vertebrado();

        else this.invertebrado();

    }

    public void vertebrado()
    {
        if (b.Equals("ave")) this.ave();

        else this.mamifero();
    }

    public void ave()
    {
        if (c.Equals("carnivoro")) Console.WriteLine("aguia");

        else Console.WriteLine("pomba");
    }

    public void mamifero()
    {
        if (c.Equals("onivoro")) Console.WriteLine("homem");

        else Console.WriteLine("vaca");

    }

    public void invertebrado()
    {
        if (b.Equals("inseto")) this.inseto();

        else this.anelideo();

    }

    private void inseto()
    {
        if (c.Equals("hematofago")) Console.WriteLine("pulga");

        else Console.WriteLine("lagarta");
    }

    private void anelideo()
    {
        if (c.Equals("hematofago")) Console.WriteLine("sanguessuga");

        else Console.WriteLine("minhoca");
    }
}