﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
       private IMediator _mediator;
       protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
