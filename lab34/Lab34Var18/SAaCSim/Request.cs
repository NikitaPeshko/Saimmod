using System.Collections.Generic;

namespace SAaCSim
{
    enum RequestState
    {
        Discarded,
        Processing,
        Pending,
        Completed,
        DoubleProssesing
    }

    class Request
    {
        public RequestState State;
        public int ExistingTime;
        public int CreationTact;
        public List<int> qElements = new List<int>();

        public void TicksPassed(int ticks = 1)
        {
            if (State == RequestState.Processing || State == RequestState.Pending)
            {
                ExistingTime = ExistingTime + ticks;
            }
        }
    }
}
