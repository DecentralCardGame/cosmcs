using Google.Protobuf;

namespace Cosmcs.Crypto;

public class CompactBitArray {
	private readonly Cosmos.Crypto.Multisig.V1beta1.CompactBitArray _inner;
	
	public CompactBitArray(uint extraBits, byte[] elems)
	{
		_inner = new Cosmos.Crypto.Multisig.V1beta1.CompactBitArray
		{
			ExtraBitsStored = extraBits,
			Elems = ByteString.CopyFrom(elems)
		};
	}
	
	public Cosmos.Crypto.Multisig.V1beta1.CompactBitArray Get()
	{
		return _inner;
	}
}