using System;
using System.Text.RegularExpressions;
using CardanoBech32;

namespace Cosmcs.Base
{
    public class AccountId
    {
        public const uint MaxLength = 255;

        private readonly string _bech32;
        private readonly uint _hrpLength;

        public AccountId(string prefix, byte[] bytes)
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
                throw new Exception("not the right length bro");
            }
        }

        public static AccountId FromStringId(string stringId)
        {
            Bech32Engine.Decode(stringId, out var hrp, out var data);
            return new AccountId(hrp, data);
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
}