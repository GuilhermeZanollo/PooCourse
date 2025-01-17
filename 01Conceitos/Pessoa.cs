using System;

class Pessoa // Uma classe é um molde, algo muito abstrato // Olha, eu quero trabalhar com uma pessoa
{
    // Atributos
    public string nome; // public para ter acesso em qualquer classe
    public int idade;

    public void mensagem() // void == nulo quando não há retorno
    {
        Console.WriteLine(" Olá " +nome+ ", você tem " +idade+ " anos! ");
    }

}