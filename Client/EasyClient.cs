using System.Threading.Tasks;
using Cosmcs.Auth;
using Cosmcs.Base;
using Cosmcs.Broadcaster;
using Cosmcs.Crypto.Secp256k1;
using Cosmcs.Tx;
using Google.Protobuf.WellKnownTypes;


namespace Cosmcs.Client
{
    public class EasyClient : IClient
    {
        public GrpcBroadcaster Broadcaster { get; }
        public PrivateKey PrivateKey { get; }
        public BaseAccount BaseAccount { get; }
        public AccountId AccoutAddress { get; }
        public string ChainId { get; }
        public QueryClient QueryClient { get; }
        public string Prefix { get; }
        public Cosmos.Tx.V1beta1.Service.ServiceClient TxClient { get; }

        public EasyClient(QueryClient queryClient, string chainId, byte[] privateKey)
        {
            ChainId = chainId;
            QueryClient = queryClient;
            Broadcaster = new GrpcBroadcaster(queryClient.Channel);
            PrivateKey = new PrivateKey(privateKey);
            TxClient = Broadcaster.TxClient;
            var pubkey = PrivateKey.PublicKey();
            Prefix = queryPrefix();
            AccoutAddress = pubkey.AccountId(Prefix);
            var queriedBaseAccount = GetBaseAccount();
            BaseAccount = new BaseAccount(
                AccoutAddress, pubkey, queriedBaseAccount.AccountNumber,
                queriedBaseAccount.Sequence
            );
        }

        public Task<Cosmos.Tx.V1beta1.GetTxResponse> QueryTx(string txHash)
        {
            return TxClient.GetTxAsync(new Cosmos.Tx.V1beta1.GetTxRequest
            {
                Hash = txHash
            }).ResponseAsync;
        }

        private string queryPrefix() {
            return QueryClient.AuthClient.Bech32Prefix(
                    new Cosmos.Auth.V1beta1.Bech32PrefixRequest {}
            ).Bech32Prefix;
        }

        public Task<Cosmos.Auth.V1beta1.QueryAccountResponse> QueryAccount(string addr)
        {
            return QueryClient.AuthClient.AccountAsync(new Cosmos.Auth.V1beta1.QueryAccountRequest { Address = addr })
                .ResponseAsync;
        }

        private BaseAccount GetBaseAccount()
        {
            var data = Cosmos.Auth.V1beta1.BaseAccount.Parser.ParseFrom(
                QueryAccount(AccoutAddress.ToString()).Result.Account.Value
            );
            return BaseAccount.FromProto(
                data
            );
        }

        public Task<Cosmos.Tx.V1beta1.BroadcastTxResponse> BuildAndBroadcast(Any[] msgs, Fee? fee = null)
        {
            var body = new Builder().AddMsgs(msgs).SetMemo("").Finish();
            var authInfo =
                new SignerInfo(PrivateKey.PublicKey().IntoSignerPublicKey(), BaseAccount.Sequence).AuthInfo(
                    fee ?? new Fee(400_000));
            var signDoc = new SignDoc(body, authInfo, ChainId, BaseAccount.AccountNumber);
            var txRaw = signDoc.Sign(PrivateKey);
            BaseAccount.IncSequence();
            return txRaw.BroadcastSync(Broadcaster);
        }

        public Task<Cosmos.Tx.V1beta1.SimulateResponse> BuildAndSimulate(Any[] msgs)
        {
            var body = new Builder().AddMsgs(msgs).SetMemo("").Finish();
            var authInfo =
                new SignerInfo(PrivateKey.PublicKey().IntoSignerPublicKey(), BaseAccount.Sequence).AuthInfo(
                    new Fee(0));
            var signDoc = new SignDoc(body, authInfo, ChainId, BaseAccount.AccountNumber);
            var txRaw = signDoc.Sign(PrivateKey);
            return txRaw.Simulate(Broadcaster);
        }
    }
}
