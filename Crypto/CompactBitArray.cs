using Google.Protobuf;

public class CompactBitArray {
	private  Cosmos.Crypto.Multisig.V1beta1.CompactBitArray inner;
	
	public CompactBitArray(uint extraBits, byte[] elems)
	{
		inner = new Cosmos.Crypto.Multisig.V1beta1.CompactBitArray
		{
			ExtraBitsStored = extraBits,
			Elems = ByteString.CopyFrom(elems)
		};
	}
	
	public Cosmos.Crypto.Multisig.V1beta1.CompactBitArray get()
	{
		return inner;
	}
}