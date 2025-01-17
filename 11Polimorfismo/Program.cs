using System;

namespace _11Polimorfismo // Digamos que temos 2 métodos: valeAlimentacao() e valeTransporte() , dois funcionarios usam esse padrão de vales, mas um deles utiliza mas não o padrão, como resolvo isso? tem que fazer um especifico para ele // usa o mesmo nome de metodo mas utiliza calculos diferentes para cada caso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar Estagiário
            Imposto objetoE = new Estagiario(); // "objetoE" vai ter acesso aos metodos de vale transporte e vale alimentação = se o metodo estagiario tiver algum metodo de vale refeicao ou vale alimentao, ele vai sobreescrever o metodo que está em imposto
            objetoE.valeAlimentacao(1000); // Aqui você está chamando o método valeAlimentacao de objetoE e passando 1000 como argumento.
            objetoE.valeTransporte(1000); //objetoE é uma variável do tipo Imposto, mas o objeto real instanciado é do tipo Estagiario
            Console.WriteLine("----------");

            // Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(5000);
            Console.WriteLine("---------");

            // Instanciar Atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTransporte(2000);
            Console.WriteLine("---------");
        }
    }
}

/* A linha Imposto objetoE = new Estagiario(); faz uso de polimorfismo. Polimorfismo é a capacidade de tratar objetos de diferentes tipos (ou classes derivadas) de forma uniforme, usando o tipo da classe base.

Imposto objetoE: Aqui, objetoE é uma variável do tipo Imposto, que é a classe base. Você está declarando uma variável do tipo Imposto, mas essa variável vai referenciar um objeto da classe derivada Estagiario.

new Estagiario(): Isso cria um objeto da classe Estagiario.

Embora objetoE seja declarado como Imposto (classe base), ele vai referenciar um objeto que é da classe Estagiario (classe derivada). Esse é o comportamento polimórfico, onde você usa o tipo base para referenciar um objeto de um tipo mais específico (a classe derivada).*/