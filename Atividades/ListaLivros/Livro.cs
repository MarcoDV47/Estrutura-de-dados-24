using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaLivros
{
    public enum BookEditors
    {
        Pinguço, Marreta, Goblin, CachorroLeitor, Nhonho
    }
    public class Book
    {
        public string? BookName;
        public string? AuthorName;
        public BookEditors Editor;
        public int TotalPages;
    }
}