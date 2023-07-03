using Cosmcs.Crypto.Secp256k1;
using Google.Protobuf;

namespace Cosmcs.Tx;

public class SignDoc
{
	private byte[] _bodyBytes;
	private byte[] _authInfoBytes;
	private String _chainId;
	private ulong _accoutNumber;

	public SignDoc(Body body, AuthInfo authInfo, String chainId, ulong accoutNumber)
	{
		_bodyBytes = body.IntoBytes();
		_authInfoBytes = authInfo.IntoBytes();
		_chainId = chainId;
		_accoutNumber = accoutNumber;
	}

	public Raw Sign(PrivateKey privKey)
	{
		var signDocBytes = IntoBytes();
		var signature = privKey.Sign(signDocBytes);

		return new Raw(_bodyBytes, _authInfoBytes, new[] { signature });
	}

	public Cosmos.Tx.V1beta1.SignDoc IntoProto()
	{
		return new Cosmos.Tx.V1beta1.SignDoc
		{
			BodyBytes = ByteString.CopyFrom(_bodyBytes),
			AuthInfoBytes = ByteString.CopyFrom(_authInfoBytes),
			ChainId = _chainId,
			AccountNumber = _accoutNumber,
		};
	}

	public byte[] IntoBytes()
	{
		return IntoProto().ToByteArray();
	}
}