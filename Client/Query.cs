using Grpc.Net.Client;

namespace Cosmcs.Client
{
    public class QueryClient
    {
        public GrpcChannel Channel { get; }
        public Cosmos.Auth.V1beta1.Query.QueryClient AuthClient { get; }
        public Cosmos.Bank.V1beta1.Query.QueryClient BankQueryClient { get; }
        public Cosmos.Authz.V1beta1.Query.QueryClient AuthzQueryClient { get; }
        public Cosmos.Gov.V1beta1.Query.QueryClient GovQueryClient { get; }

        public QueryClient(string rpcUrl, GrpcChannelOptions? options = null)
        {
            Channel = GrpcChannel.ForAddress(rpcUrl, options ?? new GrpcChannelOptions());
            AuthClient = new Cosmos.Auth.V1beta1.Query.QueryClient(Channel);
            BankQueryClient = new Cosmos.Bank.V1beta1.Query.QueryClient(Channel);
            AuthzQueryClient = new Cosmos.Authz.V1beta1.Query.QueryClient(Channel);
            GovQueryClient = new Cosmos.Gov.V1beta1.Query.QueryClient(Channel);
        }
    }

}
