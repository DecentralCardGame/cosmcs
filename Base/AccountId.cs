using System;
using System.Text.RegularExpressions;
using CardanoBech32;

namespace Cosmcs.Base
{
    public class AccountId
    {
        public const uint MaxLength = 255;

        public string Bech32 { get; }
        public uint HrpLength { get; }

        public AccountId(string prefix, byte[] bytes)
        {
            var id = Bech32Engine.Encode(prefix, bytes);
            if (!Regex.IsMatch(prefix, "^[[a-z]|[0-9]]*"))
            {
                throw new Exception("expected prefix to be lowercase alphanumeric characters only");
            }

            if (1 < bytes.Length && bytes.Length <= MaxLength)
            {
                Bech32 = id;
                HrpLength = (uint)prefix.Length;
            }
            else
            {
                throw new Exception($"wrong bytes length min: 1, max; {MaxLength}, but is {bytes.Length}");
            }
        }

        public static AccountId FromStringId(string stringId)
        {
            Bech32Engine.Decode(stringId, out var hrp, out var data);
            return new AccountId(hrp, data);
        }

        public override string ToString()
        {
            return Bech32;
        }
    }
}