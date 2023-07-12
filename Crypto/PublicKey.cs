using System.Security.Cryptography;
using Cosmcs.Base;
using Cosmcs.Tx;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using SHA256 = System.Security.Cryptography.SHA256;

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

	private PublicKeyType _type;
	private byte[]? _Ed25519_pub;
	private byte[]? _SECP256K1_pub;

	private PublicKey(PublicKeyType type, byte[]? Ed25519_pub, byte[]? SECP256K1_pub)
	{
		_type = type;
		_Ed25519_pub = Ed25519_pub;
		_SECP256K1_pub = SECP256K1_pub;
	}

	public static PublicKey Secp256k1(byte[] SECP256K1_pub)
	{
		return new PublicKey(PublicKeyType.SECP256K1, null, SECP256K1_pub);
	}

	public static PublicKey Ed25519(byte[]? Ed25519_pub)
	{
		return new PublicKey(PublicKeyType.ED25519, Ed25519_pub, null);
	}

	public AccountId AccountId(string prefix)
	{
		if (_SECP256K1_pub != null)
		{
			var shaDigest = SHA256.Create().ComputeHash(_SECP256K1_pub);
			var ripemdDigest = RIPEMD160.Create().ComputeHash(shaDigest);
			return new AccountId(prefix, ripemdDigest[..20]);
		}
		throw new Exception("neman");
	}

	public Any IntoProto()
	{
		switch (_type)
		{
			case PublicKeyType.SECP256K1:
				return new Any
				{
					Value = new Cosmos.Crypto.Secp256k1.PubKey
					{
						Key = ByteString.CopyFrom(_SECP256K1_pub)
					}.ToByteString(),
					TypeUrl = SECP256K1_TYPE_URL
				};
			case PublicKeyType.ED25519:
				return new Any
				{
					Value = new Cosmos.Crypto.Ed25519.PubKey
					{
						Key = ByteString.CopyFrom(_Ed25519_pub)
					}.ToByteString(),
					TypeUrl = ED25519_TYPE_URL
				};
			default: throw new Exception("WTF");
		}
	}

	public static PublicKey FromProto(Any proto)
	{
		switch (proto.TypeUrl)
		{
			case ED25519_TYPE_URL:
				return Ed25519(Cosmos.Crypto.Ed25519.PubKey.Parser.ParseFrom(proto.Value).Key.ToByteArray());
			case SECP256K1_TYPE_URL:
				return Secp256k1(Cosmos.Crypto.Secp256k1.PubKey.Parser.ParseFrom(proto.Value).Key.ToByteArray());
			default: throw new Exception("WTF");
		}
	}

	public SignerPublicKey IntoSignerPublicKey()
	{
		return SignerPublicKey.Single(this);
	}
}