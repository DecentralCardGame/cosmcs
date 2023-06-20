using Google.Protobuf.WellKnownTypes;

namespace cosmcs.tx;

public class Body {
	private List<Any>? messages;
	private String memo;
	private long timeoutHeight;
	
	public Body(List<Any>? messages = null, String memo = "", long timeoutHeight = 0)
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
	
	public void setTimeoutHeight(long timeoutHeight)
	{
		this.timeoutHeight = timeoutHeight;
	}
}