using System.Text.RegularExpressions;
using CardanoBech32;

namespace Cosmcs.Base;

public class AccountId
{
	public const uint MaxLength = 255;

	private readonly String _bech32;
	private readonly uint _hrpLength;

	public AccountId(String prefix, byte[] bytes)
	{
		var id = Bech32Engine.Encode(prefix, bytes);
		if (!Regex.IsMatch(prefix, @"^[[a-z]|[0-9]]*"))
		{
			throw new Exception("expected prefix to be lowercase alphanumeric characters only");
		}

		if (1 < bytes.Length && bytes.Length <= MaxLength)
		{
			_bech32 = id;
			_hrpLength = (uint)prefix.Length;
		}
		else
		{
			throw new Exception("No the right length bro");
		}
	}

	public static AccountId FromStringId(String stringId)
	{
		Bech32Engine.Decode(stringId, out var hrp, out var data);
		return new(hrp, data);
	}

	public uint HrpLength()
	{
		return _hrpLength;
	}

	public override string ToString()
	{
		return _bech32;
	}
}