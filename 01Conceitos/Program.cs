using System; // importar funcionalidade - armazenar conceitos 

namespace _01Conceitos // local -> Pasta desse projeto
{
    class Program { // 
        static void Main(string[] args) // todos projeto em Csharp possui um arquivo com esse static void Main (É O ARQUIVO PRINCIPAL DO PROJETO)
        {
            // Instanciar um objeto -> criando a partir de um molde
            Pessoa obj = new Pessoa(); // criando uma pessoa
            obj.nome = "Ralf"; // especificando o objeto
            obj.idade = 30;
            obj.mensagem();
        }
    }
}