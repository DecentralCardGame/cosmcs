using System.Collections.Generic;
using System.Threading.Tasks;
using Cosmcs.Auth;
using Cosmcs.Base;
using Cosmcs.Broadcaster;
using Cosmcs.Crypto.Secp256k1;
using Cosmcs.Tx;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;

namespace Cosmcs.Client
{
    public class EasyClient : IClient
    {
        public DefaultBroadcaster Broadcaster { get; }
        public JsonFormatter Formatter { get; }
        public JsonParser Parser { get; }
        public PrivateKey PrivateKey { get; }
        public BaseAccount BaseAccount { get; }
        public AccountId AccoutAddress { get; }
        public string ChainId { get; }
        public GrpcChannel Channel { get; }
        public Cosmos.Auth.V1beta1.Query.QueryClient AuthClient { get; }

        public EasyClient(string baseUrl, string rpcUrl, string chainId, byte[] bytes, string prefix, TypeRegistry reg)
        {
            ChainId = chainId;
            Parser = new JsonParser(new JsonParser.Settings(20, reg));
            Formatter = new JsonFormatter(new JsonFormatter.Settings(true, reg));
            Broadcaster = new DefaultBroadcaster(baseUrl, Formatter, Parser);
            PrivateKey = new PrivateKey(bytes);
            Channel = GrpcChannel.ForAddress(rpcUrl);
            AuthClient = new Cosmos.Auth.V1beta1.Query.QueryClient(Channel);
            var pubkey = PrivateKey.PublicKey();
            AccoutAddress = pubkey.AccountId(prefix);
            var queriedBaseAccount = GetBaseAccount();
            BaseAccount = new BaseAccount(
                AccoutAddress, pubkey, queriedBaseAccount.AccountNumber,
                queriedBaseAccount.Sequence
            );
        }

        public Cosmos.Auth.V1beta1.QueryAccountResponse QueryAccount(string addr)
        {
            return AuthClient.Account(new Cosmos.Auth.V1beta1.QueryAccountRequest{Address = addr});
        }

        private BaseAccount GetBaseAccount()
        {
            var data = Cosmos.Auth.V1beta1.BaseAccount.Parser.ParseFrom(
                QueryAccount(AccoutAddress.ToString()).Account.Value
            );
            return BaseAccount.FromProto(
                data
            );
        }

        public Task<string> BuildAndBroadcast(Any msg)
        {
            var fee = new Fee(200_000);
            var body = new Builder().AddMsgs(new List<Any> { msg }).SetMemo("").Finish();
            var authInfo =
                new SignerInfo(PrivateKey.PublicKey().IntoSignerPublicKey(), BaseAccount.Sequence).AuthInfo(fee);
            var signDoc = new SignDoc(body, authInfo, ChainId, BaseAccount.AccountNumber);
            var txRaw = signDoc.Sign(PrivateKey);
            return txRaw.BroadcastSync(Broadcaster).Result.ReadAsStringAsync();
        }
    }
}