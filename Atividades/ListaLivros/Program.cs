using ListaLivros;

List<Book> books = new List<Book>();

Book book1 = new();
book1.AuthorName = "Maquiavél";
book1.BookName = "O Príncipe";
book1.Editor = BookEditors.Goblin;
book1.TotalPages = 100;

books.Add(book1);

books.Add(new Book()
{
    AuthorName = "Dom Chicote",
    BookName = "Minhas Incríveis Aventuras Reais",
    Editor = BookEditors.Pinguço,
    TotalPages = 600
});

Book book3 = new Book()
{
    AuthorName = "Dostoívski",
    BookName = "Crime e Castigo",
    Editor = BookEditors.CachorroLeitor,
    TotalPages = 500
};

books.Add(book3);

Book book4 = new Book()
{
    AuthorName = "Marta Rocha",
    BookName = "Histórias para Pequenos",
    Editor = BookEditors.Nhonho,
    TotalPages = 30
};

books.Add(book4);

Book book5 = new Book()
{
    AuthorName = "Homer Simpson",
    BookName = "Fallout New Vegas",
    Editor = BookEditors.Nhonho,
    TotalPages = 3
};

books.Add(book5);

int highestPages = 0;

foreach (Book book in books)
{
    if (book.TotalPages > highestPages)
    {
        highestPages = book.TotalPages;
    }
}

foreach (Book book in books)
{
    if (book.TotalPages == highestPages)
    {
        Console.WriteLine($"Livro {book.BookName},");
        Console.WriteLine($"do autor {book.AuthorName},");
        Console.WriteLine($"Editora {book.Editor},");
        Console.WriteLine($"Número de páginas {book.TotalPages}");
    }
}