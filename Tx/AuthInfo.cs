using Google.Protobuf;

namespace Cosmcs.Tx;

public class AuthInfo {
	private List<SignerInfo> signerInfos;
	private Fee fee;
	
	public AuthInfo(List<SignerInfo> s, Fee f)
	{
		signerInfos = s;
		fee = f;
	}
	
	public Cosmos.Tx.V1beta1.AuthInfo intoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.AuthInfo
		{
			Fee = fee.intoProto()
		};
		proto.SignerInfos.Add(signerInfos.Select(s => s.intoProto()));

		return proto;
	}
	
	public byte[] intoBytes()
	{
		return intoProto().ToByteArray();
	}
}