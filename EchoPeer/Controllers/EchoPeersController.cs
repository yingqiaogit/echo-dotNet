using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcEchoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EchoPeer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EchoPeersController : ControllerBase
    {
        private string echoHello = "Hello World from";

        private Echo.EchoClient echoClient;
        public EchoPeersController()
        {
            var echoChannel = GrpcChannel.ForAddress("https://localhost:5001");
            echoClient = new Echo.EchoClient(echoChannel);
        }
                    
        [HttpGet("{name}")]
        public string EchoGet(string name)
        {
            Said said = new Said { Something = name };

            var repeated = echoClient.GetEcho(said);

            return echoHello + " " + repeated.Something;
        }
    }
}
