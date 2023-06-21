using System.Numerics;

namespace Cosmcs.Base;

public class Coin {
	private Denom denom;
	private BigInteger amount;
	
	public Coin(BigInteger a, String d)
	{
		if (a < 0)
		{
			throw new Exception("negativ amoun");
		}
		amount = a;
		denom = new Denom(d);
	}
	
	public Cosmos.Base.V1beta1.Coin intoProto()
	{
		return new Cosmos.Base.V1beta1.Coin
		{
			Amount = amount.ToString(),
			Denom = denom.denom()
		};
	}
}