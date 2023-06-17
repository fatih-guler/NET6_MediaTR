using NETCore_MediaTR.Domain.Entities;

namespace NETCore_MediaTR.Persistance
{
    public static class MyStaticDatabase
    {
        // This class is used for keeping temp data. 

        private static List<Book> _books = new List<Book>();
        // Books object will be read only. Inserting an object to list is not allowed in this scenario.
        public static IReadOnlyCollection<Book> Books => _books;
        public static void AddBook(Book book)
        {
            _books.Add(book);
        }
    }
}
