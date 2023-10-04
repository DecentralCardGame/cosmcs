using System.Threading.Tasks;
using Cosmcs.Tx;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Client{

    public interface IClient {
        public Task<Cosmos.Tx.V1beta1.GetTxResponse> QueryTx(string txHash);
        public Task<Cosmos.Tx.V1beta1.BroadcastTxResponse> BuildAndBroadcast(Any[] msgs, Fee? fee = null);
    }
}