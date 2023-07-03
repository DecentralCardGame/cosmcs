using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx;

public class Body {
	private List<Any> _messages;
	private String _memo;
	private ulong _timeoutHeight;
	private List<Any> _extensionOptions;
	private List<Any> _nonCriticalExtensionOptions;
	
	public Body(List<Any>? messages = null, String memo = "", ulong timeoutHeight = 0)
	{
		_messages = messages ?? new List<Any>();
		_memo = memo;
		_timeoutHeight = timeoutHeight;
		_extensionOptions = new List<Any>();
		_nonCriticalExtensionOptions = new List<Any>();
	}
	
	public void AddMsgs(List<Any> msgs)
	{
		_messages.AddRange(msgs);
	}
	
	public void SetMemo(String memo)
	{
		_memo = memo;
	}
	
	public void SetTimeoutHeight(ulong timeoutHeight)
	{
		_timeoutHeight = timeoutHeight;
	}

	public Cosmos.Tx.V1beta1.TxBody IntoProto()
	{
		var proto = new Cosmos.Tx.V1beta1.TxBody
		{
			Memo = _memo,
			TimeoutHeight = _timeoutHeight,
		};
		proto.Messages.Add(_messages);
		proto.ExtensionOptions.Add(_extensionOptions);
		proto.NonCriticalExtensionOptions.Add(_nonCriticalExtensionOptions);

		return proto;
	}

	public byte[] IntoBytes()
	{
		return IntoProto().ToByteArray();
	}
}