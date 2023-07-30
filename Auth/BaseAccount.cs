using Cosmcs.Base;
using Cosmcs.Crypto;

namespace Cosmcs.Auth
{
    public class BaseAccount
    {
        public AccountId AccountId { get; }
        public PublicKey? Pubkey { get; }
        public ulong AccountNumber { get; }
        public ulong Sequence { get; }

        public BaseAccount(
            AccountId address,
            PublicKey? pubkey,
            ulong accountNumber,
            ulong sequence
        )
        {
            AccountId = address;
            Pubkey = pubkey;
            AccountNumber = accountNumber;
            Sequence = sequence;
        }

        public Cosmos.Auth.V1beta1.BaseAccount IntoProto()
        {
            return new Cosmos.Auth.V1beta1.BaseAccount
            {
                Address = AccountId.ToString(),
                PubKey = Pubkey?.IntoProto(),
                AccountNumber = AccountNumber,
                Sequence = Sequence
            };
        }

        public static BaseAccount FromProto(Cosmos.Auth.V1beta1.BaseAccount proto)
        {
            return new BaseAccount(
                AccountId.FromStringId(proto.Address),
                proto.PubKey == null ? null : PublicKey.FromProto(proto.PubKey),
                proto.AccountNumber,
                proto.Sequence
            );
        }
    }
}