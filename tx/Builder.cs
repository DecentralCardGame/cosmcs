using Google.Protobuf.WellKnownTypes;

namespace cosmcs.tx;

public class Builder {
	private Body body;
	
	public Builder()
	{
		body = new Body();
	}
	
	public Builder addMsgs(List<Any> msgs)
	{
		body.addMsgs(msgs);
		return this;	
	}
	
	public Builder setMemo(String memo)
	{
		body.setMemo(memo);
		return this;
	}
	
	public Builder setTimeOutHeigt(long timeoutHeight)
	{
		body.setTimeoutHeight(timeoutHeight);
		return this;
	}
	
	public Body finish()
	{
		return body;
	}
}