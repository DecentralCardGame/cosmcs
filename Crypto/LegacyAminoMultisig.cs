using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Crypto;

public class LegacyAminoMultisig {
	public const String TYPE_URL = "/cosmos.crypto.multisig.LegacyAminoPubKey";
	
	private uint threshold;
	private List<PublicKey> publicKeys;
	
	public Any intoProto()
	{
		var proto = new Cosmos.Crypto.Multisig.LegacyAminoPubKey
		{
			Threshold = threshold,
		};
		proto.PublicKeys.Add(publicKeys.Select(p => p.intoProto()));
		
		return new Any
		{
			TypeUrl = TYPE_URL,
			Value = proto.ToByteString()
		};
	}
}