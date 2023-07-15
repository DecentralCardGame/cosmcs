using System.Text.RegularExpressions;

namespace Cosmcs.Base;

public class Denom {
	public String D {get;}
	
	public Denom(String s)
	{
		if (!Regex.IsMatch(s, @"^[[A-Z]|[a-z]|[0-9]|\/]*"))
		{
			throw new Exception("ne man");
		}
		D = s;
	}
}