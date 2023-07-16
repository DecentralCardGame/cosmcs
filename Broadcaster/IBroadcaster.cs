namespace Cosmcs.Broadcaster;

public interface IBroadcaster<T>
{
	public Task<T> Broadcast(byte[] bytes, Cosmos.Tx.V1beta1.BroadcastMode mode);
}