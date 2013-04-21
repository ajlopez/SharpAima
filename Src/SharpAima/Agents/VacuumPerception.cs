namespace SharpAima.Agents
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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is VacuumPerception)
            {
                var perp = (VacuumPerception)obj;

                if (this.location == perp.location && this.status == perp.status)
                    return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.location.GetHashCode() + this.status.GetHashCode();
        }
    }
}
