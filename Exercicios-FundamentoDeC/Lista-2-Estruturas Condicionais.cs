
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class inicioEstruturasCondicionais2
{

    /* **1. Verificador de Maioridade**

    Crie um programa que declare uma variável **`idade`**. 

    Use uma estrutura **`if/else`** para verificar se a idade é **maior ou igual a 18**. 

    O programa deve imprimir "*Você é maior de idade*" se a condição for verdadeira, e "*Você é menor de idade*" caso contrário
    */

    private static void Main(string[] args)
    {
        int idade = 20;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade");
        }
        else
        {
            Console.WriteLine("Você é menor de idade");
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // **2.Verificador de Número(Positivo, Negativo ou Zero)**
        //Crie um programa que declare uma variável **`numero`**
        //Utilize uma estrutura * *`if/else if/else`**para verificar e imprimir uma das seguintes mensagens:
        //"*O número é positivo.*", "*O número é negativo.*" ou "*O número é zero.*".

        int numero = -5;
        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // **3.Classificação de Aluno**

            //Crie um programa que use a classe para pedir ao usuário que digite a nota de um aluno(um valor * *`double`**).

            //Em seguida, use uma estrutura **`if/else`**simples para imprimir "Aprovado" se a nota for maior ou igual a 7.0, e "Reprovado" caso contrário

            double nota = 8.5;
            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


public class IntermediarioEstruturasCondicionais2
{
    public static void Main(string[] args)
    {
        // **4.Classificação de Idade**
        //Crie um programa que declare uma variável **`idade`**.
        //Utilize uma estrutura **`if/else if/else`** para classificar a idade em:
        //"Criança" (0-12 anos), "Adolescente" (13-17 anos), "Adulto" (18-64 anos) ou "Idoso" (65 anos ou mais).
        int idade = 30;
        if (idade >= 0 && idade <= 12)
        {
            Console.WriteLine("Criança");
        }
        else if (idade >= 13 && idade <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (idade >= 18 && idade <= 64)
        {
            Console.WriteLine("Adulto");
        }
        else if (idade >= 65)
        {
            Console.WriteLine("Idoso");
        }
        else
        {
            Console.WriteLine("Idade inválida");
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //        **5.Status de Tarefa**

        //Declare uma variável **`boolean tarefaConcluida`**.

        //Usando uma estrutura * *`if/else`**, exiba a mensagem "A tarefa está pendente!"
        //se a variável for **`false`**, e "A tarefa foi finalizada com sucesso!" se
        //for **`true`**.

        bool tarefaConcluida = true;
        if (tarefaConcluida == false)
        {
            Console.WriteLine("A tarefa está pendente!");
        }
        else
        {
            Console.WriteLine("A tarefa foi finalizada com sucesso!");
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //        **6.Nota Válida(operador &&) * *
        //Peça uma nota ao usuário. Use o operador `&&` para verificar se ela está dentro do intervalo válido(entre 0 e 10). Exiba `"Nota válida"` ou `"Nota inválida"`.
        //csharp  

        Console.WriteLine("digite a nota: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 0 && nota <= 10)
        {
            Console.WriteLine("Nota válida");
        }
        else
        {
            Console.WriteLine("Nota inválida");
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //        **7.Aprovação de Empréstimo**

        //Para aprovar um empréstimo, um banco exige que o cliente tenha um salário mensal de pelo menos R$ 2.000,00 e não possua restrições de crédito. 

        //Crie um programa com as variáveis**`double salarioMensal`**; e * *`boolean possuiRestricao`** .Use o operador lógico "E"(**`&&`**) em uma estrutura * *`if`**para determinar e imprimir "Empréstimo aprovado." ou "Empréstimo negado."


        double salarioMensal = 2500.00;
        bool possuiRestricao = false;

        if (salarioMensal >= 2000.00 && possuiRestricao == false)
        {
            Console.WriteLine("Empréstimo aprovado.");
        }
        else
        {
            Console.WriteLine("Empréstimo negado.");
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //        **8.Classificação de Média Escolar Completa**

        //Crie um programa que solicita ao usuário que digite uma nota(um valor

        //**`double`**). Utilizando uma estrutura * *`if/ else if /else`**, classifique a nota da seguinte forma:

        //-Se a nota for 7.0 ou maior, imprima "Aprovado!".
        //- Se a nota for maior ou igual a 5.0, mas menor que 7.0, imprima "Recuperação.".
        //- Se a nota for menor que 5.0, imprima "Reprovado.".

        Console.WriteLine("Digite uma nota em ponto flutuante: ");
        double notaEscolar = double.Parse(Console.ReadLine());

        if (notaEscolar >= 7.0)
        {
            Console.WriteLine("Aprovado!");
        }
        else if (notaEscolar >= 5.0 && notaEscolar < 7.0)
        {
            Console.WriteLine("Recuperação.");
        }
        else
        {
            Console.WriteLine("Reprovado.");
        }

    }
}


//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


class AvancadoEstruturasCondicionais2
{
    static void Main(string[] args)
    {
        // **9. Verificação de Idade para Votar**
        //Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado (true ou false).
        Console.WriteLine("Digite sua idade: ");
        int idadeParaVotar = int.Parse(Console.ReadLine());
        bool podeVotar = idadeParaVotar >= 16;
        Console.WriteLine(podeVotar);


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //        **10.Cálculo de Desconto Progressivo * *
        //Uma loja oferece descontos baseados no valor da compra. Crie um programa que declare uma variável
        //`double valorCompra = 150.0;` e aplique as seguintes regras usando `if/else if/else`:
        //-Compras acima de R$ 200,00 têm 20 % de desconto.
        //- Compras entre R$ 100,00(inclusive) e R$ 200,00(exclusive) têm 10 % de desconto.
        //- Compras abaixo de R$ 100,00 não têm desconto
        //    O programa deve usar os operadores aritméticos para calcular e exibir o valor final a ser pago.

        double valorCompra = 150.0;
        double valorFinal;
        if (valorCompra > 200.0)
        {
            valorFinal = valorCompra * 0.8; // 20% de desconto
        }
        else if (valorCompra >= 100.0 && valorCompra < 200.0)
        {
            valorFinal = valorCompra * 0.9; // 10% de desconto
        }
        else
        {
            valorFinal = valorCompra; // Sem desconto
        }
        Console.WriteLine($"Valor final a ser pago: R$ {valorFinal:F2}");
    }
}

