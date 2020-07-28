using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcEchoService
{
    public class EchoService : Echo.EchoBase
    {
        private readonly ILogger<EchoService> _logger;
        public EchoService(ILogger<EchoService> logger)
        {
            _logger = logger;
        }

        public override Task<Repeated> GetEcho(Said said, ServerCallContext context)
        {
            return Task.FromResult(new Repeated
            {
                Something = "Echo of " + said.Something
            }) ;
        }
    }
}
