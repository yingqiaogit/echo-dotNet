# echo-dotNet
Two dotNet projects realizing echo rest and gRPC services separately

## Visual Studio 2019
- open solution file: <repo>/GrpcEchoSerive/GrpcEchoService.sln

## Build
- in Visual Studio 2019, run build solution

## Run
- in <repo>/GrpcEchoService, run `dotNet run`
- in <repo>/EchoPeer, run `dotNet run`

## Use Case
- open a browser or a restful client (e.g., Postman)
- url `https://localhost:3001`, get welcome message
- url `https://localhost:3001/peers/<name>`, replace "\<name\>" with a string, get response from restful service without gRPC
- url `https://localhost:3001/echopeers/<name>`, replace "\<name\>" with a string, get response from restful service which accesses the gRPC Echo Server through a gRPC client 


## Port Number
- rest: 3000
- gRPC: 5001

## References
- https://auth0.com/blog/implementing-microservices-grpc-dotnet-core-3/

