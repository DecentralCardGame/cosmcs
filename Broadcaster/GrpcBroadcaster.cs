using System.Threading.Tasks;
using Cosmos.Tx.V1beta1;
using Google.Protobuf;
using Grpc.Net.Client;

namespace Cosmcs.Broadcaster
{
    public class GrpcBroadcaster : IBroadcaster<BroadcastTxResponse>
    {
        public Service.ServiceClient TxClient { get; }

        public GrpcBroadcaster(GrpcChannel channel)
        {
            TxClient = new Service.ServiceClient(channel);
        }

        public Task<BroadcastTxResponse> Broadcast(byte[] bytes, BroadcastMode mode)
        {
            return TxClient.BroadcastTxAsync(new BroadcastTxRequest
            {
                TxBytes = ByteString.CopyFrom(bytes),
                Mode = mode
            }).ResponseAsync;
        }
    }
}