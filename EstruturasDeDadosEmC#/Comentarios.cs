// para escrever algo que ocupa só uma linha.
// Isso é um comentario de uma linha.

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Olá");

//Use /* ... */ para escrever várias linhas de comentário.
/* isso é um comentario de multiplas linhas
 veja só!*/
Console.WriteLine("Bem-vindo!");

//3- comentario de documentação
//Exclusivo do C#, é usado acima de métodos e classes.
//O Visual Studio mostra esse
//texto como uma "dica" quando você usa o método.


/// <summary>
/// Soma dois números inteiros e devolve o resultado.
/// </summary>
static int Somar(int a, int b)
{
    return a + b;
}