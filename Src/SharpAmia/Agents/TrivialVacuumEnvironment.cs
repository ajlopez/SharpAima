namespace SharpAmia.Agents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TrivialVacuumEnvironment
    {
        private IDictionary<VacuumLocation, VacuumStatus> state = new Dictionary<VacuumLocation, VacuumStatus>();

        public VacuumPerception GetPerception(VacuumAgent agent)
        {
            return new VacuumPerception(agent.Location, this.state[agent.Location]);
        }

        public void SetStatus(VacuumLocation location, VacuumStatus status)
        {
            this.state[location] = status;
        }

        public VacuumStatus GetStatus(VacuumLocation location)
        {
            return this.state[location];
        }

        public void ExecuteAction(VacuumAgent agent, VacuumAction action)
        {
            if (action == VacuumAction.Suck)
                if (this.state[agent.Location] == VacuumStatus.Dirty)
                {
                    agent.Performance += 10;
                    this.state[agent.Location] = VacuumStatus.Clean;
                }
        }
    }
}
