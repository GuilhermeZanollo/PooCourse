using System;

class Pessoa
{
    // Atributos
    protected string? nome; // protected só pode ser acessada seus atributos e métodos por outra classe por meio de extend ou ":"
    protected int idade;

    // Método
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
    }
}