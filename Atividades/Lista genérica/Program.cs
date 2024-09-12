// A principal diferença entre o ArrayList e o List é que o primeiro
// não é fortemente tipado

using Lista_genérica;

List<double> numbers = new List<double>();

do
{
    Console.WriteLine("Informe um número:");
    string? numberStr = Console.ReadLine();

    // Validando a entrada do usuário

    if (!double.TryParse(numberStr, out double number))
        break;

    numbers.Add(number);
    Console.WriteLine($"A média dos valores é {numbers.Average()}.");


} while (true);

// Lista de Pessoas
List<Person> people = new List<Person>();

Person p1 = new Person();
p1.Name = "Joaquim";
p1.Age = 12;
p1.Country = CountryEnum.PY;
p1.Name = "Joaquim José da Silva Xavier";

people.Add(p1);

people.Add(new Person()
{
    Name = "Sharon Stone",
    Age = 60,
    Country = CountryEnum.PY,
});

Person p3 = new Person()
{
    Name = "Arnold Schwazeneger",
    Age = 65,
    Country = CountryEnum.JP,
};

people.Add(p3);

// Formas de percorrer a Lista Genérica

foreach (Person p in people)
{
    Console.WriteLine(p.Name);
}

// Modo for tradicional
for (int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i].Name);
}

// Crie um novo projeto para um programa que armazene em uma Lista informações sobre livros como nome
// Editora, autor e numero de paginas.
// Preencha essa lista com no minimo 5 livros e ao final percorra
// esta lista e imprima as informações do livro com o maior número de páginas