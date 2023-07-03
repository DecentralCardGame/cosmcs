using Cosmcs.Base;
using Cosmcs.Crypto;

namespace Cosmcs.Auth;

public class BaseAccount
{
	private AccountId _address;
	private PublicKey? _pubkey;
	private ulong _accountNumber;
	private ulong _sequence;

	public BaseAccount(
		AccountId address,
		PublicKey? pubkey,
		ulong accountNumber,
		ulong sequence
	)
	{
		_address = address;
		_pubkey = pubkey;
		_accountNumber = accountNumber;
		_sequence = sequence;
	}

	public AccountId AccountId()
	{
		return _address;
	}

	public PublicKey? Pubkey()
	{
		return _pubkey;
	}

	public ulong AccountNumber()
	{
		return _accountNumber;
	}

	public ulong Sequence()
	{
		return _sequence;
	}

	public Cosmos.Auth.V1beta1.BaseAccount IntoProto()
	{
		return new Cosmos.Auth.V1beta1.BaseAccount
		{
			Address = _address.ToString(),
			PubKey = _pubkey?.IntoProto(),
			AccountNumber = _accountNumber,
			Sequence = _sequence
		};
	}

	public static BaseAccount FromProto(Cosmos.Auth.V1beta1.BaseAccount proto)
	{
		return new BaseAccount(
			new AccountId(proto.Address),
			PublicKey.FromProto(proto.PubKey),
			proto.AccountNumber,
			proto.Sequence
		);
	}
}