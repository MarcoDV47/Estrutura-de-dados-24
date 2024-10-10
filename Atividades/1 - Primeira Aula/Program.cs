// Comentário de uma linha

/*
    Comentário de
    múltiplas linhas
*/


// Declarando variável
using Primeira_Aula;

int number;

// Atribuindo valor
number = 10;

// Declarando constante
const int DAYS_IN_WEEK = 7;

// Imprimindo string concatenada
Console.WriteLine($"A semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() invoca o método construtor do objeto
// Toda classe tem o seu construtor padrão implícito sem argumentos/params
// É possível sobreescrever este método especificando argumentos
// Todavia, se o fizermos perdemos o original implícito e precisaremos defini-lo explícitamente

TipoEnumerador tipoEnum = new TipoEnumerador();
TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("inglês");

Console.WriteLine($"O enum de inglês é {enumEnglish}");
Console.WriteLine($"O enum de russo é {tipoEnum.GetLanguageEnum("russo")}");