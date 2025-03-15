using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Cosmos.Tx.V1beta1;
using Google.Protobuf;

namespace Cosmcs.Broadcaster
{
    public class DefaultBroadcaster : IBroadcaster<HttpContent>
    {
        public string BaseUrl { get; }
        public HttpClient Client { get; }
        public JsonFormatter Formatter { get; }
        public JsonParser Parser { get; }

        public DefaultBroadcaster(string baseurl, JsonFormatter? formatter = null, JsonParser? parser = null)
        {
            BaseUrl = baseurl;
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")
            );
            Client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            Formatter = formatter ?? new JsonFormatter(new JsonFormatter.Settings(true));
            Parser = parser ?? new JsonParser(new JsonParser.Settings(20));
        }

        public Task<T> Query<T>(string route) where T : IMessage, new()
        {
            return Client.GetAsync(new Uri(BaseUrl + route)).ContinueWith(
                r => r.Result.Content.ReadAsStringAsync().Result).ContinueWith(
                s => Parser.Parse<T>(s.Result));
        }

        public Task<HttpContent> Broadcast(byte[] bytes, Cosmos.Tx.V1beta1.BroadcastMode mode)
        {
            var content = new StringContent(
                Formatter.Format(
                    new Cosmos.Tx.V1beta1.BroadcastTxRequest
                    {
                        TxBytes = ByteString.CopyFrom(bytes),
                        Mode = mode
                    }
                )
            );
            return Client.PostAsync(
                new Uri($"{BaseUrl}cosmos/tx/v1beta1/txs"),
                content
            ).ContinueWith(r => r.Result.Content);
        }

        public Task<SimulateResponse> Simulate(byte[] bytes)
        {
            throw new NotImplementedException("Simulation is not planned for the default broadcaster");
        }
    }
}
