using KesselRun.EventLockAndLoad.Event;

namespace KesselRun.EventLockAndLoad.Bus
{
    public interface IEventBus
    {
        void RaiseEvent(IEvent evt);
    }
}
