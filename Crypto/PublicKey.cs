using System;
using Cosmcs.Base;
using Cosmcs.Tx;
using DevHawk.Security.Cryptography;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using SHA256 = System.Security.Cryptography.SHA256;

namespace Cosmcs.Crypto
{
    public enum PublicKeyType
    {
        Ed25519,
        Secp256K1,
    }

    public class PublicKey
    {
        private const string Ed25519TypeUrl = "/cosmos.crypto.ed25519.PubKey";
        private const string Secp256K1TypeUrl = "/cosmos.crypto.secp256k1.PubKey";

        public PublicKeyType Type { get; }
        private readonly byte[]? _ed25519Pub;
        private readonly byte[]? _secp256K1Pub;

        private PublicKey(PublicKeyType type, byte[]? ed25519Pub, byte[]? secp256K1Pub)
        {
            Type = type;
            _ed25519Pub = ed25519Pub;
            _secp256K1Pub = secp256K1Pub;
        }

        public static PublicKey Secp256K1(byte[] key)
        {
            return new PublicKey(PublicKeyType.Secp256K1, null, key);
        }

        public static PublicKey Ed25519(byte[]? key)
        {
            return new PublicKey(PublicKeyType.Ed25519, key, null);
        }

        public AccountId AccountId(string prefix)
        {
            if (_secp256K1Pub != null)
            {
                var shaDigest = SHA256.Create().ComputeHash(_secp256K1Pub);
                var ripemdDigest = new RIPEMD160().ComputeHash(shaDigest);
                return new AccountId(prefix, ripemdDigest[..20]);
            }

            throw new Exception("not yet implemented for none secp256K1 keys");
        }

        public Any IntoProto()
        {
            switch (Type)
            {
                case PublicKeyType.Secp256K1:
                    return new Any
                    {
                        Value = new Cosmos.Crypto.Secp256k1.PubKey
                        {
                            Key = ByteString.CopyFrom(_secp256K1Pub)
                        }.ToByteString(),
                        TypeUrl = Secp256K1TypeUrl
                    };
                case PublicKeyType.Ed25519:
                    return new Any
                    {
                        Value = new Cosmos.Crypto.Ed25519.PubKey
                        {
                            Key = ByteString.CopyFrom(_ed25519Pub)
                        }.ToByteString(),
                        TypeUrl = Ed25519TypeUrl
                    };
                default: throw new Exception("no such type, please report");
            }
        }

        public static PublicKey FromProto(Any proto)
        {
            switch (proto.TypeUrl)
            {
                case Ed25519TypeUrl:
                    return Ed25519(Cosmos.Crypto.Ed25519.PubKey.Parser.ParseFrom(proto.Value).Key.ToByteArray());
                case Secp256K1TypeUrl:
                    return Secp256K1(Cosmos.Crypto.Secp256k1.PubKey.Parser.ParseFrom(proto.Value).Key.ToByteArray());
                default: throw new Exception("invalid typeUrl");
            }
        }

        public SignerPublicKey IntoSignerPublicKey()
        {
            return SignerPublicKey.Single(this);
        }
    }
}