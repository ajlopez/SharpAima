namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class VacuumPerception
    {
        private VacuumStatus status;

        public VacuumPerception(VacuumLocation location, VacuumStatus status)
        {
            this.status = status;
        }

        public VacuumStatus Status { get { return this.status; } }
    }
}
