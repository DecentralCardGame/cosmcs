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

namespace Cosmos.Gov.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public MsgClient (IClient client) {
			Client = client;
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgSubmitProposalResponse>> SendMsgSubmitProposal(Cosmos.Gov.V1beta1.MsgSubmitProposal msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgSubmitProposal"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgSubmitProposalResponse>(
				r.Result,
				Cosmos.Gov.V1beta1.MsgSubmitProposalResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgSubmitProposal(Cosmos.Gov.V1beta1.MsgSubmitProposal msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgSubmitProposal"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgSubmitProposalResponse>> SimulateAndSendMsgSubmitProposal(Cosmos.Gov.V1beta1.MsgSubmitProposal msg) {
			return SimulateMsgSubmitProposal(msg).ContinueWith(r => {
				return SendMsgSubmitProposal(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgVoteResponse>> SendMsgVote(Cosmos.Gov.V1beta1.MsgVote msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgVote"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgVoteResponse>(
				r.Result,
				Cosmos.Gov.V1beta1.MsgVoteResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgVote(Cosmos.Gov.V1beta1.MsgVote msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgVote"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgVoteResponse>> SimulateAndSendMsgVote(Cosmos.Gov.V1beta1.MsgVote msg) {
			return SimulateMsgVote(msg).ContinueWith(r => {
				return SendMsgVote(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgVoteWeightedResponse>> SendMsgVoteWeighted(Cosmos.Gov.V1beta1.MsgVoteWeighted msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgVoteWeighted"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgVoteWeightedResponse>(
				r.Result,
				Cosmos.Gov.V1beta1.MsgVoteWeightedResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgVoteWeighted(Cosmos.Gov.V1beta1.MsgVoteWeighted msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgVoteWeighted"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgVoteWeightedResponse>> SimulateAndSendMsgVoteWeighted(Cosmos.Gov.V1beta1.MsgVoteWeighted msg) {
			return SimulateMsgVoteWeighted(msg).ContinueWith(r => {
				return SendMsgVoteWeighted(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
        public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgDepositResponse>> SendMsgDeposit(Cosmos.Gov.V1beta1.MsgDeposit msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgDeposit"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgDepositResponse>(
				r.Result,
				Cosmos.Gov.V1beta1.MsgDepositResponse.Parser
			));
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgDeposit(Cosmos.Gov.V1beta1.MsgDeposit msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.gov.v1beta1.MsgDeposit"
				}}
			);
		}

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmosCsharp", null)]
		public Task<Cosmcs.Client.ClientResponse<Cosmos.Gov.V1beta1.MsgDepositResponse>> SimulateAndSendMsgDeposit(Cosmos.Gov.V1beta1.MsgDeposit msg) {
			return SimulateMsgDeposit(msg).ContinueWith(r => {
				return SendMsgDeposit(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
	}
	
}