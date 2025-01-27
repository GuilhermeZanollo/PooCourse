using System;

abstract class Padrao
{
    // Obrigatório
    public abstract void taxaEmprestimo(double valor); // no método obrigatório precisa ser public, void, taxaEmprestimoo, pedindo obrigatoriamente parametro.

    // Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor * taxa));
    }
}