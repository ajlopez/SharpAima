namespace SharpAima.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ModelBasedVacuumAgent : Agent<VacuumLocation, VacuumPerception, VacuumAction>
    {
        private IDictionary<VacuumLocation, VacuumStatus> state = new Dictionary<VacuumLocation, VacuumStatus>();

        public override VacuumAction GetAction(VacuumPerception perception)
        {
            this.state[perception.Location] = perception.Status;

            if (perception.Status == VacuumStatus.Dirty)
                return VacuumAction.Suck;

            if (this.state.ContainsKey(VacuumLocation.A) && this.state.ContainsKey(VacuumLocation.B) && this.state[VacuumLocation.A] == VacuumStatus.Clean && this.state[VacuumLocation.B] == VacuumStatus.Clean)
                return VacuumAction.NoOp;

            if (perception.Location == VacuumLocation.A)
                return VacuumAction.Right;

            return VacuumAction.Left;
        }
    }
}
