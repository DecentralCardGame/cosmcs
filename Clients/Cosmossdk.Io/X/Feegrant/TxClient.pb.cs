// Code generated by lxgr
using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Feegrant.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>> SendMsgGrantAllowance(Cosmos.Feegrant.V1beta1.MsgGrantAllowance msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgGrantAllowance"
				}
			).ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>(r.Result, Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse.Parser));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>> SendMsgRevokeAllowance(Cosmos.Feegrant.V1beta1.MsgRevokeAllowance msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgRevokeAllowance"
				}
			).ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>(r.Result, Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse.Parser));
		}

	}
}
