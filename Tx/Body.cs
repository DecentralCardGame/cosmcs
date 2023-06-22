using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx;

public class Body {
	private List<Any>? messages;
	private String memo;
	private ulong timeoutHeight;
	private List<Any> extensionOptions;
	private List<Any> nonCriticalExtensionOptions;
	
	public Body(List<Any>? messages = null, String memo = "", ulong timeoutHeight = 0)
	{
		this.messages = messages;
		this.memo = memo;
		this.timeoutHeight = timeoutHeight;
	}
	
	public void addMsgs(List<Any> msgs)
	{
		if (messages is not null)
		{
			messages = msgs;
		} else {
			messages.AddRange(msgs);
		}
	}
	
	public void setMemo(String memo)
	{
		this.memo = memo;
	}
	
	public void setTimeoutHeight(ulong timeoutHeight)
	{
		this.timeoutHeight = timeoutHeight;
	}

	public Cosmos.Tx.V1beta1.TxBody intoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.TxBody
		{
			Memo = memo,
			TimeoutHeight = timeoutHeight,
		};
		proto.Messages.Add(messages);
		proto.ExtensionOptions.Add(extensionOptions);
		proto.NonCriticalExtensionOptions.Add(nonCriticalExtensionOptions);

		return proto;
	}

	public byte[] intoBytes()
	{
		return this.intoProto().ToByteArray();
	}
}