using System.Collections.Generic;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx
{
    public class Body
    {
        public List<Any> Messages { get; }
        public string Memo { get; private set; }
        public ulong TimeoutHeight { get; private set; }
        public List<Any> ExtensionOptions { get; }
        public List<Any> NonCriticalExtensionOptions { get; }

        public Body(List<Any>? messages = null, string memo = "", ulong timeoutHeight = 0)
        {
            Messages = messages ?? new List<Any>();
            Memo = memo;
            TimeoutHeight = timeoutHeight;
            ExtensionOptions = new List<Any>();
            NonCriticalExtensionOptions = new List<Any>();
        }

        public void AddMsgs(List<Any> msgs)
        {
            Messages.AddRange(msgs);
        }

        public void AddExtensionOptions(List<Any> opts)
        {
            ExtensionOptions.AddRange(opts);
        }

        public void AddNonCriticalExtensionOptions(List<Any> opts)
        {
            NonCriticalExtensionOptions.AddRange(opts);
        }

        public void SetMemo(string memo)
        {
            Memo = memo;
        }

        public void SetTimeoutHeight(ulong timeoutHeight)
        {
            TimeoutHeight = timeoutHeight;
        }

        public Cosmos.Tx.V1beta1.TxBody IntoProto()
        {
            var proto = new Cosmos.Tx.V1beta1.TxBody
            {
                Memo = Memo,
                TimeoutHeight = TimeoutHeight,
            };
            proto.Messages.Add(Messages);
            proto.ExtensionOptions.Add(ExtensionOptions);
            proto.NonCriticalExtensionOptions.Add(NonCriticalExtensionOptions);

            return proto;
        }

        public byte[] IntoBytes()
        {
            return IntoProto().ToByteArray();
        }
    }
}