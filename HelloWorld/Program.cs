using System;
using System.ComponentModel;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            //Voce consegue inserir uma nova linha no seu programa para acrescentar a mensagem: " Parabéns pelo seu primeiro código"?

            Console.WriteLine("Hello World!");
            Console.WriteLine("Parabéns, pelo seu primeiro código!");

            //Ocasionalmentea ONG para a qual você trabalha recebe doações em dólar e precisa saber qual é o valor em reais.
            //Crie um programa que permita que o usuário digite o valor da doação em dólares,
            //converta esse valor para reais e exiba o resultado na tela.

            double dolar, reais, cotacao;
            
            Console.WriteLine("Digite o valor em dolar");
            dolar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a cotação do dolar hoje:");
            cotacao= Convert.ToDouble(Console.ReadLine());
            reais = dolar * cotacao;
            Console.WriteLine("Valor doado em reais = R$" + reais);


            int n1, n2, resultado, multiplicacao;
            double divisao;

            //SOMA
            Console.WriteLine("Digite o primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("Soma = " + resultado);
            Console.WriteLine("Soma = " + resultado.ToString());
            Console.WriteLine("Soma: {0}", resultado.ToString());

            //Subtração
            resultado = n1 - n2;
            Console.WriteLine("subtração = " + resultado);

            //multiplicaçao
            multiplicacao = n1 * n2;
            Console.WriteLine("multiplicacao = " + multiplicacao);
           
            //Divisão
            divisao = n1 / n2;
            Console.WriteLine("divisão = " + divisao);
        }
    }
}