namespace _14Interface;

/* 

Utilizada para criar exclusivamente métodos obrigatórios
Uma classe pode implementar várias interfaces
Os métodos da interface não contêm cálculos, condicionais, laços e demais ações
double calculo(double numero);
string texto();
void mensagem(string nome, int idade);
No C# por padrão um método criado na Interface é abstrato e público;
Nas boas práticas do C#, toda a interface tem a inicial 1, em seguida o nome da interface:
IPadrao
ICalculo
IConsulta
IAcoes

*/
class Program
{
    static void Main (string[] args)
    {
        Calculo c = new Calculo();
        c.somar(10, 15);
        c.subtrair(50, 18);
    }
}