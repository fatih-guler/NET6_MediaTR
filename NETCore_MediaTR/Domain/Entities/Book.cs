using NETCore_MediaTR.Core.Domain;

namespace NETCore_MediaTR.Domain.Entities
{
    public class Book : RootEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string AuthorName { get; set; }

        public Book(string name, string category, string author)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = name;
            this.Category= category;
            this.AuthorName= author;
        }
    }
}
