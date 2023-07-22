using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Crypto
{
    public class LegacyAminoMultisig
    {
        public const string TypeUrl = "/cosmos.crypto.multisig.LegacyAminoPubKey";
        private readonly uint _threshold;
        private readonly List<PublicKey> _publicKeys;

        public LegacyAminoMultisig(uint t, List<PublicKey> keys)
        {
            _threshold = t;
            _publicKeys = keys;
        }

        public Any IntoProto()
        {
            var proto = new Cosmos.Crypto.Multisig.LegacyAminoPubKey
            {
                Threshold = _threshold,
            };
            proto.PublicKeys.Add(_publicKeys.Select(p => p.IntoProto()));

            return new Any
            {
                TypeUrl = TypeUrl,
                Value = proto.ToByteString()
            };
        }
    }
}