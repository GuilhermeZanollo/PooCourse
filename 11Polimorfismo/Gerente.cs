class Gerente : Imposto // CRIA ACESSO AOS 2 MÉTODOS DA CLASSE IMPOSTO e SOBREESCREVE O METODO DE VALE ALIMENTAÇÃO
{
    //Método
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$"+(salario*0.15));
    }
}