using System.Numerics;

namespace Cosmcs.Base;

public class Coin {
	public Denom Denom {get;}
	public BigInteger Amount {get;}
	
	public Coin(BigInteger a, String d)
	{
		if (a < 0)
		{
			throw new Exception("negativ amoun");
		}
		Amount = a;
		Denom = new Denom(d);
	}
	
	public Cosmos.Base.V1beta1.Coin IntoProto()
	{
		return new Cosmos.Base.V1beta1.Coin
		{
			Amount = Amount.ToString(),
			Denom = Denom.D
		};
	}
}