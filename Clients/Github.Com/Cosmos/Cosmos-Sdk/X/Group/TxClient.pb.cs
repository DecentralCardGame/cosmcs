// Code generated by lxgr
using Cosmcs.Client;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Group.V1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgCreateGroupResponse>> SendMsgCreateGroup(Cosmos.Group.V1.MsgCreateGroup msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgCreateGroup"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgCreateGroupResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgCreateGroupResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupMembersResponse>> SendMsgUpdateGroupMembers(Cosmos.Group.V1.MsgUpdateGroupMembers msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgUpdateGroupMembers"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupMembersResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgUpdateGroupMembersResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupAdminResponse>> SendMsgUpdateGroupAdmin(Cosmos.Group.V1.MsgUpdateGroupAdmin msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgUpdateGroupAdmin"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupAdminResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgUpdateGroupAdminResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupMetadataResponse>> SendMsgUpdateGroupMetadata(Cosmos.Group.V1.MsgUpdateGroupMetadata msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgUpdateGroupMetadata"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupMetadataResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgUpdateGroupMetadataResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgCreateGroupPolicyResponse>> SendMsgCreateGroupPolicy(Cosmos.Group.V1.MsgCreateGroupPolicy msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgCreateGroupPolicy"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgCreateGroupPolicyResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgCreateGroupPolicyResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgCreateGroupWithPolicyResponse>> SendMsgCreateGroupWithPolicy(Cosmos.Group.V1.MsgCreateGroupWithPolicy msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgCreateGroupWithPolicy"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgCreateGroupWithPolicyResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgCreateGroupWithPolicyResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupPolicyAdminResponse>> SendMsgUpdateGroupPolicyAdmin(Cosmos.Group.V1.MsgUpdateGroupPolicyAdmin msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgUpdateGroupPolicyAdmin"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupPolicyAdminResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgUpdateGroupPolicyAdminResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupPolicyDecisionPolicyResponse>> SendMsgUpdateGroupPolicyDecisionPolicy(Cosmos.Group.V1.MsgUpdateGroupPolicyDecisionPolicy msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgUpdateGroupPolicyDecisionPolicy"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupPolicyDecisionPolicyResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgUpdateGroupPolicyDecisionPolicyResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupPolicyMetadataResponse>> SendMsgUpdateGroupPolicyMetadata(Cosmos.Group.V1.MsgUpdateGroupPolicyMetadata msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgUpdateGroupPolicyMetadata"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgUpdateGroupPolicyMetadataResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgUpdateGroupPolicyMetadataResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgSubmitProposalResponse>> SendMsgSubmitProposal(Cosmos.Group.V1.MsgSubmitProposal msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgSubmitProposal"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgSubmitProposalResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgSubmitProposalResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgWithdrawProposalResponse>> SendMsgWithdrawProposal(Cosmos.Group.V1.MsgWithdrawProposal msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgWithdrawProposal"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgWithdrawProposalResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgWithdrawProposalResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgVoteResponse>> SendMsgVote(Cosmos.Group.V1.MsgVote msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgVote"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgVoteResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgVoteResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgExecResponse>> SendMsgExec(Cosmos.Group.V1.MsgExec msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgExec"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgExecResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgExecResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgLeaveGroupResponse>> SendMsgLeaveGroup(Cosmos.Group.V1.MsgLeaveGroup msg) {
			return Client.BuildAndBroadcast(
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.group.v1.MsgLeaveGroup"
				}
			).ContinueWith(r =>
			{
				System.Threading.Thread.Sleep(10000);
				return r.Result;
			})
			.ContinueWith(r => Client.QueryTx(r.Result.TxResponse.Txhash))
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Group.V1.MsgLeaveGroupResponse>(
				r.Result.Result.TxResponse,
				Cosmos.Group.V1.MsgLeaveGroupResponse.Parser
			));
		}

	}
}
