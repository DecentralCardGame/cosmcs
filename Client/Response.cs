using System;
using Cosmos.Base.Abci.V1beta1;
using Cryptography.ECDSA;
using Google.Protobuf;

namespace Cosmcs.Client
{
    public class ClientResponse<T>
        where T : class, IMessage<T>, new()
    {
        public TxResponse RawResponse;
        public T? ResponseMessage;

        public ClientResponse(TxResponse value, MessageParser<T> parser)
        {
            RawResponse = value;
            if (RawResponse.Code != 0)
            {
                throw new MessageFailedException(RawResponse);
            }

            var wrapped = TxMsgData.Parser.ParseFrom(ByteString.CopyFrom(Hex.HexToBytes(RawResponse.Data)));
            if (wrapped.MsgResponses.Count > 0)
            {
                ResponseMessage = parser.ParseFrom(wrapped.MsgResponses[0].Value);
            }
        }
    }

    public class MessageFailedException : Exception
    {
        public TxResponse Resp { get; }

        public MessageFailedException(TxResponse resp)
            : base(FormatText(resp))
        {
            Resp = resp;
        }

        public MessageFailedException(TxResponse resp, Exception inner)
            : base(FormatText(resp), inner)
        {
            Resp = resp;
        }

        static string FormatText(TxResponse resp)
        {
            return $"Message Failed with code {resp.Code}: {resp.RawLog}";
        }
    }
}