
// Mostrar os números de 1 a 10
// Console.WriteLine("1");
// Console.WriteLine("2");
// Console.WriteLine("3");
// ... e assim por diante (trabalhoso e repetitivo!)

// Mostrar os números de 1 a 10 usando repetição

// WHILE
using System.Runtime.Intrinsics.X86;

int numero = 1;
while (numero <= 10)
{
    Console.WriteLine(numero);
    numero = numero + 1;
}

// DO/WHILE
int numero2 = 1;
do
{
    Console.WriteLine(numero2);
    // numero2 = numero2 + 1;
    numero2++;
} while (numero2 <= 10);

// FOR - PARA
// Cria uma variável i valendo 1
for (int i = 1; i <= 10; i = i + 1)
{
    Console.WriteLine(i);
}
//-----------------------------------------------------------

//## **Laços `while` e `do/while`**

//Os laços `while` e `do/while` são usados quando não sabemos exatamente quantas vezes o código deve se repetir, e a repetição depende de uma condição que é verificada a cada iteração.
//**1. Laço `while`**
//O `while` repete um bloco de código **enquanto** a sua condição for verdadeira. A condição é testada *antes* da execução do bloco.
//**Sintaxe:**

while (condição)
{
    // Código a ser repetido
}

//outro exemplo 

int contador = 1;

while (contador <= 5)
{
    Console.WriteLine($"Repetição número: {contador}");
    contador++; // Incrementa para evitar um loop infinito
}

//**O que acontece aqui?**

//1. Começa com `contador = 1`.
//2. A condição `contador <= 5` é verificada. Como `1 <= 5` é verdade, o bloco é executado.
//3. `contador++` faz o valor aumentar a cada repetição.
//4. Quando `contador` chega a 6, a condição `6 <= 5` se torna falsa, e o laço para.

//**Saída no console:**

Repetição número: 1
Repetição número: 2
Repetição número: 3
Repetição número: 4
Repetição número: 5

//-----------------------------------------------------------

//**2.Laço `do/while`**

//O `do/while` é parecido com o `while`, mas ele sempre executa o bloco de código **pelo menos uma vez**, pois a condição é verificada *depois* da primeira execução.

//**Sintaxe:**

do
{
    // Código a ser repetido
} while (condição);

//exemplo

int numero = 1;

do
{
    Console.WriteLine($"Número: {numero}");
    numero++;
} while (numero <= 5);

//**O que acontece aqui?**

//1. O código dentro do `do` é executado uma vez, imprimindo "Número: 1".
//2. Depois, a condição `numero <= 5` é verificada.
//3. Se for verdadeira, o laço continua; senão, ele para.

//**Saída no console:**

Número: 1
Número: 2
Número: 3
Número: 4
Número: 5

//### **Diferença principal entre `while` e `do/while`**

//- `while` → **Primeiro verifica** a condição, depois executa (se for verdadeira). Pode nunca ser executado.
//- `do/while` → **Executa pelo menos uma vez**, depois verifica a condição.

//Exemplo:
//Se a variável começar com um valor que não atende à condição:

    int x = 10;

// Este bloco nunca será executado
while (x < 5)
{
    Console.WriteLine("While executado!");
}

// Este bloco será executado uma vez
do
{
    Console.WriteLine("Do/While executado!");
} while (x < 5);

saida no consoel: 
    Do / While executado!

    //O laço while nem roda, porque a condição 10 < 5 já é falsa de início. O do/while roda uma vez e só depois verifica a condição. Isso torna o do/while útil para situações 
    //onde você precisa garantir pelo menos uma execução, como em menus de opções ou validação de entrada inicial.

//--------------------------------------------------------------

    Laço for 

    //O laço de repetição for em C# é usado quando sabemos exatamente quantas vezes queremos repetir um bloco de código.
    //Ele é mais compacto para controlar laços baseados em contadores.

    for (inicialização; condição; incremento / decremento)
{
    // Código a ser repetido
}

//**Explicação das partes:**

//1. * *Inicialização:**Executada uma única vez no início. Geralmente, cria e inicializa uma variável de controle (ex: `int i = 0`).
//2. **Condição:**Verificada * antes * de cada repetição. Enquanto for verdadeira, o laço continua.
//3. **Incremento/Decremento:**Executado ao* final*de cada repetição. Modifica a variável de controle (ex: `i++`).

//**Exemplo simples: **

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Repetição número: {i}");
}

```csharp
}
```

//**O que acontece aqui?**

//1. `int i = 1;` → A variável `i` é criada e começa com o valor 1.
//2. `i <= 5;` → A condição é verificada. Como `1 <= 5` é verdade, o laço executa.
//3. O código `Console.WriteLine(...)` é executado.
//4. `i++` → Ao final da repetição, `i` aumenta em 1.
//5. O processo se repete até que `i` seja 6, quando a condição `6 <= 5` se torna falsa e o laço termina.

Repetição número: 1
Repetição número: 2
Repetição número: 3
Repetição número: 4
Repetição número: 5


//-------------------------------------------------------------

//Dois comandos que ajudam a controlar o comportamento dos laços:

//-**`break`**: interrompe o laço imediatamente.
//- **`continue`**: pula para a próxima repetição, ignorando o resto do bloco.