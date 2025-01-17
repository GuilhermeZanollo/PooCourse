using System;

class Colaborador : Pessoa // PARA FAZER HERANÇA É SÓ ADICIONAR ":" e o nome da classe, nesse caso precisava utilizar a string this NOME, porem nao tem nessa classe
{
    // Atributos
    private double salario;

    // Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome; //this nome recebe nome
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // Método
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }
}