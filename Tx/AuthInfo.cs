using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;

namespace Cosmcs.Tx
{
    public class AuthInfo
    {
        public List<SignerInfo> SignerInfos { get; }
        public Fee Fee { get; }

        public AuthInfo(List<SignerInfo> s, Fee f)
        {
            SignerInfos = s;
            Fee = f;
        }

        public Cosmos.Tx.V1beta1.AuthInfo IntoProto()
        {
            var proto = new Cosmos.Tx.V1beta1.AuthInfo
            {
                Fee = Fee.IntoProto(),
                Tip = null
            };
            proto.SignerInfos.Add(SignerInfos.Select(s => s.IntoProto()));

            return proto;
        }

        public byte[] IntoBytes()
        {
            return IntoProto().ToByteArray();
        }
    }
}