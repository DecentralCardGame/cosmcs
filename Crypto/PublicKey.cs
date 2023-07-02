using Cosmcs.Tx;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Crypto;

public enum PublicKeyType
{
	ED25519,
	SECP256K1,
}

public class PublicKey
{
	private const String ED25519_TYPE_URL = "/cosmos.crypto.ed25519.PubKey";
	private const String SECP256K1_TYPE_URL = "/cosmos.crypto.secp256k1.PubKey";

	private PublicKeyType type;
	private byte[]? Ed25519_pub;
	private NBitcoin.Secp256k1.ECPubKey? SECP256K1_pub;

	private PublicKey(PublicKeyType type, byte[]? Ed25519_pub, NBitcoin.Secp256k1.ECPubKey? SECP256K1_pub)
	{
		this.type = type;
		this.Ed25519_pub = Ed25519_pub;
		this.SECP256K1_pub = SECP256K1_pub;
	}

	public static PublicKey Secp256k1(NBitcoin.Secp256k1.ECPubKey SECP256K1_pub)
	{
		return new PublicKey(PublicKeyType.SECP256K1, null, SECP256K1_pub);
	}

	public static PublicKey Ed25519(byte[]? Ed25519_pub)
	{
		return new PublicKey(PublicKeyType.ED25519, Ed25519_pub, null);
	}

	public Any intoProto()
	{
		switch (type)
		{
			case PublicKeyType.SECP256K1:
				return new Any
				{
					Value = new Cosmos.Crypto.Secp256k1.PubKey
					{
						Key = ByteString.CopyFrom(SECP256K1_pub.ToBytes())
					}.ToByteString(),
					TypeUrl = SECP256K1_TYPE_URL
				};
			case PublicKeyType.ED25519:
				return new Any
				{
					Value = new Cosmos.Crypto.Ed25519.PubKey
					{
						Key = ByteString.CopyFrom(Ed25519_pub)
					}.ToByteString(),
					TypeUrl = ED25519_TYPE_URL
				};
			default: throw new Exception("WTF");
		}
	}

	public SignerPublicKey IntoSignerPublicKey()
	{
		return SignerPublicKey.Single(this);
	}
}