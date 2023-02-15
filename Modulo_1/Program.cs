using System.Net.Http.Headers;

namespace Modulo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Uma ONG criou um jogo para alertar as pessoas sobre os riscos das drogas.
             * por se tratar de um assunto sensível, ficou decidido que a idade minima para jogar é de 12 anos.
             * sua função é criar um programa que receba a idade do usuário e exiba a mensagem " Você pode jogar" 
             * caso ele tenha 12 anos ou mais */

            Console.WriteLine("Digte sua idade!");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A idade indicativa 12 anos!");
            //Decisão condicional simples
            if (idade >= 12)
            {
                Console.WriteLine("Voce pode jogar");
            }
            else //senão
            {
                Console.WriteLine("Você não pode jogar");
            }

            /* O estatuto de uma ONG determina que todas as doações recebidas devem gerar
             * um valor para investimento, para cobrir momentos de necessidade.
             * O valor do investimento deve ser de 5% da doação.
             * Porém, em casos em que a doações ultrapasssem R$:1000,00 o investimento deve ser de 15% da doação
             * sua missão é criar um programa capaz de fazer os cálculos necessários e indicar quanto deve ser investido.*/

            double investimento;
            Console.WriteLine("Exercício2");
            Console.WriteLine("Digite sua doação");
            double doacao = Convert.ToDouble(Console.ReadLine());   
            if  (doacao >= 1000)
            {
                investimento = doacao * 0.15;
            }
            else
            {
                investimento = doacao * 0.05;
            }
            Console.WriteLine("Valor do investimento:" + investimento);
            
            if (doacao < 1000)
                investimento = doacao * 0.05;
            else
                investimento = doacao * 0.15;

            /* Uma ONG resolveu prestar um serviço bem diferente: ela oferece vans para buscar pessoas com qualquer tipo de dificuldade de
             * locomoção para poderem votar.Para evitar problemas no momento do embarque, porém, você foi convidado a criar 
             * um programa que valide a idade dos passageiros: caso tenham menos de 16 anos, não podem votar (e nem embarcar)
             * Caso tenham entre 16 anos e 17, podem optar por votar ou não. Caso tenham mais de 18 anos, devem votar obrigatoriamente.
             * Crie um programa que receba a idade dos passageiros em potencial e indique se podem embarcar e votar */

            //int idade;
            string situacao;
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 16)
            {
                situacao = "Você não pode votar nem embarcar!"; 
            }
            else if (idade >= 18)
            {
                situacao = "Voto obrigatório. Embaque permitido!";
            }
            else
            {
                situacao = "Pode optar por votar ou não, embarque opicional";
            }
            Console.WriteLine(situacao);

            /* Calcule a média aritmética das três notas de um aluno e mostre, 
             * além do valor da média, uma mensagem de "Aprovado", caso a média seja igual ou superior a 7; 
             * a mensagem “em prova final” caso a média seja menor que 7 e maior ou igual a 4; e "reprovado", caso contrário. */

            Console.WriteLine("Momento Hands On");
            double nota1, nota2, nota3, media;
            Console.WriteLine("Digite a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a primeira nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a primeira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("Media:" + media);
            
            if (media >= 7)
            {
                Console.WriteLine("Parabéns! Você foi aprovado com média:" + media);
            }          
            else if(media < 4)
            {
                Console.WriteLine("Você foi reprovado com a média:" + media);
            }
            else
            {
                Console.WriteLine("Você deve fazer a prova final, sua media foi:" + media);   
            }

            /* Um banco concederá um crédito especial aos seus clientes, variável com o saldo médio no último ano. Faça um programa que leia o saldo médio
             * de um cliente e calcule o valor do crédito de acordo com a tabela abaixo. Mostre uma mensagem informando o saldo médio e o valor do 
             * crédito.
             * de 0 a 200 - nenhum crédito 
             * de 201 a 400 - 20% do valor do saldo médio
             * de 401 a 600 - 30% do valor do saldo médio
             * acima de 601 - 40% do valor do saldo médio */
         
            double saldo,credito;
            Console.WriteLine("Exercicio 03");
            Console.WriteLine("Digite o saldo medio:");
            saldo = Convert.ToDouble(Console.ReadLine());
            
            if (saldo < 200)
            {
                credito = 0;
            }
            else if (saldo <= 400)
            {
                credito = saldo * 0.2;
            }
            else if (saldo <= 600)
            {
                credito = saldo * 0.3;
            }
            else 
            {
                credito = saldo * 0.4;
            }
            Console.WriteLine("Saldo médio: R$" + saldo + " - Crédito:" + credito);

            /* Crie um algoritmo que calcula o desconto previdenciário de um funcionário.Dado um salário,o programa deve retornar o valor do desconto proporcional ao mesmo.
             * O cálculo segue a regra: o desconto é de 11% do valor do salário,entretanto,o valor máximo de desconto é 720,00.
             * Sendo assim,ou o algoritmo retorna o valor equivalente a 11% sobre o salário ou 720,00. */
            
            double salario, desconto;
            Console.WriteLine("Digite seu salário:");
            salario = Convert.ToDouble(Console.ReadLine());
            desconto = salario * 0.11;
            if (desconto >= 720)
                desconto = 720;
            Console.WriteLine("seu desconto será: R$" + desconto);
        }    
    }
}