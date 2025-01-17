using System; // TODO CONSTRUTOR É PÚBLICO

class Pessoa
{
    // Construtor 1
    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }

    // Construtor 2
    public Pessoa(string nome)
    {
        Console.WriteLine("Olá"+nome);
    }
}