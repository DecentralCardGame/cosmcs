using Google.Protobuf;

namespace Cosmcs.Tx;

public class AuthInfo {
	private List<SignerInfo> _signerInfos;
	private Fee _fee;
	
	public AuthInfo(List<SignerInfo> s, Fee f)
	{
		_signerInfos = s;
		_fee = f;
	}
	
	public Cosmos.Tx.V1beta1.AuthInfo IntoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.AuthInfo
		{
			Fee = _fee.IntoProto()
		};
		proto.SignerInfos.Add(_signerInfos.Select(s => s.IntoProto()));

		return proto;
	}
	
	public byte[] IntoBytes()
	{
		return IntoProto().ToByteArray();
	}
}