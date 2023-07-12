using Google.Protobuf.Collections;

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
		Mode = m;
	}

	public Cosmos.Tx.Signing.V1beta1.SignMode Mode { get; init; }
}

public struct MultiData
{
	public MultiData(CompactBitArray b, List<ModeInfo> m)
	{
		Bitarray = b;
		ModeInfos = m;
	}

	public CompactBitArray Bitarray { get; init; }
	public List<ModeInfo> ModeInfos { get; init; }
}

public class ModeInfo
{
	private ModeInfoMode _mode;
	private SingleData? _singleData;
	private MultiData? _multiData;

	public ModeInfo(ModeInfoMode mode, SingleData? singleData, MultiData? multiData)
	{
		_mode = mode;
		_singleData = singleData;
		_multiData = multiData;
	}

	public ModeInfo(SingleData singleData)
	{
		_mode = ModeInfoMode.Single;
		_singleData = singleData;
	}

	public ModeInfo(MultiData multiData)
	{
		_mode = ModeInfoMode.Multi;
		_multiData = multiData;
	}

	public Cosmos.Tx.V1beta1.ModeInfo IntoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.ModeInfo();
		switch (_mode)
		{
			case ModeInfoMode.Single:
				proto.Single = new Cosmos.Tx.V1beta1.ModeInfo.Types.Single
				{
					Mode = _singleData!.Value.Mode
				};
				break;
			case ModeInfoMode.Multi:
				proto.Multi = new Cosmos.Tx.V1beta1.ModeInfo.Types.Multi
				{
					Bitarray = _multiData!.Value.Bitarray.Get(),
				};
				proto.Multi.ModeInfos.Add(_multiData.Value.ModeInfos.Select(m => m.IntoProto()));
				break;
		}
		return proto;
	}
}

