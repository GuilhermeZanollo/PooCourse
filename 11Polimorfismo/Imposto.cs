using System; // possui acesso ao console

class Imposto
{
    // Métodos
    public virtual void valeAlimentacao(double salario) // PRECISEI ADICIONAR VIRTUAL PARA QUE LIBERASSE A UTILIZAÇÃO DO OVERRIDE NAS CLASSES GERENTE E ATENDENTE
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$"+(salario * 0.1));
    }

    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto com padrão do vale transporte R$"+(salario * 0.06));
    }
}