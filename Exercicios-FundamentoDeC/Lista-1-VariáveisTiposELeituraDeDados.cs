// lista de exercicios fundamentais
//-------------------------------------------------------

//INICIANTES 

//1.Exibir uma Mensagem
//Escreva um programa que use o comando Console.WriteLine() para exibir a frase "Olá, Mundo!" no console.

using System.Runtime.Intrinsics.X86;

Console.WriteLine("ola mundo");

//**2.Declarar e Usar uma Variável**
//Crie um programa que declare uma variável inteira chamada `numero` com o valor 10. Em seguida, imprima o valor dessa variável no console.

int numero = 0;
Console.WriteLine(numero);

//3.Fazer uma Soma
//Escreva um programa que declare duas variáveis inteiras, a = 5 e b = 3. Calcule a soma das duas e imprima o resultado.

int a = 5;
int b = 3;
Console.WriteLine(b + a);

//**4.Produto de dois números * *
//Declare duas variáveis, `num1 = 8` e `num2 = 7`. Calcule o produto (multiplicação) entre elas e imprima o resultado.

int num = 8;
int num2 = 7;

Console.WriteLine(num * num2);

//----------------------------------------------------

// INTERMEDIARIOS 

//5.Saudação Personalizada
//Crie um programa que declare uma variável String chamada nome com o valor "Ana". Depois, exiba uma mensagem de boas-vindas, como "Olá, Ana!".

string nome1 = "Ana";
Console.WriteLine(nome1);

//**6.Calcular o Dobro**
//Declare uma variável inteira `valor`. Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.

int valor = 2;
int DobroValor1 = valor * 2;
Console.WriteLine(valor);

//**7.Média de três números * *

//Escreva um programa que recebe três números e imprime a média aritmética deles.

Console.WriteLine("dgite três numeros! para obter a sua media aritimetica: ");
int inteiro1 = int.Parse (Console.ReadLine());
int inteiro2 = int.Parse (Console.ReadLine());
int inteiro3 = int.Parse (Console.ReadLine());

int mediaAritmetica = inteiro1 +  inteiro2 + inteiro3;

Console.WriteLine("sua media é: " + mediaAritmetica);

/* **8. Ficha de Cadastro**

Peça ao usuário que digite, um de cada vez, o seu **nome**, a sua **idade** e a sua **cidade**. Depois, monte uma única frase com as três informações.

**Exemplo de execução:**
*
*Digite seu nome: Bruno
Digite sua idade: 27
Digite sua cidade: Santo André

Bruno tem 27 anos e mora em Santo André. 
*/

Console.WriteLine("digite seu nome: ");
string nomeInput = Console.ReadLine();

Console.WriteLine("digite sua idade: ");
int idadeInput = int.Parse(Console.ReadLine());

Console.WriteLine("digite seu nome: ");
string cidadeInput = Console.ReadLine();

Console.WriteLine(nomeInput + "tem" + idadeInput+ "idade" + cidadeInput + "e mora em ");

//**9.Comparar Dois Números**

//Escreva um programa que declare duas variáveis inteiras, x = 10 e y = 20.
//O programa deve comparar se `x` é menor que `y` (`<`) e imprimir o resultado (`true` ou `false`) no console.

int x = 10;
int y = 20;

Console.WriteLine(x < y); //retornar em True ou False. Vai retornar a True. 

//----------------------------------------------------------

//EXERCICIOS AVANÇADOS

/* **9. Verificação de Idade para Votar**

Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar se a idade é maior ou igual a 16 e imprimir o resultado (

`true` ou `false`). 
*/

Console.WriteLine("Digite uma idade para comparativo logico: ");
int MaiorQueIdade = int.Parse(Console.ReadLine());

int maiorQueDeseses = 16;
Console.WriteLine(maiorQueDeseses < MaiorQueIdade);
// sobre o codigo acima Cria duas variaveis --> int as compara o computador ira realizar um comparativo de valores e retornar True ou false


/* **10. Usando o Operador Lógico "E" (&&)**

Declare uma variável int temperatura = 28. Escreva uma expressão lógica que verifique
se a`temperatura` é maior que 25 **E** menor que 30. Imprima o resultado `true` ou `false` no console.
*/

int temperatura = 28;

Console.WriteLine(temperatura > 25 && temperatura < 30);

/* **11. Usando o Operador Lógico "OU" (||)**

Declare uma variável booleana temCartao = true e uma variável double compra = 50.0. O cliente ganha um desconto se temCartao for verdadeiro OU se o valor da compra for maior que 100.0. Escreva a expressão lógica e imprima o resultado (

`true` ou `false`). 
*/

bool temCartao = true;
double compra = 50.0;

Console.WriteLine(temCartao != false || compra < 100); // retornar true ou false


