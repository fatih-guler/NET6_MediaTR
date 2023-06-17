using MediatR;

namespace NETCore_MediaTR.Dtos
{
    public class BookCreateDto : IRequest<string>
    { 
        public string Name { get; set; }
        public string Category { get; set; }
        public string AuthorName { get; set; }
    }
}
