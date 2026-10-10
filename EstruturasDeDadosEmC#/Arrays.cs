
using System;
using System.Collections.Generic;

//Um array(ou vetor) é uma estrutura de dados que armazena uma coleção de tamanho fixo de elementos do
//mesmo tipo. Os arrays são essenciais quando precisamos manipular um conjunto de dados,
//como uma lista de números, nomes ou objetos.

//--------------------------------------------------

// 1- Declarando e inicializando Arrays 
// Para declarar um array em C#, usamos o tipo de dados seguido de [] e o nome da variaveis. 

// Declarando um array de inteiros
int[] numeros;

/***Inicialização com um tamanho fixo**

Você deve especificar o tamanho do array ao inicializá-lo. Os 
elementos são inicializados com o valor padrão do tipo (0 para `int`, `null` para `string` e outros objetos, `false` para `bool`).
*/

// Criando um array de inteiros com 5 posições
int[] numeros = new int[5];

/***Inicialização com valores**

Você também pode inicializar o array diretamente com os valores desejados.*/

// Criando um array e atribuindo valores diretamente
int[] numeros = { 10, 20, 30, 40, 50 };

/*Nesse caso, o C# cria automaticamente um array com 5 elementos. A forma explícita também é válida:*/

int[] numeros = new int[] { 10, 20, 30, 40, 50 };

//--------------------------------------------------------------

//## 2. Acessando Elementos do Array

//Os elementos do array são acessados por seus **índices**, que começam em **0**.

int[] numeros = { 10, 20, 30, 40, 50 };

// Acessando o primeiro elemento (índice 0)
Console.WriteLine(numeros[0]); // Saída: 10

// Modificando um valor no segundo elemento (índice 1)
numeros[1] = 25;
Console.WriteLine(numeros[1]); // Saída: 25


//-----------------------------------------------------



//## 3. Percorrendo Arrays

//### **Usando o loop `for` tradicional**

//Este loop é ideal quando você precisa do índice de cada elemento.

//csharp

int[] numeros = { 10, 20, 30, 40, 50 };

// A propriedade 'Length' (com 'L' MAIÚSCULO) retorna o número total de elementos.
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento no índice {i}: {numeros[i]}");
}

//### **Usando o `foreach`**

//Este loop é mais simples e é usado quando você só precisa do valor de cada elemento, sem se preocupar com o índice.

int[] numeros = { 10, 20, 30, 40, 50 };

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

//A sintaxe foreach (Tipo variavel in colecao) lê-se como: "para cada variavel do Tipo na colecao, faça...".
Dentro de um foreach você não pode alterar o valor dos elementos. Se precisar modificar o array, use o for tradicional

    //--------------------------------------------
// 4 lista (List <T>) - quando o tamanho pode mudar
// O array tem tamanho fixo. Quando voce não sabe quantos itens terá, a List<T> é a escolha certa: 



List<string> nomes = new List<string>();

nomes.Add("Ana");
nomes.Add("Bruno");
nomes.Add("Carla");

Console.WriteLine(nomes.Count);    // Saída: 3 (na lista é 'Count', não 'Length')
Console.WriteLine(nomes[0]);       // Saída: Ana

nomes.Remove("Bruno");

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}