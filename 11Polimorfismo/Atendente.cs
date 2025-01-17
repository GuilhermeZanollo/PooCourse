class Atendente : Imposto // CRIA ACESSO AOS 2 MÉTODOS DA CLASSE IMPOSTO e SOBREESCREVE O METODO DE VALE ALIMENTAÇÃO
{
    public override void valeAlimentacao(double salario) // utilizo override para sobreescrever 
        {
            Console.WriteLine("Desconto gerente do vale alimentação R$"+(salario*0.12));
        }
}