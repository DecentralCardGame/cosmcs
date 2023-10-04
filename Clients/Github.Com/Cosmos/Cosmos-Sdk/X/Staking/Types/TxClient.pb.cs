// <auto-generated>
//    Code generated by protoc-gen-cosmosCsharp plugin.  DO NOT EDIT!
//    The plugin is part of the DecentralCardgame project and written by lxgr@protonmail.com
// </auto-generated>
#nullable enable

using Cosmcs.Client;
using Cosmcs.Tx;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

namespace Cosmos.Staking.V1beta1 {
	
	public class MsgClient {
		public IClient Client { get; }

		public MsgClient (IClient client) {
			Client = client;
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgCreateValidatorResponse>> SendMsgCreateValidator(Cosmos.Staking.V1beta1.MsgCreateValidator msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgCreateValidator"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgCreateValidatorResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgCreateValidatorResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgEditValidatorResponse>> SendMsgEditValidator(Cosmos.Staking.V1beta1.MsgEditValidator msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgEditValidator"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgEditValidatorResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgEditValidatorResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgDelegateResponse>> SendMsgDelegate(Cosmos.Staking.V1beta1.MsgDelegate msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgDelegate"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgDelegateResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgDelegateResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgBeginRedelegateResponse>> SendMsgBeginRedelegate(Cosmos.Staking.V1beta1.MsgBeginRedelegate msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgBeginRedelegate"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgBeginRedelegateResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgBeginRedelegateResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgUndelegateResponse>> SendMsgUndelegate(Cosmos.Staking.V1beta1.MsgUndelegate msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgUndelegate"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgUndelegateResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgUndelegateResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgCancelUnbondingDelegationResponse>> SendMsgCancelUnbondingDelegation(Cosmos.Staking.V1beta1.MsgCancelUnbondingDelegation msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgCancelUnbondingDelegation"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgCancelUnbondingDelegationResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgCancelUnbondingDelegationResponse.Parser
			));
		}

		public Task<Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgUpdateParamsResponse>> SendMsgUpdateParams(Cosmos.Staking.V1beta1.MsgUpdateParams msg, Fee? fee = null) {
			return Client.BuildAndBroadcast(new Any[] {
				new Any
				{
					Value = msg.ToByteString(),
					TypeUrl = "/cosmos.staking.v1beta1.MsgUpdateParams"
				}},
				fee
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
			.ContinueWith(r => new Cosmcs.Client.ClientResponse<Cosmos.Staking.V1beta1.MsgUpdateParamsResponse>(
				r.Result,
				Cosmos.Staking.V1beta1.MsgUpdateParamsResponse.Parser
			));
		}

	}
}
