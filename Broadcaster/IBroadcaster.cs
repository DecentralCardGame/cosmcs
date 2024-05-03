using System.Threading.Tasks;
using Cosmos.Tx.V1beta1;

namespace Cosmcs.Broadcaster
{
    public interface IBroadcaster<T>
    {
        public Task<T> Broadcast(byte[] bytes, BroadcastMode mode);
        public Task<SimulateResponse> Simulate(byte[] bytes);
    }
}