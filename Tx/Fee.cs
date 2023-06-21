using Cosmcs.Base;

namespace Cosmcs.Tx;

public class Fee {
	private List<Coin> amount;
	private ulong gasLimit;
	private AccountId? payer;
	private AccountId? granter;
	
	public Fee(Coin amount, ulong gl)
	{
		this.amount = new List<Coin>{amount};
		gasLimit = gl;
	}
	
	public Cosmos.Tx.V1beta1.Fee intoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.Fee
		{
			GasLimit = gasLimit,
			Payer = payer?.ToString(),
			Granter = granter?.ToString()
		};
		proto.Amount.Add(amount.Select(a => a.intoProto()));
		
		return proto;
	}
}