/* Em C#, usamos `Console.WriteLine()` ou `Console.Write()` para exibir informações no console.

A diferença entre eles:

- `Console.WriteLine()` → escreve o texto e **pula para a próxima linha**.
- `Console.Write()` → escreve o texto e **mantém o cursor na mesma linha**.

Para receber dados do usuário, usamos `Console.ReadLine()`, que **sempre devolve um texto (`string`)**. Se precisarmos de um número, é necessário converter esse texto.

**Exemplo de Uso:**/

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Ola" + nome + "! Voce " + idade + " anos. ");

/* Toda a leitura do teclado é 
 * feita com Console.ReadLine(), e a conversão de tipo fica por sua conta. */


//----------------------------------------------------------------------

/* Convertendo o texto lido para numero
 */

// Existem três formas principais: 

string entrada = Console.ReadLine();

int num1 = int.Parse(entrada); // Quebra o programa se não for numero 
int num2 = Convert.ToInt32(entrada); // Funciona de forma parecida
double num3 = double.Parse(entrada); // Para numeros decimais. 

// E forma mais segura, que não o programa: 

Console.Write("digite sua idade: ");
if (int.TryParse(Console.ReadLine(), out idade))
{
    Console.WriteLine("Sua idade é: " + idade);
}
else
{
    Console.WriteLine("Voce não digitou um numero valido!");
}

// Interpolação de strings ($)
//Em vez de juntar textos com `+`, o C# oferece uma forma bem mais legível:
//basta colocar um `$` antes das aspas e usar `{ }` para inserir variáveis.


string nome = "Maria";

string nome = "Maria";
int idade = 25;

// Forma tradicional (concatenação)
Console.WriteLine("Olá, " + nome + "! Você tem " + idade + " anos.");

// Forma recomendada (interpolação)
Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");

//ambas produzem o mesmo resultado. mas a segunda é mais facil de ler.  