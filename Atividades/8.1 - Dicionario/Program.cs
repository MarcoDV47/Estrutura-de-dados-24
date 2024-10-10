// Unlike the TabelaHash, the Dictionary allow us to
// specify the type of data that`s going to be used
// in the Key:Value pairs
// This nos fornece heavely typed structure

using Dicionario;

Dictionary<string, string> dictionary = new(){
    {"Chave 1", "Valor 1"},
    {"Chave 2", "Valor 2"},
};

// Obter valor do dictionary
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao obter valor de Chave 3");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar
// para evitar erros e prejuízos de execução

if (dictionary.TryGetValue("Chave 2", out string? value))
{
    Console.WriteLine($"Chave 2: {value}");
}

// Outra forma de obter o valor e evitar erro
dictionary.TryGetValue("Chave 4", out string? valor);
if (valor is not null)
{
    Console.WriteLine($"Chave 4: {value}");
}

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "Valor 0";

// Percorrer o dicionário
foreach (KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// Utilizando tipos abstratos de dados com dicionário

Dictionary<int, Pessoa> dicPessoa = new()
{
    { 1, new Pessoa() { Id = 0, BirthDate = new DateTime(1984, 7, 5) } }
};

foreach (KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine($"{kvp.Key}");
    Console.WriteLine($"{kvp.Value.Id}");
    Console.WriteLine($"{kvp.Value.Name}");
    Console.WriteLine($"{kvp.Value.BirthDate}");
}

/* 
    Escreva um programa para auxiliar empregadores de uma loja a encontrar a localização
    em que um produto deveria se encontrar. Imagine que cada empregador tem um telefone
    com a sua aplicação, que deve ser usada para escanear um código do produto e lhes dizer
    em que prateleira ele deve estar nomeadas de A1 a C9. Para resolver este problema devemos
    armazenar os dados em uma tabela HASH utilizando a classe do tipo Dicionario. A chave
    deve ser uma string para o código de barras e o valor, a localização na prateleira.
    Faça a carga, denomine-a 20 produtos contendo 5 em cada prateleira diferente, o seu
    programa deve perguntar ao usuário o código do produto e responder a localização
    Não se esqueça de tratar os erros e evitar mensagens obscuras para os empregadores.
*/