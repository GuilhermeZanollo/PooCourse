using System; // quando vai trabalhar com console // encapsulamento tem objetivo de restringir o acesso as suas classes

class Aluno
{
    // Atributos
    private double nota1, nota2; // outra classe nao possuem acesso as notas1 e nota2

    // Média
    private double media()
    {
        return (nota1+nota2)/2;
    }

    // Mensagem
    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota:");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota:");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A sua média é:"+media());
    }


}
