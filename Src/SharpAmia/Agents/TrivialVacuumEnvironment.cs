using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpAmia.Agents
{
    public class TrivialVacuumEnvironment
    {
        IDictionary<VacuumLocation, VacuumStatus> state = new Dictionary<VacuumLocation, VacuumStatus>();

        public VacuumPerception GetPerception(VacuumAgent agent)
        {
            return new VacuumPerception(agent.Location, this.state[agent.Location]);
        }

        public void SetStatus(VacuumLocation location, VacuumStatus status)
        {
            state[location] = status;
        }
    }
}
