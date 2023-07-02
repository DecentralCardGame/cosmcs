using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx;

public class Builder {
	private Body _body;
	
	public Builder()
	{
		_body = new Body();
	}
	
	public Builder AddMsgs(List<Any> msgs)
	{
		_body.AddMsgs(msgs);
		return this;	
	}
	
	public Builder SetMemo(String memo)
	{
		_body.SetMemo(memo);
		return this;
	}
	
	public Builder SetTimeOutHeigt(ulong timeoutHeight)
	{
		_body.SetTimeoutHeight(timeoutHeight);
		return this;
	}
	
	public Body Finish()
	{
		return _body;
	}
}