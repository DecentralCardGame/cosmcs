using Cosmcs.Base;

namespace Cosmcs.Tx;

public class Fee {
	private List<Coin> _amount;
	private ulong _gasLimit;
	private AccountId? _payer;
	private AccountId? _granter;
	
	public Fee(Coin amount, ulong gl)
	{
		_amount = new List<Coin>{amount};
		_gasLimit = gl;
	}
	
	public Cosmos.Tx.V1beta1.Fee IntoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.Fee
		{
			GasLimit = _gasLimit,
			Payer = _payer?.ToString(),
			Granter = _granter?.ToString()
		};
		proto.Amount.Add(_amount.Select(a => a.IntoProto()));
		
		return proto;
	}
}