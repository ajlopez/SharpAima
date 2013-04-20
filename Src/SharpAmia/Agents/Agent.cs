namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Agent<TLocation, TPerception, TAction>
    {
        public TLocation Location { get; set; }

        public int Performance { get; set; }

        public abstract TAction GetAction(TPerception perception);
    }
}
