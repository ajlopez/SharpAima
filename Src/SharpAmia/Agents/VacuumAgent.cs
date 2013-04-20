namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class VacuumAgent
    {
        public VacuumLocation Location { get; set; }

        public int Performance { get; set; }

        public abstract VacuumAction GetAction(VacuumPerception perception);
    }
}
