namespace cosmcs.crypto;

public class LegacyAminoMultisig {
	public const String TYPE_URL = "/cosmos.crypto.multisig.LegacyAminoPubKey";
	
	private ulong threshold;
	private List<PublicKey> publicKeys;
}