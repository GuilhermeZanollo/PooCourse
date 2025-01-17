using System;

class Pessoa
{
    // Atributo
    private string nome = "Tatiane";

    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); // PARA CHAMAR ATRIBUTO "TATIANE", EU UTILIZO O THIS
    }
}