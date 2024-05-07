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

namespace Cosmos.Auth.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public MsgClient (IClient client) {
			Client = client;
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Auth.V1beta1.MsgUpdateParamsResponse>> SendMsgUpdateParams(Cosmos.Auth.V1beta1.MsgUpdateParams msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.auth.v1beta1.MsgUpdateParams"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Auth.V1beta1.MsgUpdateParamsResponse>(
				r.Result,
				Cosmos.Auth.V1beta1.MsgUpdateParamsResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgUpdateParams(Cosmos.Auth.V1beta1.MsgUpdateParams msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.auth.v1beta1.MsgUpdateParams"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Auth.V1beta1.MsgUpdateParamsResponse>> SimulateAndSendMsgUpdateParams(Cosmos.Auth.V1beta1.MsgUpdateParams msg) {
			return SimulateMsgUpdateParams(msg).ContinueWith(r => {
				return SendMsgUpdateParams(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
	}
	
}