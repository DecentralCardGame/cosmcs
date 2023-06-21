namespace cosmcs.tx;

public enum ModInfoMode
{
	Single,
	Multi
}

static class ModeInfoExtensions
{
	public static Cosmos.Tx.V1beta1.ModeInfo ToModeInfo(this ModeInfo mi)
	{
		switch (mi)
		{
			case ModeInfo.Single: return Cosmos.Tx.V1beta1.ModeInfo.Types.Single.;
			case ModeInfo.Multi: return Cosmos.Tx.V1beta1.ModeInfo.Types.Multi.;
			default: throw new ArgumentOutOfRangeException("shit");
		}
	}
}

public struct SingleData
{
	Cosmos.Tx.Signing.V1beta1.SignMode mode;
}

public struct MultiData
{
	CompactBitArray bitarray;
	List<ModeInfo> modeInfos;
}

public class ModeInfo
{
	private ModInfoMode mode;
	private SingleData? singleData;
	private MultiData? multiData;

	public ModeInfo(ModInfoMode mode, SingleData? singleData, MultiData? multiData)
	{
		this.mode = mode;
		this.singleData = singleData;
		this.multiData = multiData;
	}
}

