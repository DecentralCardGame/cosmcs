using Cosmcs.Crypto.Secp256k1;
using Google.Protobuf;

namespace Cosmcs.Tx
{
    public class SignDoc
    {
        public byte[] BodyBytes { get; }
        public byte[] AuthInfoBytes { get; }
        public string ChainId { get; }
        public ulong AccoutNumber { get; }

        public SignDoc(Body body, AuthInfo authInfo, string chainId, ulong accoutNumber)
        {
            BodyBytes = body.IntoBytes();
            AuthInfoBytes = authInfo.IntoBytes();
            ChainId = chainId;
            AccoutNumber = accoutNumber;
        }

        public Raw Sign(PrivateKey privKey)
        {
            var signDocBytes = IntoBytes();
            var signature = privKey.Sign(signDocBytes);

            return new Raw(BodyBytes, AuthInfoBytes, new[] { signature });
        }

        public Cosmos.Tx.V1beta1.SignDoc IntoProto()
        {
            return new Cosmos.Tx.V1beta1.SignDoc
            {
                BodyBytes = ByteString.CopyFrom(BodyBytes),
                AuthInfoBytes = ByteString.CopyFrom(AuthInfoBytes),
                ChainId = ChainId,
                AccountNumber = AccoutNumber,
            };
        }

        public byte[] IntoBytes()
        {
            return IntoProto().ToByteArray();
        }
    }
}