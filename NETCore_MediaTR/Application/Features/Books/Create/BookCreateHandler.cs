using MediatR;
using NETCore_MediaTR.Domain.Entities;
using NETCore_MediaTR.Dtos;
using NETCore_MediaTR.Persistance;

namespace NETCore_MediaTR.Application.Features.Books.Create
{
    public class BookCreateHandler : IRequestHandler<BookCreateDto, string>
    {
        // In this project, we do not have a database. We will keep data in static list
        public async Task<string> Handle(BookCreateDto request, CancellationToken cancellationToken)
        {
            var entity = new Book(request.Name, request.Category, request.AuthorName);
            MyStaticDatabase.AddBook(entity);
            return await Task.FromResult(entity.Id);

        }
    }
}
