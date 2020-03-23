using System;

namespace EventRaiser
{
    public class LimitReachedEventArgs : EventArgs
    {
        public int Limit { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
