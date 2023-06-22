using Google.Protobuf;
using Tendermint.RPC.Endpoint;

namespace Cosmcs.Tx;

public class Raw {
	private Cosmos.Tx.V1beta1.TxRaw inner;
	
	public Raw(byte[] bodyBytes, byte[] authInfoBytes, byte[][] signatures)
	{
		inner = new Cosmos.Tx.V1beta1.TxRaw
		{
			BodyBytes = ByteString.CopyFrom(bodyBytes),
			AuthInfoBytes = ByteString.CopyFrom(authInfoBytes),
		};
		inner.Signatures.Add(signatures.Select(ByteString.CopyFrom));
	}
	
	public Cosmos.Tx.V1beta1.TxRaw intoProto()
	{
		return inner;
	}
	
	public ResultBroadcastTxCommit BroadcastCommit(Tendermint.RPC.NodeRpcClient client)
	{
		return client.BroadcastTxCommit(inner.ToByteArray().ToString());
	}
}