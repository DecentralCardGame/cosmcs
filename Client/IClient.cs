using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

namespace Cosmcs.Client{

    public interface IClient {
        public Task<string> BuildAndBroadcast(Any msg);
    }
}