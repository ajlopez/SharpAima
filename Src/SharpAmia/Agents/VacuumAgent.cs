namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class VacuumAgent
    {
        public abstract VacuumAction GetAction(VacuumPerception perception);

        public VacuumLocation Location { get; set; }
    }
}
