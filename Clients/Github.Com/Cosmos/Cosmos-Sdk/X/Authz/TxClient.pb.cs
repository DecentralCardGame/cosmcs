// <auto-generated>
//    Code generated by protoc-gen-cosmosCsharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardgame project and written by lxgr@protonmail.com
// </auto-generated>

using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Authz.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Authz.V1beta1.MsgGrantResponse>> SendMsgGrant(Cosmos.Authz.V1beta1.MsgGrant msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgGrant"
				}}
			).ContinueWith(r =>
			{
				var res = r.Result;
				if (res.TxResponse.Code != 0)
				{
					return res.TxResponse;
				}
				System.Threading.Thread.Sleep(10000);
				return Client.QueryTx(res.TxResponse.Txhash).Result.TxResponse;
			})
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Authz.V1beta1.MsgGrantResponse>(
				r.Result,
				Cosmos.Authz.V1beta1.MsgGrantResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Authz.V1beta1.MsgExecResponse>> SendMsgExec(Cosmos.Authz.V1beta1.MsgExec msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgExec"
				}}
			).ContinueWith(r =>
			{
				var res = r.Result;
				if (res.TxResponse.Code != 0)
				{
					return res.TxResponse;
				}
				System.Threading.Thread.Sleep(10000);
				return Client.QueryTx(res.TxResponse.Txhash).Result.TxResponse;
			})
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Authz.V1beta1.MsgExecResponse>(
				r.Result,
				Cosmos.Authz.V1beta1.MsgExecResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Authz.V1beta1.MsgRevokeResponse>> SendMsgRevoke(Cosmos.Authz.V1beta1.MsgRevoke msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgRevoke"
				}}
			).ContinueWith(r =>
			{
				var res = r.Result;
				if (res.TxResponse.Code != 0)
				{
					return res.TxResponse;
				}
				System.Threading.Thread.Sleep(10000);
				return Client.QueryTx(res.TxResponse.Txhash).Result.TxResponse;
			})
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Authz.V1beta1.MsgRevokeResponse>(
				r.Result,
				Cosmos.Authz.V1beta1.MsgRevokeResponse.Parser
			));
		}

	}
}
