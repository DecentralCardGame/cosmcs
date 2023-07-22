using System.Collections.Generic;
using System.Linq;
using Cosmcs.Crypto;

namespace Cosmcs.Tx {

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

		public Cosmos.Tx.Signing.V1beta1.SignMode Mode { get; }
	}

	public struct MultiData
	{
		public MultiData(CompactBitArray b, List<ModeInfo> m)
		{
			Bitarray = b;
			ModeInfos = m;
		}

		public CompactBitArray Bitarray { get; }
		public List<ModeInfo> ModeInfos { get; }
	}

	public class ModeInfo
	{
		public ModeInfoMode Mode {get;}
		private readonly SingleData? _singleData;
		private readonly MultiData? _multiData;

		public ModeInfo(ModeInfoMode mode, SingleData? singleData, MultiData? multiData)
		{
			Mode = mode;
			_singleData = singleData;
			_multiData = multiData;
		}

		public ModeInfo(SingleData singleData)
		{
			Mode = ModeInfoMode.Single;
			_singleData = singleData;
		}

		public ModeInfo(MultiData multiData)
		{
			Mode = ModeInfoMode.Multi;
			_multiData = multiData;
		}

		public Cosmos.Tx.V1beta1.ModeInfo IntoProto()
		{
			var proto = new Cosmos.Tx.V1beta1.ModeInfo();
			switch (Mode)
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
}

