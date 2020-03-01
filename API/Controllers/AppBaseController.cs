using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public AppBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

    }
}