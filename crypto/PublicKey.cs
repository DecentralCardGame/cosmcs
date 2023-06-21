namespace cosmcs.crypto;

public enum PublicKeyType
{
	ED25519,
	SECP256K1,
}

public class PublicKey {
	private const String ED25519_TYPE_URL = "/cosmos.crypto.ed25519.PubKey";
	private const String SECP256K1_TYPE_URL = "/cosmos.crypto.secp256k1.PubKey";
	
	private PublicKeyType type;
	private []byte Ed25519_pub;
	private NBitcoin.Secp256k1.ECPubKey SECP256K1_pub;
}