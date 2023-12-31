using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Tx
{
    public class Builder
    {
        private readonly Body _body = new Body();

        public Builder AddMsgs(Any[] msgs)
        {
            _body.AddMsgs(msgs);
            return this;
        }

        public Builder SetMemo(string memo)
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
}