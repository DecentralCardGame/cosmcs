using NBitcoin.Secp256k1;

namespace Cosmcs.Crypto;

public class PrivateKey {
	public PrivateKey(byte[] seed) {
		new	NBitcoin.Secp256k1.Context().CreateECPrivKey(seed);
	}
}