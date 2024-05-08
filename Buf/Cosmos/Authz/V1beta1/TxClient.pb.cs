// <auto-generated>
//    Code generated by protoc-gen-cosmos-csharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardGame project and written by lxgr@protonmail.com
//    source: cosmos/authz/v1beta1/tx.proto
// </auto-generated>
#nullable enable

using System;
using Cosmcs.Client;
using Cosmcs.Tx;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Authz.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public MsgClient (IClient client) {
			Client = client;
		}
        
        /// <summary>
      	/// SendMsgGrant sends a MsgGrant transaction to the blockchain and waits
      	/// for a response.
      	/// </summary>
      	/// <param name="msg">The MsgGrant message that should be send.</param>
      	/// <param name="fee">The fees that will be paid.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
        public Task<Cosmcs.Client.ClientResponse<MsgGrantResponse>> SendMsgGrant(MsgGrant msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgGrant"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<MsgGrantResponse>(
				r.Result,
				MsgGrantResponse.Parser
			));
		}

		/// <summary>
      	/// SimulateMsgGrant simulates a MsgGrant transaction on the blockchain.
      	/// </summary>
      	/// <param name="msg">The MsgGrant message that should be simulated.</param>
		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgGrant(MsgGrant msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgGrant"
				}}
			);
		}

		/// <summary>
      	/// SimulateAndSendMsgGrant simulates, estimates fees and then sends a Grant transaction to the blockchain.
      	/// </summary>
      	/// <param name="msg">The MsgGrant message that should be send.</param>
		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public Task<Cosmcs.Client.ClientResponse<MsgGrantResponse>> SimulateAndSendMsgGrant(MsgGrant msg) {
			return SimulateMsgGrant(msg).ContinueWith(r => {
				return SendMsgGrant(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        /// <summary>
      	/// SendMsgExec sends a MsgExec transaction to the blockchain and waits
      	/// for a response.
      	/// </summary>
      	/// <param name="msg">The MsgExec message that should be send.</param>
      	/// <param name="fee">The fees that will be paid.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
        public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SendMsgExec(MsgExec msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgExec"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<MsgExecResponse>(
				r.Result,
				MsgExecResponse.Parser
			));
		}

		/// <summary>
      	/// SimulateMsgExec simulates a MsgExec transaction on the blockchain.
      	/// </summary>
      	/// <param name="msg">The MsgExec message that should be simulated.</param>
		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgExec(MsgExec msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgExec"
				}}
			);
		}

		/// <summary>
      	/// SimulateAndSendMsgExec simulates, estimates fees and then sends a Exec transaction to the blockchain.
      	/// </summary>
      	/// <param name="msg">The MsgExec message that should be send.</param>
		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public Task<Cosmcs.Client.ClientResponse<MsgExecResponse>> SimulateAndSendMsgExec(MsgExec msg) {
			return SimulateMsgExec(msg).ContinueWith(r => {
				return SendMsgExec(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
        /// <summary>
      	/// SendMsgRevoke sends a MsgRevoke transaction to the blockchain and waits
      	/// for a response.
      	/// </summary>
      	/// <param name="msg">The MsgRevoke message that should be send.</param>
      	/// <param name="fee">The fees that will be paid.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
        public Task<Cosmcs.Client.ClientResponse<MsgRevokeResponse>> SendMsgRevoke(MsgRevoke msg, Cosmcs.Tx.Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgRevoke"
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<MsgRevokeResponse>(
				r.Result,
				MsgRevokeResponse.Parser
			));
		}

		/// <summary>
      	/// SimulateMsgRevoke simulates a MsgRevoke transaction on the blockchain.
      	/// </summary>
      	/// <param name="msg">The MsgRevoke message that should be simulated.</param>
		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public Task<Cosmos.Tx.V1beta1.SimulateResponse> SimulateMsgRevoke(MsgRevoke msg) {
			return Client.BuildAndSimulate(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.authz.v1beta1.MsgRevoke"
				}}
			);
		}

		/// <summary>
      	/// SimulateAndSendMsgRevoke simulates, estimates fees and then sends a Revoke transaction to the blockchain.
      	/// </summary>
      	/// <param name="msg">The MsgRevoke message that should be send.</param>
		[global::System.CodeDom.Compiler.GeneratedCode("protoc-gen-cosmos-csharp", null)]
		public Task<Cosmcs.Client.ClientResponse<MsgRevokeResponse>> SimulateAndSendMsgRevoke(MsgRevoke msg) {
			return SimulateMsgRevoke(msg).ContinueWith(r => {
				return SendMsgRevoke(msg, new Cosmcs.Tx.Fee((ulong) Math.Ceiling(r.Result.GasInfo.GasUsed * 1.5))).Result;
			});
		}
        
	}
	
}
