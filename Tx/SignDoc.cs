using Google.Protobuf;

namespace Cosmcs.Tx;

public class SignDoc
{
	private byte[] bodyBytes;
	private byte[] authInfoBytes;
	private String chainId;
	private ulong accoutNumber;

	public SignDoc(Body body, AuthInfo authInfo, String chainId, ulong accoutNumber)
	{
		bodyBytes = body.intoBytes();
		authInfoBytes = authInfo.intoBytes();
		this.chainId = chainId;
		this.accoutNumber = accoutNumber;
	}

	public Raw Sign(NBitcoin.Secp256k1.ECPrivKey privKey)
	{
		var sign_doc_bytes = intoBytes();
		var signature = privKey.SignBIP340(sign_doc_bytes);

		return new Raw(bodyBytes, authInfoBytes, new[] { signature.ToBytes() });
	}

	public Cosmos.Tx.V1beta1.SignDoc intoProto()
	{
		return new Cosmos.Tx.V1beta1.SignDoc
		{
			BodyBytes = ByteString.CopyFrom(bodyBytes),
			AuthInfoBytes = ByteString.CopyFrom(authInfoBytes),
			ChainId = chainId,
			AccountNumber = accoutNumber,
		};
	}

	public byte[] intoBytes()
	{
		return intoProto().ToByteArray();
	}
}