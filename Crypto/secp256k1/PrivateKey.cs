using Google.Protobuf;
using NBitcoin.Secp256k1;

namespace Cosmcs.Crypto;

public class PrivateKey {
	private ECPrivKey inner;

	public PrivateKey(byte[] bytes) {
		inner = new Context().CreateECPrivKey(bytes);
	}

	public PublicKey publicKey()
	{
		return PublicKey.Secp256k1(inner.CreatePubKey());
	}

	public byte[] sign(byte[] bytes)
	{
		byte[] span = new byte[64];
		inner.SignECDSARFC6979(bytes).WriteCompactToSpan(span);
		return span;
	}

	public static PrivateKey fromProto(Cosmos.Crypto.Secp256k1.PrivKey k)
	{
		return new PrivateKey(k.Key.ToByteArray());
	}

	public Cosmos.Crypto.Secp256k1.PrivKey intoProto()
	{
		byte[] span = {};
		inner.WriteToSpan(span);
		return new Cosmos.Crypto.Secp256k1.PrivKey
		{
			Key	= ByteString.CopyFrom(span)
		};
	}

}