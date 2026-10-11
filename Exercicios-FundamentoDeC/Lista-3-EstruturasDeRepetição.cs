

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_FundamentoDeC
{
    internal class Lista_FUNDAMENTOS_EstruturasDeRepetição
    {
        public static void Main(string[] args)
        {
            /* **1. Senha Correta** · `while
            Peça uma senha ao usuário. Enquanto ele não digitar `123`, exiba `"Senha incorreta!"`
            e peça novamente. Quando acertar, exiba `"Acesso liberado!"`. */

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            senha = "123";

            while (senha != "123")
            {
                Console.WriteLine("Senha incorreta!");
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();

                /* **2. Contador Crescente** · `while`
                Use um laço `while` para imprimir os números de 1 a 10. */

                int contador = 0;
                while (contador < 10)
                {
                    contador++;
                    Console.Write(contador);
                }

                /* **3. Executar o Processo** · `do-while`
                Exiba a mensagem `"Executando o processo..."` e pergunte se o usuário deseja executar novamente. Se ele digitar
                `s` ou `S`, repita. Caso contrário, exiba `"Processo encerrado!"`. */

                Console.WriteLine("Executando o processo...");
                Console.Write("Deseja executar novamente? (s/n): ");
                string resposta = Console.ReadLine();
                do
                {
                    if (resposta.ToLower() == "s")
                    {
                        Console.WriteLine("Executando o processo...");
                        Console.Write("Deseja executar novamente? (s/n): ");
                        resposta = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Processo encerrado!");
                        break;
                    }
                } while (resposta.ToLower() == "s");

                /* **4. Somador de Números** · `do-while`
                Peça números inteiros ao usuário e vá somando todos. O laço para quando o usuário digitar 
                `0`. No final, exiba a soma total. */

                Console.Write("Digite um número (0 para encerrar): ");
                int numero = int.Parse(Console.ReadLine());
                int soma = 0;
                do
                {
                    soma += numero;
                    Console.Write("Digite um número (0 para encerrar): ");
                    numero = int.Parse(Console.ReadLine());

                } while (numero != 0);
                Console.WriteLine("A soma total é: " + soma);

                /* **5. Tabuada** · `for`
                 *Peça um número ao usuário e exiba a tabuada dele, de 1 a 10.
                 *Exemplo de saída para o número 7:*/
                Console.WriteLine("Digite um número para ver sua tabuada:");
                int tabuada = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
                }

                /* **6. Soma de 1 a 100** · `for`
                Use um laço `for` para somar todos os números de 1 a 100 e exiba o resultado*
                */
                int lacoFor = 0;
                for (int i = 1; i <= 100; i++)
                {
                    lacoFor += i;
                }
                Console.WriteLine("A soma de 1 a 100 é: " + lacoFor);
            }
        }
    }
}

class IntermediarioEstruturasRepeticao
{
    static void Main(string[] args)
    {
        /* 7- Crie um cadastro que peça uma senha ao usuário. Use `do-while` para garantir que ela tenha **no mínimo 8 caracteres**. 
         * Enquanto for curta, exiba `"Senha muito curta. A senha deve ter no mínimo 8 caracteres."
         * ` e peça novamente. Quando for válida, exiba `"Senha cadastrada com sucesso!"`.
        *Dica: `senha.Length` devolve a quantidade de caracteres.*/
        Console.WriteLine("digite uma senha ('validador pergunta 7)");
        string senha = Console.ReadLine();

        do
        {
            if (senha.Length < 8)
            {
                Console.WriteLine("Senha muito curta. A senha deve ter no mínimo 8 caracteres.");
                Console.WriteLine("digite uma senha ('validador pergunta 7)");
                senha = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Senha cadastrada com sucesso!");
                break;
            }
        } while (senha.Length < 8);

        /* **8. Cálculo de Fatorial*
        Peça um número inteiro não negativo e calcule o seu fatorial.
        O fatorial de `n` (escrito `n!`) é o produto de todos os inteiros positivos até
        `n`. Exemplo: `5! = 5 × 4 × 3 × 2 × 1 = 120`.*/
        Console.WriteLine("Digite um número para calcular seu fatorial:");
        int fatorial = int.Parse(Console.ReadLine());

        int resultado = 1;

        for (int i = 1; i <= fatorial; i++)
        {
            resultado *= i;
        }
        Console.WriteLine($"O fatorial de {fatorial} é: {resultado}");

        /* **9. Jogo de Adivinhação**
        O programa sorteia um número inteiro entre 1 e 100. O jogador tenta adivinhar qual é. A cada tentativa, informe se o número secreto é
        **maior** ou **menor** que o palpite. O jogo termina quando o jogador acerta. No final, mostre quantas tentativas foram necessárias.
        *Dica: `int numeroSecreto = new Random().Next(1, 101);`*/

        Console.WriteLine(" jOGO DE ADIVINHAÇÃO ");
        Console.WriteLine(" digite um número entre 1 e 100: ");

        int numeroSecreto = new Random().Next(1, 101);
        while (true)
        {
            int palpite = int.Parse(Console.ReadLine());
            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior. Tente novamente.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor. Tente novamente.");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou o número secreto!");
                break;
            }

            /* **10. Calculadora Interativa**

                Desenvolva uma calculadora com as quatro operações básicas. O programa deve:

                1. Exibir um menu com as opções (somar, subtrair, multiplicar, dividir, sair).
                2. Pedir ao usuário para escolher uma operação.
                3. Pedir dois números.
                4. Exibir o resultado.
                5. Voltar ao menu, repetindo até que o usuário escolha "Sair".

                *Dica: use `do-while` para o menu e `if/else` ou `switch` para as operações.*/

            Console.WriteLine("essa é a nossa calculadora interativa");
            Console.WriteLine("digite uma opção: " +
                "1- Somar" +
                "2- Subtrair" +
                "3- Multiplicar" +
                "4- Dividir" +
                "5- Sair");
            do
            {
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 5)
                {
                    Console.WriteLine("Saindo da calculadora.");
                    break;
                }
                Console.WriteLine("Digite o primeiro número:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                double num2 = double.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Resultado: {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Resultado: {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Resultado: {num1 * num2}");
                        break;
                    case 4:
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (true);


        }
    }
}

class AvancadoEstruturasRepeticao
{
    static void Main(string[] args)
        {
            /* **. Números Primos até 100**
            Liste todos os números primos entre 1 e 100.
            Um número primo é um número natural maior que 1 que só é divisível por 1 e por ele mesmo.
            *Dica: você vai precisar de um `for` dentro de outro. O laço externo percorre os números de 2 a 100 e o 
            *interno verifica se existe algum divisor. O comando `break` ajuda a sair do laço interno assim que um divisor é encontrado.*/ 

        static bool EhPrimo(int numero)
        {
            if (numero <= 1) return false; //0,1 é negativos não são primos
            if (numero == 2) return true; //2 é o único  primo par 
            if (numero % 2 == 0) return false; //números pares maiores que 2 não são primos

            //Verificar divisores ímpares até que i*i > numero 
            for (int i = 3; i * i <= numero; i += 2)
            {
                if (numero % i == 0)
                    return false; //Encontrou um divisor, não é primo
            }
            return true;
        }

        /* **12. Sequência de Fibonacci**

        Peça um número `N` ao usuário e exiba os `N` primeiros termos da sequência de Fibonacci.
        Na sequência, cada termo é a soma dos dois anteriores: `0, 1, 1, 2, 3, 5, 8, 13, 21...` */
        Console.WriteLine("Digite o número de termos da sequência de Fibonacci que deseja exibir: ");

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Sequência de Fibonacci: ");

        int primeiro = 0, segundo = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(primeiro + " ");

            int proximo = primeiro + segundo;

            Console.WriteLine(proximo);
            primeiro = segundo;
            segundo = proximo;
        }
        Console.WriteLine();

        }
}