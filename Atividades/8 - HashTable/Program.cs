// Exemplo de uma agenda telefônica

using System.Collections;

Hashtable phoneBook = new()
{
    // { "Chave","Valor" }
    { "Thomazzi","546846846" },
    { "Mauricio","81987" },
    { "André","489784981981" }
};

// É possível adicionar elementos de difersas formas
// Pelo próprio índice chave inexistente
phoneBook["Thiago"] = "688686866";

// Ou pelo método Add()
phoneBook.Add("Marcos", "46846846846");

// Entretanto, a Hashtable verifica se há
// duplicidade de chave e pode lançar uma
// Exception
try
{
    phoneBook.Add("Mauricio", "81987");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido");
    Console.WriteLine(ex.Message);
}

// Percorrendo itens da Hashtable
Console.WriteLine("Agenda telefônica");
if (phoneBook.Count == 0)
{
    Console.WriteLine("A agenda está vazia.");
}
else
{
    foreach (DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
}