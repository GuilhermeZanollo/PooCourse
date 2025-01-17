using System;

public class Pessoa
{

    //Atributos
    public double peso, altura;

    //Média
    public double Imc()
    {   
        return peso / (altura * altura);
    }

    //Retorno de situação
    public string SituacaoPeso(double imc)
    {

        string retorno;

        if (imc <= 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc <= 25)
        {
            retorno = "Peso normal";
        }
        else if (imc <= 30)
        {
            retorno = "Acima do peso";
        }
        else if (imc <= 35)
        {
            retorno = "Obesidade 1";
        }
        else if (imc <= 40)
        {
            retorno = "Obesidade 2";
        }
        else
        {
            retorno = "Obesidade 3";
        }

        return retorno;
    }

    public void mensagem()
    {
        // Obter o Cálculo
        double obterCalculo = Imc();
        //Obter Situação
        string obterSituacao = SituacaoPeso(obterCalculo);
        //Exibir Mensagem
        Console.WriteLine("Seu IMC é de "+obterCalculo);
        Console.WriteLine("Sua situação é "+obterSituacao);
        
    }
}