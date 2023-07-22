using System.Collections.Generic;
using System.Linq;
using Cosmcs.Base;

namespace Cosmcs.Tx
{
    public class Fee
    {
        public List<Coin> Amount { get; set; }
        public ulong GasLimit { get; set; }
        public AccountId? Payer { get; set; }
        public AccountId? Granter { get; set; }

        public Fee(Coin amount, ulong gl)
        {
            Amount = new List<Coin> { amount };
            GasLimit = gl;
        }

        public Fee(ulong gl)
        {
            Amount = new List<Coin>();
            GasLimit = gl;
        }

        public Cosmos.Tx.V1beta1.Fee IntoProto()
        {
            var proto = new Cosmos.Tx.V1beta1.Fee
            {
                GasLimit = GasLimit,
                Payer = Payer?.ToString() ?? "",
                Granter = Granter?.ToString() ?? ""
            };
            proto.Amount.Add(Amount.Select(a => a.IntoProto()));

            return proto;
        }
    }
}