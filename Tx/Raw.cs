using System;
using System.Linq;
using System.Threading.Tasks;
using Cosmcs.Broadcaster;
using Google.Protobuf;

namespace Cosmcs.Tx
{
    public class Raw
    {
        private readonly Cosmos.Tx.V1beta1.TxRaw _inner;

        public Raw(byte[] bodyBytes, byte[] authInfoBytes, byte[][] signatures)
        {
            _inner = new Cosmos.Tx.V1beta1.TxRaw
            {
                BodyBytes = ByteString.CopyFrom(bodyBytes),
                AuthInfoBytes = ByteString.CopyFrom(authInfoBytes),
                Signatures = { signatures.Select(ByteString.CopyFrom) }
            };
        }

        public Cosmos.Tx.V1beta1.TxRaw IntoProto()
        {
            return _inner;
        }

        [Obsolete]
        public Task<T> BroadcastCommit<T>(IBroadcaster<T> client)
        {
            return client.Broadcast(_inner.ToByteArray(), Cosmos.Tx.V1beta1.BroadcastMode.Block);
        }

        public Task<T> BroadcastSync<T>(IBroadcaster<T> client)
        {
            return client.Broadcast(_inner.ToByteArray(), Cosmos.Tx.V1beta1.BroadcastMode.Sync);
        }

        public Task<T> BroadcastAsync<T>(IBroadcaster<T> client)
        {
            return client.Broadcast(_inner.ToByteArray(), Cosmos.Tx.V1beta1.BroadcastMode.Async);
        }

        public Task<Cosmos.Tx.V1beta1.SimulateResponse> Simulate<T>(IBroadcaster<T> client)
        {
            return client.Simulate(_inner.ToByteArray());
        }
    }
}