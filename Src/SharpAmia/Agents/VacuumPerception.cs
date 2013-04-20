namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class VacuumPerception
    {
        private VacuumStatus status;
        private VacuumLocation location;

        public VacuumPerception(VacuumLocation location, VacuumStatus status)
        {
            this.location = location;
            this.status = status;
        }

        public VacuumStatus Status { get { return this.status; } }

        public VacuumLocation Location { get { return this.location; } }
    }
}
