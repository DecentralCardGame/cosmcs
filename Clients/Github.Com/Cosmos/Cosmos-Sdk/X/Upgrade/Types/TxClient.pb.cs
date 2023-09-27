// <auto-generated>
//    Code generated by protoc-gen-cosmosCsharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardgame project and written by lxgr@protonmail.com
// </auto-generated>

using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Upgrade.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse>> SendMsgSoftwareUpgrade(Cosmos.Upgrade.V1beta1.MsgSoftwareUpgrade msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.upgrade.v1beta1.MsgSoftwareUpgrade"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse>(
				r.Result,
				Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse>> SendMsgCancelUpgrade(Cosmos.Upgrade.V1beta1.MsgCancelUpgrade msg) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.upgrade.v1beta1.MsgCancelUpgrade"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse>(
				r.Result,
				Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse.Parser
			));
		}

	}
}
