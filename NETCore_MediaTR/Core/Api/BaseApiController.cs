using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NETCore_MediaTR.Core.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        // Created a BaseController to not make DI for any controller added
        // Gonna inherit controllers from this base controller
        protected readonly IMediator mediator;

        public BaseApiController(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
