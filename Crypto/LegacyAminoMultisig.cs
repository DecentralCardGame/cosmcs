using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Crypto;

public class LegacyAminoMultisig {
	public const String TypeUrl = "/cosmos.crypto.multisig.LegacyAminoPubKey";
	
	private uint _threshold;
	private List<PublicKey> _publicKeys;
	
	public Any IntoProto()
	{
		var proto = new Cosmos.Crypto.Multisig.LegacyAminoPubKey
		{
			Threshold = _threshold,
		};
		proto.PublicKeys.Add(_publicKeys.Select(p => p.IntoProto()));
		
		return new Any
		{
			TypeUrl = TypeUrl,
			Value = proto.ToByteString()
		};
	}
}