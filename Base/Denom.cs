using System.Text.RegularExpressions;

namespace Cosmcs.Base;

public class Denom {
	private String s;
	
	public Denom(String s)
	{
		if (!Regex.IsMatch(s, @"^[[A-Z]|[a-z]|[0-9]|\/]*"))
		{
			throw new Exception("ne man");
		}
		this.s = s;
	}
	
	public String denom() => s;
}