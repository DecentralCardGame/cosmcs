using Cosmcs.Crypto;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx;

public class SignerInfo {
	private SignerPublicKey? _publicKey;
	private ModeInfo _modeInfo;
	private ulong _sequence;

	public SignerInfo(SignerPublicKey? publicKey, ulong sequence)
	{
		_publicKey = publicKey;
		_sequence = sequence;
		_modeInfo = new ModeInfo(new SingleData(Cosmos.Tx.Signing.V1beta1.SignMode.Direct));
	}
	
	public AuthInfo AuthInfo(Fee fee)
	{
		return new AuthInfo(new List<SignerInfo>{this}, fee);
	}
	
	public Cosmos.Tx.V1beta1.SignerInfo IntoProto()
	{
		return new Cosmos.Tx.V1beta1.SignerInfo
		{
			Sequence = _sequence,
			ModeInfo = _modeInfo.IntoProto(),
			PublicKey = _publicKey?.IntoProto(),
		};
	}
}

public enum SignerPublicKeyType
{
	Single,
	LegacyAminoMultisig,
	Any,
}

public class SignerPublicKey
{
	private SignerPublicKeyType _type;
	private PublicKey? _single;
	private LegacyAminoMultisig? _legacyAminoMultisig;
	private Any? _any;
	
	public Any IntoProto()
	{
		switch(_type)
		{
			case SignerPublicKeyType.Any: return _any;
			case SignerPublicKeyType.LegacyAminoMultisig: return _legacyAminoMultisig.IntoProto();
			case SignerPublicKeyType.Single: return _single.IntoProto();
			default: throw new Exception("nene");
		}
	}

	private SignerPublicKey(
		SignerPublicKeyType type,
		PublicKey? single,
		LegacyAminoMultisig? legacyAminoMultisig,
		Any? any)
	{
		_type = type;
		_single = single;
		_legacyAminoMultisig = legacyAminoMultisig;
		_any = any;
	}

	public static SignerPublicKey Single(PublicKey key)
	{
		return new SignerPublicKey(SignerPublicKeyType.Single, key, null, null);
	}
}