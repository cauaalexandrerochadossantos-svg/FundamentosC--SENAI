/* 1- Variaveis Uma **variável** pode **mudar de valor** durante a execução do programa.

Em C#, ela é declarada com o **tipo de dado**, seguido do **nome** da variável e, opcionalmente, um **valor inicial**.

**Exemplo de variável:**
*/

int idade = 25; // Pode ser alterado depois
idade = 30; // Modificar permitida 

//----------------------------------------------------

/* ### **2. Constantes**

Uma **constante** é um valor que **não pode ser alterado** depois de definido.

Em C#, ela é declarada com a palavra-chave `const`, antes do tipo de dado.

**Exemplo de constante:**/

const double Pi = 3.14159; //Não pode ser modificada depois 
                           // Pi = 3.14; // Isso causaria erro de compilação

//atenção: uma const precisa receber o valor na hora em que é 
// declarda, e esse valor precisa ser conhecido antes do programa roda

//----------------------------------------------------------------------

/* 3 ### **`readonly` (bônus)**

Quando o valor só é conhecido durante a execução
(por exemplo, algo que o usuário digita), usamos `readonly`
em vez de `const`. Ele também não pode ser alterado depois,
mas só funciona em campos de class*/

class Configuracao
{
    public readonly DateTime DataDeinicio = DateTime.Now;
}


//----------------------------------------------------------------------

/* 4 VAR - Deixando o C# descobrr o tipo da varivel a partir do valor atribuido:
 */
var idade = 25;
var nome = "Maria";
var preco = 19.95;

// isso  não significa que a variavel não tem tipo. Uma vez definido, o tipo não muda?

var idade = 25;
//idade = "trinta" // ERRO: idade é int e sempre sera int


//----------------------------------------------------------------------

/* ### **Diferenças:**

- **Variáveis**: você pode **mudar o valor** depois que ela foi criada.
- **Constantes** (`const`): **não podem ser alteradas** após a definição inicial. 
*/

