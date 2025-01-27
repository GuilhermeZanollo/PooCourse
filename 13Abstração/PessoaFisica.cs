using System;

class PessoaFisica : Padrao
{
    // Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pessoa Física R$ "+(valor * 0.1));
    }
}