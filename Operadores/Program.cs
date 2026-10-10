// Usando para atribuir valores a varieaveis e modificar seus valore. 

int x = 10; // atribuição inicial 
x = 15; // novo valor atribuido

Console.WriteLine(x); //saida

//-------------------------------------------

/* 2 Operadores Aritmeticos (+,/,%)
 * sao usados para realizar operações mamtematicas entre valores numericos. 
 */

int soma = 10 + 5; // 15 
int subtracao = 10 - 5; // 5 
int multiplicacao = 10 * 5; //50
int divisao = 10 / 2; //5 
int modlulo = 10 % 3; // 1 (resto da divisão)

Console.WriteLine(soma);
Console.WriteLine(subtracao);
Console.WriteLine(divisao);
Console.WriteLine(modlulo);

//----------------------------------------------------------------------

//OPERADORES DE ATRIBUIÇÃO COMPOSTA

int numero = 10;

numero += 5;  // Mesmo que: numero = numero + 5  → 15
numero -= 3;  // Mesmo que: numero = numero - 3  → 12
numero *= 2;  // Mesmo que: numero = numero * 2  → 24
numero /= 4;  // Mesmo que: numero = numero / 4  → 6

numero++;     // Soma 1  → 7
numero--;     // Subtrai 1 → 6

//----------------------------------------------------------------------

//USANDO PARA COMPARAR VALORES, RETORNANDO TRUE (VERDADEIRO) OU FALSE (falso) 

int a = 10, b = 5;

Console.WriteLine(a == b);   // False (10 não é igual a 5)
Console.WriteLine(a != b);   // True  (10 é diferente de 5)
Console.WriteLine(a > b);    // True  (10 é maior que 5)
Console.WriteLine(a < b);    // False (10 não é menor que 5)
Console.WriteLine(a >= 10);  // True  (10 é maior ou igual a 10)
Console.WriteLine(a <= 5);   // False (10 não é menor ou igual a 5)

//----------------------------------------------------------------------

//4 OPERADORES LOGICOS
// ## **4. Operadores Lógicos**

//| operador | nome | exemplo | resultado |
//| --- | --- | --- | --- |
//| `&&` | e lógico  | `true && false` | `false` |
//| `||` | ou lógico | `true || false` | `true`  |
//| `!`  | não lógico | `!true` | `false` |
//| `^`  | ou exclusivo | `true ^ true` | `false` |

// 1 E logico (&&)
// Retorne true se ambas as expressoes forem verdadeiras. 

bool a = true;
bool b = false;
bool resultado = a && b; // false (porque uma das condições é falsa)

// OU logico (||)
// Retorna True se pelo menos uma das expressoes for verdadeira. 

bool a = true;
bool b = false;
bool resultado = a || b; // true (pelo menos uma condição é verdadeira)

//2 NÃO logico (!)
//Inverte o Valor logico de expressão. 

bool a = true;
bool resultado = !a; // false (inverte o valor de 'a')

//4 OU exlusivo (^) 
// Retorna true se apenas uma das expressões for verdadeira. 

bool a = true;
bool b = false;
bool resultado = a ^ b; // true (somente uma é verdadeira)