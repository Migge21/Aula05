using System;
using static System.Net.Mime.MediaTypeNames;

namespace Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aula 5.  - Data:08/04  
             Lab. J1 207 - Algoritmos e Técnicas de Programação – 4/2023

             Aluno(a): Miguel Sanches Braga Inácio
             Profa. Michelle Nery Nascimento*/

            /*Exerc 1.Faça um programa para mostrar na tela todas as tabuadas de multiplicar de 1 até 10.
            //variavel 
            int resultado;
            //entrada de dados
                 for(int valor2=1; valor2<=10; valor2++)
                 {
                     for (int valor1 = 1; valor1 <= 10; valor1++)
                     {
                     resultado = valor1 * valor2;
                     //saida
                     Console.WriteLine(valor1 + ". " + valor2 + ". " + resultado+"\n");

                     }
                 }*/

            /*Exerc 2.Faça um programa que leia números do teclado, calcule e mostre o quadrado de cada
            número até entrar um número múltiplo de 6 que deverá ter seu quadrado também impresso.*/
            /*
             * //variavel
            float num, resultado;
            //entrada de dados
            do
            {
                Console.WriteLine("Digite um número:");
                num = float.Parse(Console.ReadLine());
                //saida
                resultado = MathF.Pow(num, 2);
                 
                Console.WriteLine("Número: " + num + ". " + "Ele ao quadrado " + resultado);


            } while (num % 6 != 0);
            */

            /*Exerc 3.Faça um programa que receba a quantidade de pessoas que assistiram a uma partida de
              futebol e mostre as mensagens de acordo com a tabela:
              menos que 1.000 – “público baixo”
              entre 1.001 e 10.000 – “público médio”
              acima de 10.000 – “público bom”
            //variavel
            int publico;
            //entrada de dados
            Console.WriteLine("Digite a quantidade de pessoas que assistiram a partida:");
            publico = int.Parse(Console.ReadLine());
            //saida
            if(publico < 1000)
            {
                Console.WriteLine("Público baixo");
            }
            else if (publico > 1000 && publico <= 10000)
            {
                Console.WriteLine("Público médio");
            }
            else
            {
                Console.WriteLine("Público Bom");
            }*/

            /*Exerc 4.Faça um programa que leia dois valores, um representando o saldo de uma pessoa e o outro
            representando o valor que será depositado ou retirado da conta de acordo com a seguinte
             regra. Se o valor do saldo for maior que o segundo valor digitado, seu programa faz a retirada
            do menor valor do saldo. Caso contrário, seu programa irá depositar este valor na conta,
            aumentando-o ao saldo. Mostre o saldo final.
            //variavel
            float saldo, conta,resultado;
            //entrada de dados
            Console.WriteLine("Digite o valor do saldo e do valor a ser depositado ou retirado:");
            saldo = float.Parse(Console.ReadLine());
            conta = float.Parse(Console.ReadLine());
            //saida
            if(saldo > conta)
            {
                resultado = saldo - conta;
                Console.WriteLine("O valor retirado é de: "+resultado);
            }
            else
            {
                resultado = saldo + conta;
                Console.WriteLine("O valor depositado é de: " + resultado);
            }*/

            /*Exerc 5.Escreva um programa que leia o peso de um indivíduo. Considere que serão lidos os pesos
             de 30 pessoas. Calcule e mostre:
             - A média aritmética dos pesos das pessoas que possuem mais de 60 Kg
             - O valor do peso da pessoa mais pesada*/
            /*
              //variavel
            float peso, contador = 0, media, soma=0, maior = 0;
            //entrada de dados
            while (contador < 3)
            {
                Console.WriteLine("Digite o seu peso:");
                peso = float.Parse(Console.ReadLine());

                if (peso > maior)
                {
                    maior = peso;
                }

                soma += peso;
                

                contador++;
            }
            //saida
            media = soma / contador;

            Console.WriteLine("A média dos pesos das pessoas é de: " + media);
            Console.WriteLine("O maior peso é de: " + maior);
            */
            /*Exerc 6. Criar um programa para identificar o valor a ser pago por um plano de saúde dada a idade
              do conveniado considerando que todos pagam R$ 100 mais um adicional conforme a seguinte
              tabela:
                1) crianças com menos de 10 anos pagam R$180;
                2) conveniados com idade entre 10 e 30 anos pagam R$150;
                3) conveniados com idade entre 40 e 60 anos pagam R$195;
                4) conveniados com mais de 60 anos pagam R$230*/
            /*
             //variavel
            int valor = 100,idade,soma;
            //entrada de dados
            Console.WriteLine("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());
            //saida
            if(idade < 10)
            {
                soma = valor + 180;
                Console.WriteLine("O conveniado para crianças é de: " + soma);
            }
            else if(idade >= 10 && idade <=30) 
            {
                soma = valor + 150;
                Console.WriteLine("O conveniado para entre 10 e 30 anos é de: " + soma);
            }
            else if (idade >=40 && idade <= 60)
            {
                soma = valor + 195;
                Console.WriteLine("O conveniado para entre 40 e 60 anos é de: " + soma);
            }
            else if(idade >60)
            {
                soma = valor + 230;
                Console.WriteLine("O conveniado para mais de 60 é de: " + soma);
            }
            else
            {
                Console.WriteLine("Digite uma idade válida!!");
            }
            */

            /*Exerc 7. Escrever um programa que leia um número n que indica quantos valores devem ser lidos a
              seguir. Para cada número lido, mostre uma tabela contendo o valor lido e o fatorial deste
              valor*/
            /*
            //variavel
            int numn, contador = 0, fatorial=1;
            //entrada de dados
            Console.WriteLine("Digite o valor: ");
            numn = int.Parse(Console.ReadLine());
            //saida
            while (contador < numn)
            {


                for (int i = 1; i <= numn; i++)
                {
                    fatorial *= i;
                    
                    contador++;
                }
                
            }
            Console.WriteLine("O número " + numn + " fatorial é " + fatorial);*/
            /*
            int num1, num2, contador = 0, multi = 1;
            Console.WriteLine("Digite dois valores: ");
            num1 = int.Parse(Console.ReadLine());
            

            while(contador < num1)
            {
                for(int i =1; i <= num1; i++) 
                {
                    multi *= i;
                    contador++;
                }
            }
            Console.WriteLine("O número " + num1 + " fatorial é: "+multi);*/

            /*Exerc 8. Faça um programa que realize e mostre o produto entre 2 números inteiros A e B, através
            de somas sucessivas. Os números deverão ser lidos do teclado*/
            /*
            int num1, num2, produto=0,contador=0;

            Console.WriteLine("Digite dois valores: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            while (contador < num2)
            {
                produto += num1;
                Console.WriteLine("Soma de num1 x num2: " + produto);
                contador++;
            }
            */
            /*Exerc 9. Faça um programa que calcule e mostre o resultado para o seguinte somatório:
             S = 1/225 + 2/196 + 4/169 + 8/144 + ... + 16384/1*/
            /*
            float denominador = 15,numerador=1,s=0;

            while(denominador >= 1)
            {
                s += numerador / (denominador * denominador);
                 
                numerador *= 2;
                denominador--;
                Console.WriteLine("O somatorio é: " + s);
            }
            */
            /*Exerc 10. Escreva um programa que calcule e mostre o valor da série:
            ¶ = 4 - 4 + 4 - 4 + ... +/- 4
                    3   5   7           N*/
            /*
            float cont = 0, num1 = 4, num2 = 1, s = 0, N;

            Console.WriteLine("Valor de N");
            N= float.Parse(Console.ReadLine());//N é quantas vezes o i repete

            for(int i = 1; i <= N; i++)//o i vai ate ficar igual a N
            {
                if(i %2 != 0){
                    s += 4 / num2;//Soma se o resto do valor de i for diferente de 0
                }
                else{
                    s -= 4 / num2;//Subtrai se o valor de i for igual a 0
                }

                num2 += 2;
                Console.WriteLine("O valor da serie é: " + s);//Imprime o valor de s em cada somatoria
            */

            /*Exerc 11. Faça um programa que leia um número e verifique se ele é ou não quadrado perfeito. Um
            número é um quadrado perfeito quando tem um número inteiro como raiz quadrada.

            int num, quadrada;
            Console.WriteLine("Digite um valor: ");
            num = int.Parse(Console.ReadLine());

            quadrada = (int)Math.Sqrt(num);//faz a raiz quadrada do num(O resultado vai em inteiro por causa do (int)math.sqrt)

            if(Math.Pow(quadrada, 2) == num)//se a raiz elevada ao quadrado é num então é um quadrado perfeito
            {
                Console.WriteLine(num + " é um quadrado perfeito");
            }
            else//senao ele não é quadrado perfeito
            {
                Console.WriteLine(num + " não é um quadrado perfeito!!");
            }*/


            /*Exerc 12.Crie um programa que leia uma sequência de números terminada por 0(zero) e imprima
            o número que for múltiplo de sua posição na sequência.
            Exemplo:
                valores lidos: 3  7  8 16
                      posição: 1  2  3 4
                    impressão: 3 16 
            //variavel
            int valor, sequencia = 1;
            string multiplo = "";
            //entrada de dados
            do
            {
                
                Console.WriteLine("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());
                sequencia++;


                if (valor % sequencia == 0)
                {
                    if (multiplo != "")
                    {
                        multiplo += ",";
                    }
                    multiplo += valor.ToString();
                    
                }
                
            } while (valor !=0);
            //saida
            Console.WriteLine("Multiplos: "+ multiplo);
            */
            /*Exerc 13.Crie um programa que calcula e mostra o M. M. C. entre dois números lidos.

            //variavel
            int a, b, num1, num2,resto,resultado;
            //entrada de dados
            Console.WriteLine("Digite dois números:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            
            a = num1;
            b = num2;

            do
            {
                resto = a % b;

                a = b;
                b = resto;

            } while (resto != 0);
            //saida
            resultado = (num1 * num2) / a;
            Console.WriteLine("Valor: " + resultado);
            */

            /*Exerc 14.Repare a seguinte característica do número 3025: 30 + 25 = 55 e 55² = 3025
            Crie um programa que possa ler vários números inteiros de 4 algarismos, um de cada vez, e
            diga se o número apresenta a mesma característica (repare que 3025/100 =30 com resto 25).
            O algoritmo termina quando for lido um valor menor que 1.000 ou maior que 9999. Utilize
            apenas operações aritméticas básicas na solução desta questão. */
            /*
            //variavel
            int num1, primeiro, segundo,soma;
            //entrada de dados
            do
            {
                Console.WriteLine("Digite um número: ");
                num1 = int.Parse(Console.ReadLine());

                primeiro = num1 / 100;
                segundo = num1 % 100;

                soma = primeiro + segundo;

                //saida
                if(Math.Pow(soma, 2) == num1)
                {
                    Console.WriteLine("Número digitado: " + num1 + "\n");
                    Console.WriteLine(num1 + "/100 " +" = "+ primeiro+" com resto "+segundo+"\n");
                    Console.WriteLine(soma+"² = " + num1+"\n");

                }
                else
                {
                    Console.WriteLine("O número digitado não apresenta as caraceteristicas necessárias");
                }

            } while (num1 > 1000 && num1 < 9999);
            */
        }
    }
}