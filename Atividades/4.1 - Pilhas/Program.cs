// Basicamente, as pilhas trabalham com uma
// estrutura LIFO -> Last In First Out
// Três métodos importantes:
// Push() -> Insere um elemento no topo da pilha
// Pop() -> Retira o elemento do topo e o retorna 
// Peek() -> Retorna o elemento do topo sem removê-lo

// Invertendo as bolas
Stack<char> caracteres = new();
foreach (char c in "DARCY DA MONTANHA")
{
    caracteres.Push(c);
}

// Desempilhando

string invertido = string.Empty;

while (caracteres.Count > 0)
{
    invertido += caracteres.Pop();
}

Console.WriteLine(invertido);

// utilizando o conceito de pilha (stack<>), com os métodos pop() e push()
// escreva um programa que leia uma entrada do usuário e 
// identifique se a palavra ifnroamda é ou não um PALÍNDROMO

Console.WriteLine("Escreva uma palavra");

string? userString = Console.ReadLine();

Stack<char> userStringStack = new();

foreach (char c in userString!)
{
    userStringStack.Push(c);
}

string userStringReversed = string.Empty;


while (userStringStack.Count > 0)
{
    userStringReversed += userStringStack.Pop();
}

if (userString == userStringReversed)
{
    Console.WriteLine(userStringReversed);
}