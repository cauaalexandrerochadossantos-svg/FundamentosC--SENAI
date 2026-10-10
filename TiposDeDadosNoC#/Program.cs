/* Tipos de Dados em C#
 * Em C#, os dados que você usa são classificados em tipos. 
 * Os mais básicos são os tipos por valor (primitivos). */

//----------------------------------------------------------------------

//Usados inteiros (int, long, byte, short) 

/* usados para guardar  numeros inteiros, sem casas decimais. o mais ccomum é o int.
 * int: perfeito para a maioria dos numeros inteiros, como idade, quantidade ou placar de um jogo.
 * 
 * Long: Use quando o numero for muito grande. É preciso colocar a Letra L no final. 
 * exemplos:
 */

int idade = 25;
long populacaoDaTerra = 800000000000l;

Console.WriteLine(idade); //saida: 25 
Console.WriteLine(populacaoDaTerra); //saida: 800000000000

/* (Observação: byte e short também servem para números
 * inteiros, mas para números 
 * bem pequenos e são menos usados.)
 */


//----------------------------------------------------------------------


// 2- Tipos Decimais (double, float, decimal)
/* Usados para guardar números com casas decimais, como preços, altura ou peso. O `double` é o mais utilizado.

- `double`: É o padrão para números decimais.
- `float`: Um tipo decimal com limite menor. É preciso colocar a letra `f` no final.
- `decimal`: Exclusivo do C#, tem altíssima precisão. É o tipo **recomendado para dinheiro**. Usa a letra `m` no final.
*/

double preco = 19.95; 
float altura = 1.75f;
decimal salario = 3500,50;

Console.WriteLine(preco);
Console.WriteLine(altura);
Console.WriteLine(salario);

/* No Brasil, o C# exibe números decimais com vírgula por padrão, porque segue as configurações regionais do computador.
 * Ao escrever no código, porém, sempre use ponto. 
 */


//----------------------------------------------------------------------

/* A `string` é usada para guardar textos (sequências de caracteres). O valor deve estar entre aspas duplas (`" "`).

**Exemplos:**/

string nomeCompleto = "Maria Souza";
string mensagem = "Olá, tudo bem?";

Console.WriteLine(nomeCompleto);
Console.WriteLine(mensagem);


/* Diferente do Java, em C# escrevemos string com letra minúscula. (String com maiúscula 
 * também funciona e significa exatamente a mesma coisa, mas a convenção da comunidade é usar string.)
 */


//----------------------------------------------------------------------

//Tipos Booleano (bool)

/* Super simples! Guarda apenas um de dois valores: `true` (verdadeiro) ou `false` (falso). É usado para representar estados, como "ligado/desligado" ou "sim/não".

**Exemplos:**/

bool diaDeSol = true;
bool tarefaConcluida = false;
Console.WriteLine(diaDeSol);
Console.WriteLine(tarefaConcluida);

/* Repare: em C# o tipo é bool (e não boolean), e ao imprimir aparece True/False com a primeira letra maiúscula.
 * 

//----------------------------------------------------------------------

// 5 Tipos Caractere (char)
//Usanod para guardar um unica letra ou simbolo. O valor Deve estar entre aspas simples ('');
// exemplo: */

char inicialDoNome = 'm';
char tipoSanguineo = 'A';

Console.WriteLine(inicialDoNome);
Console.WriteLine(tipoSanguineo);

/* Tabela de resumo: 
 * 
| Tipo | Guarda | Exemplo |
| --- | --- | --- |
| `int` | Números inteiros | `int idade = 25;` |
| `long` | Inteiros muito grandes | `long total = 9000000000L;` |
| `double` | Números decimais | `double preco = 19.95;` |
| `float` | Decimais menores | `float altura = 1.75f;` |
| `decimal` | Decimais precisos (dinheiro) | `decimal saldo = 100.50m;` |
| `string` | Textos | `string nome = "Ana";` |
| `bool` | Verdadeiro ou falso | `bool ativo = true;` |
| `char` | Um único caractere | `char letra = 'A';` |
*/ 


