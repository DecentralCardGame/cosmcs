using Grpc.Net.Client;

namespace Cosmcs.Client {

    public struct EasyClientOptions {
        public EasyClientOptions(GrpcChannelOptions? go)
        {
            GrpcChannelOptions = go;
        }
        
        public GrpcChannelOptions? GrpcChannelOptions {get; set;}
    }

}