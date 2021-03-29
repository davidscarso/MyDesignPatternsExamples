using MediatR;
using services.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace services.Cars.Queries
{
    public class GetAllCarsQuery : IRequest<IEnumerable<Car>> { }

    public class GetAllCarsQueryhandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        // do dependency injection here if need
        public GetAllCarsQueryhandler()
        {
        }

        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return new[] {
            new Car { Name = "Ford"},
            new Car { Name = "Toyota"}
            };
        }
    }

}
