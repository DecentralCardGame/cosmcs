using cosmcs.crypto;
using Google.Protobuf.WellKnownTypes;

namespace cosmcs.tx;

public class SignerInfo {
	private SignerPublicKey? publicKey;
	private ModeInfo modeInfo;
	private long sequence;
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
}