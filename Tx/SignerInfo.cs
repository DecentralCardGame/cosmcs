using Cosmcs.Crypto;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx;

public class SignerInfo {
	private SignerPublicKey? publicKey;
	private ModeInfo modeInfo;
	private ulong sequence;

	public SignerInfo(SignerPublicKey? publicKey, ulong sequence)
	{
		this.publicKey = publicKey;
		this.sequence = sequence;
		modeInfo = new ModeInfo(new SingleData(Cosmos.Tx.Signing.V1beta1.SignMode.Direct));
	}
	
	public AuthInfo authInfo(Fee fee)
	{
		return new AuthInfo(new List<SignerInfo>{this}, fee);
	}
	
	public Cosmos.Tx.V1beta1.SignerInfo intoProto()
	{
		return new Cosmos.Tx.V1beta1.SignerInfo
		{
			Sequence = sequence,
			ModeInfo = modeInfo.intoProto(),
			PublicKey = publicKey?.intoProto(),
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
	private SignerPublicKeyType type;
	private PublicKey? single;
	private LegacyAminoMultisig? legacyAminoMultisig;
	private Any? any;
	
	public Any intoProto()
	{
		switch(type)
		{
			case SignerPublicKeyType.Any: return any;
			case SignerPublicKeyType.LegacyAminoMultisig: return legacyAminoMultisig.intoProto();
			case SignerPublicKeyType.Single: return single.intoProto();
			default: throw new Exception("nene");
		}
	}

	private SignerPublicKey(
		SignerPublicKeyType type,
		PublicKey? single,
		LegacyAminoMultisig? legacyAminoMultisig,
		Any? any)
	{
		this.type = type;
		this.single = single;
		this.legacyAminoMultisig = legacyAminoMultisig;
		this.any = any;
	}

	public static SignerPublicKey Single(PublicKey key)
	{
		return new SignerPublicKey(SignerPublicKeyType.Single, key, null, null);
	}
}