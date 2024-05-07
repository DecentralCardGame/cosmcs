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

namespace Cosmos.Feegrant.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public MsgClient (IClient client) {
			Client = client;
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>> SendMsgGrantAllowance(Cosmos.Feegrant.V1beta1.MsgGrantAllowance msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgGrantAllowance"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>(
				r.Result,
				Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgGrantAllowance(Cosmos.Feegrant.V1beta1.MsgGrantAllowance msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgGrantAllowance"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgGrantAllowanceResponse>> SimulateAndSendMsgGrantAllowance(Cosmos.Feegrant.V1beta1.MsgGrantAllowance msg) {
			return SimulateMsgGrantAllowance(msg).ContinueWith(r => {
				return SendMsgGrantAllowance(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>> SendMsgRevokeAllowance(Cosmos.Feegrant.V1beta1.MsgRevokeAllowance msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgRevokeAllowance"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>(
				r.Result,
				Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgRevokeAllowance(Cosmos.Feegrant.V1beta1.MsgRevokeAllowance msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.feegrant.v1beta1.MsgRevokeAllowance"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Feegrant.V1beta1.MsgRevokeAllowanceResponse>> SimulateAndSendMsgRevokeAllowance(Cosmos.Feegrant.V1beta1.MsgRevokeAllowance msg) {
			return SimulateMsgRevokeAllowance(msg).ContinueWith(r => {
				return SendMsgRevokeAllowance(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
	}
	
}