//### **Estruturas Condicionais (if, else if, else)**

//Em C#, usamos as estruturas condicionais para controlar o fluxo de execução do programa com base em determinadas condições. Elas permitem que o código tome decisões e execute blocos de código específicos apenas quando uma condição for atendida.

//### **Estrutura Condicional Simples (`if`)**

//A estrutura `if` é a mais básica. O bloco de código dentro do `if` só é executado se a condição especificada for verdadeira.


using System.Runtime.Intrinsics.X86;

int numero = 10;

if (numero > 5)
{
    Console.WriteLine("O número é maior que 5.");
}

//### **estrutura condicional composta (`if/else`)**

//uma condicional composta utiliza `if` e `else` para oferecer dois caminhos de execução: um para quando a condição é verdadeira (`if`) e outro para quando é falsa (`else`).

//**exemplo:**

int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

//**Explicação:**O programa verifica se a variável `idade` é maior ou igual a 18. Se a condição for verdadeira, a primeira mensagem é impressa. Caso contrário, o bloco `else` é executado, imprimindo a segunda mensagem.

//### **Estrutura Condicional Encadeada (`if/else if/else`)**

//A condicional encadeada é usada para testar múltiplas condições em sequência. A estrutura `else if` permite adicionar novas verificações caso as condições anteriores sejam falsas. O bloco `else` ao final é opcional e serve como um caminho padrão, executado se nenhuma das condições anteriores for atendida.

//**Exemplo:**

int temperatura = 30;

if (temperatura >= 35)
{
    Console.WriteLine("Está muito quente!");
}
else if (temperatura >= 25)
{
    Console.WriteLine("O clima está agradável.");
}
else if (temperatura >= 15)
{
    Console.WriteLine("Está um pouco frio.");
}
else
{
    Console.WriteLine("Está muito frio!");
}

//**Explicação:**

//1. * *Primeiro `if`**: O código verifica se `temperatura` é 35 ou mais. Se for, exibe "Está muito quente!" e toda a estrutura condicional é finalizada.
//2. **Primeiro `else if`**: Se a condição anterior for falsa, ele testa se `temperatura` é 25 ou mais. Se for, exibe "O clima está agradável." e a estrutura termina.
//3. **Segundo `else if`**: Se as duas condições anteriores forem falsas, ele verifica se `temperatura` é 15 ou mais. Sendo verdade, exibe "Está um pouco frio.".
//4. **`else`**: Se nenhuma das condições acima for verdadeira (ou seja, se a temperatura +for menor que 15), o bloco `else` é executado, exibindo "Está muito frio!".

//-------------------------------------------------------------------

//### **Operador Ternário (`? :`)**
//O operador ternário é uma forma compacta e abreviada de escrever uma estrutura `if/else` simples. Sua sintaxe é: `condição? valor_se_verdadeiro : valor_se_falso;`.
//É especialmente útil para atribuições condicionais de variáveis em uma única linha.
//**Exemplo:**

int idade1 = 20;
string mensagem = (idade >= 18) ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem); // Saída: Maior de idade


//--------------------------------------------

//### **Estrutura `switch`**

//Quando precisamos comparar * *uma mesma variável** com vários
//    valores possíveis, o `switch` costuma ficar mais organizado que uma sequência longa de `else if`.

int diaDaSemana = 3;

switch (diaDaSemana)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

//**Pontos de atenção:**

//-Cada `case` precisa terminar com `break`, senão o código não compila.
//- O `default` é o caminho padrão, executado quando nenhum `case` corresponde.


string cor = "verde";

switch (cor)
{
    case "vermelho":
        Console.WriteLine("Pare!");
        break;
    case "verde":
        Console.WriteLine("Siga!");
        break;
    default:
        Console.WriteLine("Cor desconhecida.");
        break;
}

////### **`switch` como expressão (versão moderna)**

////o c# moderno oferece uma forma ainda mais enxuta, quando o objetivo é apenas **devolver um valor**:

int diaDaSemana1 = 3;

string nomeDoDia = diaDaSemana switch
{
    1 => "Domingo",
    2 => "Segunda-feira",
    3 => "Terça-feira",
    _ => "Dia inválido"   // O '_' funciona como o 'default'
};

Console.WriteLine(nomeDoDia); // Saída: Terça-feira