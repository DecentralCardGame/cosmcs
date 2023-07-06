using System.Text.RegularExpressions;
using CardanoBech32;

namespace Cosmcs.Base;

public class AccountId
{
	public const uint MAX_LENGTH = 255;

	private String _bech32;
	private uint _hrpLength;

	private void NewThis(String prefix, byte[] bytes)
	{
		var id = Bech32Engine.Encode(prefix, bytes);
		if (!Regex.IsMatch(prefix, @"^[[a-z]|[0-9]]*"))
		{
			throw new Exception("expected prefix to be lowercase alphanumeric characters only");
		}

		if (1 < bytes.Length && bytes.Length <= MAX_LENGTH)
		{
			_bech32 = id;
			_hrpLength = (uint)prefix.Length;
		}
		else
		{
			throw new Exception("No the right length bro");
		}
	}

	public AccountId(String prefix, byte[] bytes)
	{
		NewThis(prefix, bytes);
	}
	
	public AccountId(String stringId)
	{
		string hrp;
		byte[] data;
		Bech32Engine.Decode(stringId, out hrp, out data);
		NewThis(hrp, data);
	}

	public override string ToString()
	{
		return _bech32;
	}
}