using Cryptography.ECDSA;
using Google.Protobuf;

namespace Cosmcs.Crypto.Secp256k1
{
    public class PrivateKey
    {
        private readonly byte[] _inner;

        public PrivateKey(byte[] bytes)
        {
            _inner = bytes;
        }

        public PublicKey PublicKey()
        {
            return Crypto.PublicKey.Secp256K1(Secp256K1Manager.GetPublicKey(_inner, true));
        }

        public byte[] Sign(byte[] bytes)
        {
            return Secp256K1Manager.SignCompact(Sha256Manager.GetHash(bytes), _inner, out _);
        }

        public static PrivateKey FromProto(Cosmos.Crypto.Secp256k1.PrivKey k)
        {
            return new PrivateKey(k.Key.ToByteArray());
        }

        public Cosmos.Crypto.Secp256k1.PrivKey IntoProto()
        {
            return new Cosmos.Crypto.Secp256k1.PrivKey
            {
                Key = ByteString.CopyFrom(_inner)
            };
        }
    }
}