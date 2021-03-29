using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using services.Cars.Queries;
using services.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator mediator;

        private HomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<IEnumerable<Car>> Index([FromBody] GetAllCarsQuery query)
        {
            return this.mediator.Send(query);
        }

    }
}
