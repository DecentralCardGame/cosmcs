# Cosmcs
A C# client library for Cosmos SDK blockchains for netstandard2.1 with Unity support
This is modeled after [cosmrs](https://github.com/cosmos/cosmos-rust/tree/main/cosmrs)

## Build
```bash
git submodule sync
./gen_proto.sh
dotnet build
```

## Usage

### With `EasyClient`
`Cosmcs.Client.EasyClient` is an easy to use client object

```csharp
var rpcUrl = "http://localhost:9090";
var chainId = "mychain1";
var prefix = "cosmos";
byte[] privateKey = new byte[32]
{
    176, 139, 111, 219, 136, 19, 183,
    176, 135, 218, 199, 231, 70, 249,
    129, 238, 212, 167, 207, 147, 217,
    51, 43, 217, 82, 136, 182, 245,
    189, 104, 186, 17
};  // Place byte privateKey here
var queryClient = new QueryClient(rpcUrl);
var ec = new EasyClient(queryClient, chainId, privateKey, "cosmos");
// Using pregenerated routes
var authzTxClient = new Cosmos.Authz.V1beta1.MsgClient(ec);
// Using pregenerated queries
var authzQueryClient = new Cosmos.Authz.V1beta1.Query.QueryClient(ec.Channel);
```

### Unity
Due to Unity's lack of support for HTTP/2.0 and the fact that gRPC exclusively utilizes HTTP/2.0, specific options must be provided when initializing `EasyClient`. This adjustment allows the internal gRPC channel to utilize gRPC-Web, which is compatible with HTTP/1.x.
Cosmos blockchains start a grpc server on port `9090` and a grpc-web server on port `9091`.

```csharp
// ...
var rpcUrl = "http://localhost:9091";
var queryClient = new QueryClient(rpcUrl, new GrpcChannelOptions{
    HttpHandler = new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler())
});
var ec = new EasyClient(queryClient, chainId, privateKey, "cosmos", options);
// ...
```

### Examples
For a fully working example with codegeneration see [CardchainCs](https://github.com/DecentralCardGame/CardchainCs).

## License and Development
This is licensed under the GPL-v3 License, part of the [DecentralCardgame](https://github.com/DecentralCardGame) project and developed by [lxgr-linux](https://github.com/lxgr-linux).
