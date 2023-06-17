using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NETCore_MediaTR.Core.Api;
using NETCore_MediaTR.Dtos;
using NETCore_MediaTR.Persistance;

namespace NETCore_MediaTR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : BaseApiController
    {
        public BooksController(IMediator mediator) : base(mediator)
        {
        }
        // To be able to see methods/actions in swagger, we have to put Http Method Names as [HttpGet], [HttpPost] etc. 
        [HttpGet]
        public IActionResult Get()
        {
            var model = MyStaticDatabase.Books;
            return Ok(model);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] BookCreateDto bookCreateDto)
        {
            var bookId = await this.mediator.Send(bookCreateDto);
            return Ok(bookId);
        }
    }
}
