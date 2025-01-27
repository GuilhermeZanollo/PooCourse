using System;

namespace _13Abstração
/*
-> Só posso herdar uma classe abstrata uma vez

-> É uma classe que pode conter métodos obrigatórios para todas as classes que a herdarem;
-> É possível criar métodos convencionais (não obrigatórios), para que as classes que herdem consigam utilziar;
-> Não é possível instanciar uma classe abstrata, exemplo: Produto prod = new Produto();
-> Padrão utilizado em projetos com muitos desenvolvedores, pois garante uma estrutura pré-moldada com ações que podem ser realizadas;
-> Como é utilizada a herança, cada classe pode herdar apenas uma classe abstrata;
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
        }
    }
}