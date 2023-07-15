using Google.Protobuf;

namespace Cosmcs.Tx;

public class Raw {
	private readonly Cosmos.Tx.V1beta1.TxRaw _inner;
	
	public Raw(byte[] bodyBytes, byte[] authInfoBytes, byte[][] signatures)
	{
		_inner = new Cosmos.Tx.V1beta1.TxRaw
		{
			BodyBytes = ByteString.CopyFrom(bodyBytes),
			AuthInfoBytes = ByteString.CopyFrom(authInfoBytes),
		};
		_inner.Signatures.Add(signatures.Select(ByteString.CopyFrom));
	}
	
	public Cosmos.Tx.V1beta1.TxRaw IntoProto()
	{
		return _inner;
	}
	
	public T Broadcast<T>(Func<byte[], T> client)
	{
		return client(_inner.ToByteString().Span.ToArray());
	}
}