using System.Collections;

Dictionary<string, string> Registro = new(){
    {"78911111", "A5"},
    {"78922222", "A6"},
    {"78933333", "B8"},
    {"78944444", "C4"},
};

Console.WriteLine("Insira o código de barras");
string? codigo = Console.ReadLine();

if (Registro.TryGetValue(codigo!, out string? valor))
    Console.WriteLine($"O produto está na prateleira: {valor}");
else Console.WriteLine("O produto não está cadastrado");

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Registro.Add("");
    }
}
// Hashtable<valor, prateleira>
// Hashtable<Dictionary.valor, Dictionary.prateleira>