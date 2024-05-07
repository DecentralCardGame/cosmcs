// <auto-generated>
//    Code generated by protoc-gen-cosmosCsharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardgame project and written by lxgr@protonmail.com
// </auto-generated>
#nullable enable

using System;
using Cosmcs.Client;
using Cosmcs.Tx;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Upgrade.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public MsgClient (IClient client) {
			Client = client;
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse>> SendMsgSoftwareUpgrade(Cosmos.Upgrade.V1beta1.MsgSoftwareUpgrade msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.upgrade.v1beta1.MsgSoftwareUpgrade"
				}},
				fee
			).ContinueWith(r =>
			{
				var res = r.Result;
				if (res.TxResponse.Code != 0)
				{
					return res.TxResponse;
				}
				System.Threading.Thread.Sleep(13000);
				return Client.QueryTx(res.TxResponse.Txhash).Result.TxResponse;
			})
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse>(
				r.Result,
				Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgSoftwareUpgrade(Cosmos.Upgrade.V1beta1.MsgSoftwareUpgrade msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.upgrade.v1beta1.MsgSoftwareUpgrade"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgSoftwareUpgradeResponse>> SimulateAndSendMsgSoftwareUpgrade(Cosmos.Upgrade.V1beta1.MsgSoftwareUpgrade msg) {
			return SimulateMsgSoftwareUpgrade(msg).ContinueWith(r => {
				return SendMsgSoftwareUpgrade(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse>> SendMsgCancelUpgrade(Cosmos.Upgrade.V1beta1.MsgCancelUpgrade msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.upgrade.v1beta1.MsgCancelUpgrade"
				}},
				fee
			).ContinueWith(r =>
			{
				var res = r.Result;
				if (res.TxResponse.Code != 0)
				{
					return res.TxResponse;
				}
				System.Threading.Thread.Sleep(13000);
				return Client.QueryTx(res.TxResponse.Txhash).Result.TxResponse;
			})
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse>(
				r.Result,
				Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgCancelUpgrade(Cosmos.Upgrade.V1beta1.MsgCancelUpgrade msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.upgrade.v1beta1.MsgCancelUpgrade"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Upgrade.V1beta1.MsgCancelUpgradeResponse>> SimulateAndSendMsgCancelUpgrade(Cosmos.Upgrade.V1beta1.MsgCancelUpgrade msg) {
			return SimulateMsgCancelUpgrade(msg).ContinueWith(r => {
				return SendMsgCancelUpgrade(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
	}
	
}
