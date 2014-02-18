using System.Collections.Generic;
using KesselRun.EventLockAndLoad.Event;

namespace KesselRun.EventLockAndLoad.Bus
{
    public class AggregateEventBus : List<IEventBus>, IEventBus
    { 
        public void RaiseEvent(IEvent evt)
        {
            foreach (var eventBus in this)
            {
                eventBus.RaiseEvent(evt);
            }
        }
    }
}
