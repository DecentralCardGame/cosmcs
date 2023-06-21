namespace Cosmcs.Tx;

public enum ModeInfoMode
{
	Single,
	Multi
}

public struct SingleData
{
	public SingleData(Cosmos.Tx.Signing.V1beta1.SignMode m)
	{
		mode = m;
	}

	public Cosmos.Tx.Signing.V1beta1.SignMode mode { get; init; }
}

public struct MultiData
{
	public MultiData(CompactBitArray b, List<ModeInfo> m)
	{
		bitarray = b;
		modeInfos = m;
	}

	public CompactBitArray bitarray { get; init; }
	public List<ModeInfo> modeInfos { get; init; }
}

public class ModeInfo
{
	private ModeInfoMode mode;
	private SingleData? singleData;
	private MultiData? multiData;

	public ModeInfo(ModeInfoMode mode, SingleData? singleData, MultiData? multiData)
	{
		this.mode = mode;
		this.singleData = singleData;
		this.multiData = multiData;
	}

	public ModeInfo(SingleData singleData)
	{
		mode = ModeInfoMode.Single;
		this.singleData = singleData;
	}

	public ModeInfo(MultiData multiData)
	{
		mode = ModeInfoMode.Multi;
		this.multiData = multiData;
	}

	public Cosmos.Tx.V1beta1.ModeInfo intoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.ModeInfo();
		switch (mode)
		{
			case ModeInfoMode.Single:
				proto.Single.Mode = singleData.Value.mode;
				break;
			case ModeInfoMode.Multi:
				proto.Multi.Bitarray = multiData.Value.bitarray.get();
				proto.Multi.ModeInfos.Add(multiData.Value.modeInfos.Select(m => m.intoProto()));
				break;
		}
		return proto;
	}
}

